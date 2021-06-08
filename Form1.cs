using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace HW3__
{
    public partial class Form1 : Form
    {
        Dictionary<string, int> top = new Dictionary<string, int>();
        string addedWord;
        string[] addedWords;
        string[] files;
        string[] dirs;
        Thread t;
        Thread t1;
        int count = 0;
        string pattern = "*******";
        string res = "Report:\n";
        object locker = new object();

        public Form1()
        {
            InitializeComponent();
            t = new Thread(Search);
            t1 = new Thread(End);
        }

        private void ADDbutton_Click(object sender, EventArgs e)
        {
            addedWord = WordsTextBox.Text;
            if (WordListBox.Items.Contains(addedWord)) return;
            WordListBox.Items.Add(addedWord);
        }

        private void ADDFFbutton_Click(object sender, EventArgs e)
        {
            if (WordsOpenFileDialog.ShowDialog() == DialogResult.Cancel) return;
            try
            {
                addedWord = WordsOpenFileDialog.FileName;
                addedWords = File.ReadAllLines(addedWord);
                foreach (string item in addedWords)
                {
                    if (WordListBox.Items.Contains(item)) return;
                    WordListBox.Items.Add(item);
                }
            }
            catch { }
        }

        private void SEARCHbutton_Click(object sender, EventArgs e)
        {
            res = "Отчёт:\n";
            Fill();
            if (WordListBox.Items.Count == 0) return;
            if (NeededFolderDialog.ShowDialog() == DialogResult.Cancel) return;
            addedWord = NeededFolderDialog.SelectedPath;
            progressBar1.Maximum = (Directory.GetFiles(addedWord).Length + Directory.GetDirectories(addedWord).Length);
            t.IsBackground = true;
            t.Priority = ThreadPriority.Highest;
            t.Start(addedWord);
        }
        void Fill()
        {
            WordListBox.Invoke(new Action(() =>
            {
                for(int i=0; i < WordListBox.Items.Count; i++)
                {
                    if (top.ContainsKey(WordListBox.Items[i].ToString())) return;
                    top.Add(WordListBox.Items[i].ToString(), 0);
                }
            }));
        }
        void Sort()
        {
            lock (res)
            {
                int i = 0;
                foreach (var pair in top.OrderByDescending(pair => pair.Value))
                {
                    if (i >= top.Count) break;
                    res += $"\n{pair.Key} - {pair.Value}";
                    i++;
                }
            }
           
        }
        private void End()
        {
            Thread.Sleep(1000);
            MessageBox.Show("Подготовка отчёта...");
            Thread.Sleep(4000);
            while (true)
            {
                if (!t.IsAlive)
                {
                    res += "\n Часто использованняе слова:";
                    Sort();
                    Thread.Sleep(3000);
                    lock (res)
                    {
                        FileInfo newFile = new FileInfo($"{addedWord}REPORT.txt");
                        using (StreamWriter sw = newFile.CreateText())
                        {
                            sw.WriteLineAsync(res);
                        }
                        MessageBox.Show(res);
                        WordListBox.Invoke(new Action(() => WordListBox.Items.Clear()));
                        progressBar1.Invoke(new Action(() => progressBar1.Value = 0));
                        WordListBox.Invoke(new Action(() => WordListBox.Enabled = true));
                        SEARCHbutton.Invoke(new Action(() => SEARCHbutton.Enabled = true));
                        button1.Invoke(new Action(() => button1.Enabled = false));
                        button2.Invoke(new Action(() => button2.Enabled = false));
                        button3.Invoke(new Action(() => button3.Enabled = false));
                        top.Clear();
                        break;
                    }        
                }
            }
            t1.Abort();
        }
        private void Search(object path)
        {
            lock (res)
            {
                WordListBox.Invoke(new Action(() => WordListBox.Enabled = false));
                SEARCHbutton.Invoke(new Action(() => SEARCHbutton.Enabled = false));
                button1.Invoke(new Action(() => button1.Enabled = true));
                button3.Invoke(new Action(() => button3.Enabled = true));
                files = Directory.GetFiles(path.ToString());
                dirs = Directory.GetDirectories(path.ToString());
                if (dirs == new string[0]) return;
                if (files == new string[0]) return;
                foreach(string d in dirs)
                {
                    DirsReaderWriter(d);
                }
                foreach (string f in files)
                {
                    FileReaderWriter(f);
                }
            }
            t1.IsBackground = true;
            t1.Priority = ThreadPriority.Lowest;
            t1.Start();
            t.Abort();
        }
       
        private void DirsReaderWriter(string path)
        {
            string [] d = Directory.GetDirectories(path);
            string[] f = Directory.GetFiles(path);
            if (d == new string[0]) return;
            if (f == new string[0]) return;
            foreach (string d1 in d)
            {
                DirsReaderWriter(d1);
            }
            foreach (string f1 in f)
            {
                FileReaderWriter(f1);
            }
        }
        private void FileReaderWriter(string path)
        {
            lock (res)
            {
                progressBar1.Invoke(new Action(() => progressBar1.PerformStep()));
                FileInfo oldFile = new FileInfo(path);
                string text;
                using (StreamReader sr = oldFile.OpenText())
                {
                    text = sr.ReadToEnd();
                }
                if (IsContain(text))
                {
                    lock (res)
                    {
                        FileInfo newFile = new FileInfo($"{oldFile.FullName}1.txt");
                        using (StreamWriter sw = newFile.CreateText())
                        {
                            sw.WriteLine(Change(text));
                            res = res + $"{oldFile.FullName}\tРазмер файла: {oldFile.Length}\tКолличество замен: {count}\n";
                        }
                    }
                }
                else return;
            }
        }
   
        string Change(string text)
        {
            WordListBox.Invoke(new Action(() =>
            {
                Parallel.For(0, WordListBox.Items.Count,
                (x =>
                {
                    if (text.Contains(WordListBox.Items[x].ToString()))
                    {
                        text = text.Replace(WordListBox.Items[x].ToString(), pattern);
                        ++top[WordListBox.Items[x].ToString()];
                    }
                }
                ));
            }));
            CountWords(text, pattern);
            return text;
        }
        private void CountWords(string s, string s0)
        {
            count = (s.Length - s.Replace(s0, "").Length) / s0.Length;
        }
        bool IsContain(string text)
        {
            bool isContain = false;
            WordListBox.Invoke(new Action(() =>
            {
                for (int i = 0; i < WordListBox.Items.Count; i++)
                {
                    if (text.Contains(WordListBox.Items[i].ToString())) isContain = true;
                }
            }));
            return isContain;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            t.Resume();
            t1.Resume();
            button2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            if(t.ThreadState== System.Threading.ThreadState.Running) t.Suspend();
            if (t1.ThreadState == System.Threading.ThreadState.Running) t1.Suspend();
            else return;
            button2.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This app is closing.");
            t.Abort();
            t1.Abort();
            this.Close();
        }
    }
}
