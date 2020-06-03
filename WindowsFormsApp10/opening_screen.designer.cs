namespace WindowsFormsApp10
{
    partial class opening_screen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.clean = new System.Windows.Forms.Button();
            this.connect = new System.Windows.Forms.Button();
            this.txt_User_Name = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // clean
            // 
            this.clean.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.clean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clean.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.clean.ForeColor = System.Drawing.Color.White;
            this.clean.Location = new System.Drawing.Point(214, 272);
            this.clean.Name = "clean";
            this.clean.Size = new System.Drawing.Size(235, 32);
            this.clean.TabIndex = 0;
            this.clean.Text = "ניקוי";
            this.clean.UseVisualStyleBackColor = false;
            this.clean.Click += new System.EventHandler(this.button1_Click);
            // 
            // connect
            // 
            this.connect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.connect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.connect.ForeColor = System.Drawing.Color.White;
            this.connect.Location = new System.Drawing.Point(214, 212);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(235, 39);
            this.connect.TabIndex = 1;
            this.connect.Text = "התחברות";
            this.connect.UseVisualStyleBackColor = false;
            this.connect.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_User_Name
            // 
            this.txt_User_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(92)))), ((int)(((byte)(136)))));
            this.txt_User_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txt_User_Name.ForeColor = System.Drawing.Color.Transparent;
            this.txt_User_Name.Location = new System.Drawing.Point(219, 135);
            this.txt_User_Name.Name = "txt_User_Name";
            this.txt_User_Name.Size = new System.Drawing.Size(179, 21);
            this.txt_User_Name.TabIndex = 3;
            // 
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(92)))), ((int)(((byte)(136)))));
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txt_password.ForeColor = System.Drawing.Color.Transparent;
            this.txt_password.Location = new System.Drawing.Point(219, 172);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(179, 21);
            this.txt_password.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(445, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "שם משתמש";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(470, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "סיסמה";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(480, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 37);
            this.label3.TabIndex = 7;
            this.label3.Text = "מלאכים בדרכים";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp10.Properties.Resources.הורדה1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 76);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // opening_screen
            // 
            this.AcceptButton = this.connect;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp10.Properties.Resources.backgruond1;
            this.ClientSize = new System.Drawing.Size(703, 394);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_User_Name);
            this.Controls.Add(this.connect);
            this.Controls.Add(this.clean);
            this.Name = "opening_screen";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Enter += new System.EventHandler(this.opening_screen_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clean;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.TextBox txt_User_Name;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}