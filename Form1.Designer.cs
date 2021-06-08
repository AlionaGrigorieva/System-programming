
namespace HW3__
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.WordListBox = new System.Windows.Forms.ListBox();
            this.ADDbutton = new System.Windows.Forms.Button();
            this.WordsTextBox = new System.Windows.Forms.TextBox();
            this.ADDFFbutton = new System.Windows.Forms.Button();
            this.SEARCHbutton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.WordsOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.NeededFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WordListBox
            // 
            this.WordListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WordListBox.FormattingEnabled = true;
            this.WordListBox.ItemHeight = 15;
            this.WordListBox.Location = new System.Drawing.Point(409, 48);
            this.WordListBox.Name = "WordListBox";
            this.WordListBox.Size = new System.Drawing.Size(200, 274);
            this.WordListBox.TabIndex = 0;
            // 
            // ADDbutton
            // 
            this.ADDbutton.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ADDbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ADDbutton.Location = new System.Drawing.Point(154, 185);
            this.ADDbutton.Name = "ADDbutton";
            this.ADDbutton.Size = new System.Drawing.Size(139, 23);
            this.ADDbutton.TabIndex = 1;
            this.ADDbutton.Text = "ADD";
            this.ADDbutton.UseVisualStyleBackColor = false;
            this.ADDbutton.Click += new System.EventHandler(this.ADDbutton_Click);
            // 
            // WordsTextBox
            // 
            this.WordsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WordsTextBox.Location = new System.Drawing.Point(105, 144);
            this.WordsTextBox.Name = "WordsTextBox";
            this.WordsTextBox.Size = new System.Drawing.Size(236, 22);
            this.WordsTextBox.TabIndex = 2;
            // 
            // ADDFFbutton
            // 
            this.ADDFFbutton.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ADDFFbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ADDFFbutton.Location = new System.Drawing.Point(154, 214);
            this.ADDFFbutton.Name = "ADDFFbutton";
            this.ADDFFbutton.Size = new System.Drawing.Size(139, 43);
            this.ADDFFbutton.TabIndex = 3;
            this.ADDFFbutton.Text = "ADD FROM FILE";
            this.ADDFFbutton.UseVisualStyleBackColor = false;
            this.ADDFFbutton.Click += new System.EventHandler(this.ADDFFbutton_Click);
            // 
            // SEARCHbutton
            // 
            this.SEARCHbutton.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.SEARCHbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SEARCHbutton.Location = new System.Drawing.Point(409, 339);
            this.SEARCHbutton.Name = "SEARCHbutton";
            this.SEARCHbutton.Size = new System.Drawing.Size(200, 43);
            this.SEARCHbutton.TabIndex = 4;
            this.SEARCHbutton.Text = "FIND AND CHANGE";
            this.SEARCHbutton.UseVisualStyleBackColor = false;
            this.SEARCHbutton.Click += new System.EventHandler(this.SEARCHbutton_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.ForeColor = System.Drawing.Color.Yellow;
            this.progressBar1.Location = new System.Drawing.Point(0, 427);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(794, 23);
            this.progressBar1.TabIndex = 5;
            // 
            // WordsOpenFileDialog
            // 
            this.WordsOpenFileDialog.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Goldenrod;
            this.button1.Location = new System.Drawing.Point(644, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 43);
            this.button1.TabIndex = 6;
            this.button1.Text = "STOP";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button2.Enabled = false;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.ForestGreen;
            this.button2.Location = new System.Drawing.Point(644, 155);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 43);
            this.button2.TabIndex = 7;
            this.button2.Text = "START";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button3.Enabled = false;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.DarkRed;
            this.button3.Location = new System.Drawing.Point(644, 227);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 43);
            this.button3.TabIndex = 8;
            this.button3.Text = "END";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(794, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.SEARCHbutton);
            this.Controls.Add(this.ADDFFbutton);
            this.Controls.Add(this.WordsTextBox);
            this.Controls.Add(this.ADDbutton);
            this.Controls.Add(this.WordListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox WordListBox;
        private System.Windows.Forms.Button ADDbutton;
        private System.Windows.Forms.TextBox WordsTextBox;
        private System.Windows.Forms.Button ADDFFbutton;
        private System.Windows.Forms.Button SEARCHbutton;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.OpenFileDialog WordsOpenFileDialog;
        private System.Windows.Forms.FolderBrowserDialog NeededFolderDialog;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

