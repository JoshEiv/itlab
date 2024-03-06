namespace DownloadManager
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnDownload = new Button();
            btnCancel = new Button();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            groupBox1 = new GroupBox();
            ProgressTimer = new System.Windows.Forms.Timer(components);
            progressBar = new ProgressBar();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnDownload
            // 
            btnDownload.Location = new Point(96, 291);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(75, 23);
            btnDownload.TabIndex = 0;
            btnDownload.Text = "Download";
            btnDownload.UseVisualStyleBackColor = true;
            btnDownload.Click += btnDownload_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(243, 291);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(79, 52);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(62, 19);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "Games";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(79, 77);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(119, 19);
            checkBox2.TabIndex = 3;
            checkBox2.Text = "Word Documents";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(79, 102);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(79, 19);
            checkBox3.TabIndex = 4;
            checkBox3.Text = "Excel Files";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(79, 127);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(52, 19);
            checkBox4.TabIndex = 5;
            checkBox4.Text = "PDFs";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(79, 152);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(61, 19);
            checkBox5.TabIndex = 6;
            checkBox5.Text = "Videos";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBox5);
            groupBox1.Controls.Add(checkBox4);
            groupBox1.Controls.Add(checkBox3);
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Location = new Point(84, 61);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(242, 228);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "File manager";
            // 
            // ProgressTimer
            // 
            ProgressTimer.Tick += ProgressTimer_Tick;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(0, 1);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(412, 32);
            progressBar.TabIndex = 8;
            progressBar.Click += progressBar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(413, 384);
            Controls.Add(progressBar);
            Controls.Add(groupBox1);
            Controls.Add(btnCancel);
            Controls.Add(btnDownload);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnDownload;
        private Button btnCancel;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
        private GroupBox groupBox1;
        private System.Windows.Forms.Timer ProgressTimer;
        private ProgressBar progressBar;
    }
}