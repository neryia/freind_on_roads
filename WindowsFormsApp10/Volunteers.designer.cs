namespace WindowsFormsApp10
{
    partial class Volunteers
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_last_phone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtfirstname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtlastname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtcoordinatey = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnshowall = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.log = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtcoordinatex = new System.Windows.Forms.TextBox();
            this.txtstatus = new System.Windows.Forms.CheckBox();
            this.txt_code_val = new System.Windows.Forms.TextBox();
            this.update = new System.Windows.Forms.Button();
            this.logid = new System.Windows.Forms.Label();
            this.clean = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.logphone = new System.Windows.Forms.Label();
            this.txtstartdate = new System.Windows.Forms.MonthCalendar();
            this.prof = new System.Windows.Forms.Button();
            this.txt_first_phone = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.הוספתמשתמש = new System.Windows.Forms.ToolStripMenuItem();
            this.לקוחות = new System.Windows.Forms.ToolStripMenuItem();
            this.שאילתות = new System.Windows.Forms.ToolStripMenuItem();
            this.טופסכונן = new System.Windows.Forms.ToolStripMenuItem();
            this.אירועים = new System.Windows.Forms.ToolStripMenuItem();
            this.אלגוריתםחכם = new System.Windows.Forms.ToolStripMenuItem();
            this.גרירות = new System.Windows.Forms.ToolStripMenuItem();
            this.תקלות = new System.Windows.Forms.ToolStripMenuItem();
            this.חמל = new System.Windows.Forms.ToolStripMenuItem();
            this.טפסילקוחותToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.התנתקותToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(92)))), ((int)(((byte)(136)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(674, 540);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txt_last_phone
            // 
            this.txt_last_phone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(92)))), ((int)(((byte)(136)))));
            this.txt_last_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txt_last_phone.ForeColor = System.Drawing.Color.White;
            this.txt_last_phone.Location = new System.Drawing.Point(793, 121);
            this.txt_last_phone.Name = "txt_last_phone";
            this.txt_last_phone.Size = new System.Drawing.Size(102, 20);
            this.txt_last_phone.TabIndex = 1;
            this.txt_last_phone.TextChanged += new System.EventHandler(this.phone_check);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.label1.Location = new System.Drawing.Point(894, 81);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(82, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "כוננים";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(964, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "פלאפון";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(934, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 14);
            this.label3.TabIndex = 5;
            this.label3.Text = "סטטוס זמינות";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(955, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 14);
            this.label4.TabIndex = 7;
            this.label4.Text = "שם פרטי";
            // 
            // txtfirstname
            // 
            this.txtfirstname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(92)))), ((int)(((byte)(136)))));
            this.txtfirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtfirstname.ForeColor = System.Drawing.Color.White;
            this.txtfirstname.Location = new System.Drawing.Point(733, 173);
            this.txtfirstname.Name = "txtfirstname";
            this.txtfirstname.Size = new System.Drawing.Size(162, 20);
            this.txtfirstname.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(982, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 14);
            this.label5.TabIndex = 9;
            this.label5.Text = "ת.ז";
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(92)))), ((int)(((byte)(136)))));
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtId.ForeColor = System.Drawing.Color.White;
            this.txtId.Location = new System.Drawing.Point(733, 237);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(162, 20);
            this.txtId.TabIndex = 8;
            this.txtId.TextChanged += new System.EventHandler(this.idcheck);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(940, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 14);
            this.label6.TabIndex = 11;
            this.label6.Text = "שם משפחה";
            // 
            // txtlastname
            // 
            this.txtlastname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(92)))), ((int)(((byte)(136)))));
            this.txtlastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtlastname.ForeColor = System.Drawing.Color.White;
            this.txtlastname.Location = new System.Drawing.Point(733, 205);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(162, 20);
            this.txtlastname.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Calibri", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(960, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 14);
            this.label7.TabIndex = 13;
            this.label7.Text = "נ.צ אורך";
            // 
            // txtcoordinatey
            // 
            this.txtcoordinatey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(92)))), ((int)(((byte)(136)))));
            this.txtcoordinatey.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtcoordinatey.ForeColor = System.Drawing.Color.White;
            this.txtcoordinatey.Location = new System.Drawing.Point(733, 268);
            this.txtcoordinatey.Name = "txtcoordinatey";
            this.txtcoordinatey.Size = new System.Drawing.Size(162, 20);
            this.txtcoordinatey.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Calibri", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(941, 399);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 14);
            this.label8.TabIndex = 15;
            this.label8.Text = "תאריך התחלה";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Calibri", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(970, 523);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 14);
            this.label9.TabIndex = 17;
            this.label9.Text = "קוד כונן";
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnsave.ForeColor = System.Drawing.Color.White;
            this.btnsave.Location = new System.Drawing.Point(711, 580);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(87, 41);
            this.btnsave.TabIndex = 18;
            this.btnsave.Text = "שמור";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnshowall
            // 
            this.btnshowall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.btnshowall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnshowall.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnshowall.ForeColor = System.Drawing.Color.White;
            this.btnshowall.Location = new System.Drawing.Point(711, 644);
            this.btnshowall.Name = "btnshowall";
            this.btnshowall.Size = new System.Drawing.Size(87, 41);
            this.btnshowall.TabIndex = 19;
            this.btnshowall.Text = "הצג הכל";
            this.btnshowall.UseVisualStyleBackColor = false;
            this.btnshowall.Click += new System.EventHandler(this.btnshowall_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.back.ForeColor = System.Drawing.Color.White;
            this.back.Location = new System.Drawing.Point(928, 641);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 41);
            this.back.TabIndex = 20;
            this.back.Text = "חזור";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // log
            // 
            this.log.AutoSize = true;
            this.log.BackColor = System.Drawing.Color.Transparent;
            this.log.Font = new System.Drawing.Font("Calibri", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.log.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.log.Location = new System.Drawing.Point(12, 659);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(60, 29);
            this.log.TabIndex = 21;
            this.log.Text = "LOG:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Calibri", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(959, 304);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 14);
            this.label11.TabIndex = 23;
            this.label11.Text = "נ.צ רוחב";
            // 
            // txtcoordinatex
            // 
            this.txtcoordinatex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(92)))), ((int)(((byte)(136)))));
            this.txtcoordinatex.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtcoordinatex.ForeColor = System.Drawing.Color.White;
            this.txtcoordinatex.Location = new System.Drawing.Point(733, 301);
            this.txtcoordinatex.Name = "txtcoordinatex";
            this.txtcoordinatex.Size = new System.Drawing.Size(162, 20);
            this.txtcoordinatex.TabIndex = 22;
            // 
            // txtstatus
            // 
            this.txtstatus.AutoSize = true;
            this.txtstatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(92)))), ((int)(((byte)(136)))));
            this.txtstatus.Location = new System.Drawing.Point(809, 150);
            this.txtstatus.Name = "txtstatus";
            this.txtstatus.Size = new System.Drawing.Size(15, 14);
            this.txtstatus.TabIndex = 25;
            this.txtstatus.UseVisualStyleBackColor = false;
            // 
            // txt_code_val
            // 
            this.txt_code_val.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(92)))), ((int)(((byte)(136)))));
            this.txt_code_val.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txt_code_val.ForeColor = System.Drawing.Color.White;
            this.txt_code_val.Location = new System.Drawing.Point(733, 520);
            this.txt_code_val.Name = "txt_code_val";
            this.txt_code_val.Size = new System.Drawing.Size(162, 20);
            this.txt_code_val.TabIndex = 26;
            this.txt_code_val.TextChanged += new System.EventHandler(this.checkupdate);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.update.ForeColor = System.Drawing.Color.White;
            this.update.Location = new System.Drawing.Point(806, 644);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(110, 41);
            this.update.TabIndex = 27;
            this.update.Text = "עדכון";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // logid
            // 
            this.logid.AutoSize = true;
            this.logid.BackColor = System.Drawing.Color.Transparent;
            this.logid.Font = new System.Drawing.Font("Calibri", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.logid.ForeColor = System.Drawing.Color.White;
            this.logid.Location = new System.Drawing.Point(712, 240);
            this.logid.Name = "logid";
            this.logid.Size = new System.Drawing.Size(16, 14);
            this.logid.TabIndex = 28;
            this.logid.Text = "id";
            // 
            // clean
            // 
            this.clean.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.clean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clean.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.clean.ForeColor = System.Drawing.Color.White;
            this.clean.Location = new System.Drawing.Point(809, 580);
            this.clean.Name = "clean";
            this.clean.Size = new System.Drawing.Size(107, 41);
            this.clean.TabIndex = 29;
            this.clean.Text = "ניקוי";
            this.clean.UseVisualStyleBackColor = false;
            this.clean.Click += new System.EventHandler(this.clean_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.delete.ForeColor = System.Drawing.Color.White;
            this.delete.Location = new System.Drawing.Point(928, 580);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 41);
            this.delete.TabIndex = 30;
            this.delete.Text = "מחק";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // logphone
            // 
            this.logphone.AutoSize = true;
            this.logphone.BackColor = System.Drawing.Color.Transparent;
            this.logphone.Font = new System.Drawing.Font("Calibri", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.logphone.ForeColor = System.Drawing.Color.White;
            this.logphone.Location = new System.Drawing.Point(692, 124);
            this.logphone.Name = "logphone";
            this.logphone.Size = new System.Drawing.Size(37, 14);
            this.logphone.TabIndex = 31;
            this.logphone.Text = "phone";
            // 
            // txtstartdate
            // 
            this.txtstartdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(92)))), ((int)(((byte)(136)))));
            this.txtstartdate.Location = new System.Drawing.Point(711, 335);
            this.txtstartdate.Name = "txtstartdate";
            this.txtstartdate.TabIndex = 32;
            // 
            // prof
            // 
            this.prof.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.prof.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prof.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.prof.ForeColor = System.Drawing.Color.White;
            this.prof.Location = new System.Drawing.Point(599, 644);
            this.prof.Name = "prof";
            this.prof.Size = new System.Drawing.Size(87, 41);
            this.prof.TabIndex = 35;
            this.prof.Text = "הגדר מקצוע";
            this.prof.UseVisualStyleBackColor = false;
            this.prof.Click += new System.EventHandler(this.prof_Click);
            // 
            // txt_first_phone
            // 
            this.txt_first_phone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(92)))), ((int)(((byte)(136)))));
            this.txt_first_phone.ForeColor = System.Drawing.Color.White;
            this.txt_first_phone.FormattingEnabled = true;
            this.txt_first_phone.Location = new System.Drawing.Point(735, 121);
            this.txt_first_phone.Name = "txt_first_phone";
            this.txt_first_phone.Size = new System.Drawing.Size(52, 21);
            this.txt_first_phone.TabIndex = 36;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Font = new System.Drawing.Font("Aharoni", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.התנתקותToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1015, 32);
            this.menuStrip1.TabIndex = 171;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.הוספתמשתמש,
            this.לקוחות,
            this.שאילתות,
            this.טופסכונן,
            this.אירועים,
            this.אלגוריתםחכם,
            this.גרירות,
            this.תקלות,
            this.חמל,
            this.טפסילקוחותToolStripMenuItem});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(63, 28);
            this.toolStripMenuItem1.Text = "ניווט";
            // 
            // הוספתמשתמש
            // 
            this.הוספתמשתמש.Name = "הוספתמשתמש";
            this.הוספתמשתמש.Size = new System.Drawing.Size(204, 28);
            this.הוספתמשתמש.Text = "הוספת משתמש";
            // 
            // לקוחות
            // 
            this.לקוחות.Name = "לקוחות";
            this.לקוחות.Size = new System.Drawing.Size(204, 28);
            this.לקוחות.Text = "לקוחות";
            this.לקוחות.Click += new System.EventHandler(this.לקוחות_Click);
            // 
            // שאילתות
            // 
            this.שאילתות.Name = "שאילתות";
            this.שאילתות.Size = new System.Drawing.Size(204, 28);
            this.שאילתות.Text = "שאילתות";
            this.שאילתות.Click += new System.EventHandler(this.שאילתות_Click);
            // 
            // טופסכונן
            // 
            this.טופסכונן.Name = "טופסכונן";
            this.טופסכונן.Size = new System.Drawing.Size(204, 28);
            this.טופסכונן.Text = "טופס כונן";
            this.טופסכונן.Click += new System.EventHandler(this.טופסכונן_Click);
            // 
            // אירועים
            // 
            this.אירועים.Name = "אירועים";
            this.אירועים.Size = new System.Drawing.Size(204, 28);
            this.אירועים.Text = "אירועים";
            this.אירועים.Click += new System.EventHandler(this.אירועים_Click);
            // 
            // אלגוריתםחכם
            // 
            this.אלגוריתםחכם.Name = "אלגוריתםחכם";
            this.אלגוריתםחכם.Size = new System.Drawing.Size(204, 28);
            this.אלגוריתםחכם.Text = "אלגוריתם חכם";
            this.אלגוריתםחכם.Click += new System.EventHandler(this.אלגוריתםחכם_Click);
            // 
            // גרירות
            // 
            this.גרירות.Name = "גרירות";
            this.גרירות.Size = new System.Drawing.Size(204, 28);
            this.גרירות.Text = "גרירות";
            this.גרירות.Click += new System.EventHandler(this.גרירות_Click);
            // 
            // תקלות
            // 
            this.תקלות.Name = "תקלות";
            this.תקלות.Size = new System.Drawing.Size(204, 28);
            this.תקלות.Text = "תקלות";
            this.תקלות.Click += new System.EventHandler(this.תקלות_Click);
            // 
            // חמל
            // 
            this.חמל.Name = "חמל";
            this.חמל.Size = new System.Drawing.Size(204, 28);
            this.חמל.Text = "חמ\"ל";
            this.חמל.Click += new System.EventHandler(this.חמל_Click);
            // 
            // טפסילקוחותToolStripMenuItem
            // 
            this.טפסילקוחותToolStripMenuItem.Name = "טפסילקוחותToolStripMenuItem";
            this.טפסילקוחותToolStripMenuItem.Size = new System.Drawing.Size(204, 28);
            this.טפסילקוחותToolStripMenuItem.Text = "טפסי לקוחות";
            this.טפסילקוחותToolStripMenuItem.Click += new System.EventHandler(this.טפסילקוחותToolStripMenuItem_Click);
            // 
            // התנתקותToolStripMenuItem
            // 
            this.התנתקותToolStripMenuItem.Name = "התנתקותToolStripMenuItem";
            this.התנתקותToolStripMenuItem.Size = new System.Drawing.Size(98, 28);
            this.התנתקותToolStripMenuItem.Text = "התנתקות";
            this.התנתקותToolStripMenuItem.Click += new System.EventHandler(this.התנתקותToolStripMenuItem_Click);
            // 
            // Volunteers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.BackgroundImage = global::WindowsFormsApp10.Properties.Resources.backgruond1;
            this.ClientSize = new System.Drawing.Size(1015, 694);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.txt_first_phone);
            this.Controls.Add(this.prof);
            this.Controls.Add(this.txtstartdate);
            this.Controls.Add(this.logphone);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.clean);
            this.Controls.Add(this.logid);
            this.Controls.Add(this.update);
            this.Controls.Add(this.txt_code_val);
            this.Controls.Add(this.txtstatus);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtcoordinatex);
            this.Controls.Add(this.log);
            this.Controls.Add(this.back);
            this.Controls.Add(this.btnshowall);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtcoordinatey);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtlastname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtfirstname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_last_phone);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Volunteers";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_last_phone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtfirstname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtlastname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtcoordinatey;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnshowall;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label log;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtcoordinatex;
        private System.Windows.Forms.CheckBox txtstatus;
        private System.Windows.Forms.TextBox txt_code_val;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Label logid;
        private System.Windows.Forms.Button clean;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Label logphone;
        private System.Windows.Forms.MonthCalendar txtstartdate;
        private System.Windows.Forms.Button prof;
        private System.Windows.Forms.ComboBox txt_first_phone;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem הוספתמשתמש;
        private System.Windows.Forms.ToolStripMenuItem לקוחות;
        private System.Windows.Forms.ToolStripMenuItem שאילתות;
        private System.Windows.Forms.ToolStripMenuItem טופסכונן;
        private System.Windows.Forms.ToolStripMenuItem אירועים;
        private System.Windows.Forms.ToolStripMenuItem אלגוריתםחכם;
        private System.Windows.Forms.ToolStripMenuItem גרירות;
        private System.Windows.Forms.ToolStripMenuItem תקלות;
        private System.Windows.Forms.ToolStripMenuItem חמל;
        private System.Windows.Forms.ToolStripMenuItem טפסילקוחותToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem התנתקותToolStripMenuItem;
    }
}