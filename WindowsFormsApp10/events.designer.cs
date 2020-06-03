namespace WindowsFormsApp10
{
    partial class events
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
            this.delete = new System.Windows.Forms.Button();
            this.clean = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.txtstatus = new System.Windows.Forms.CheckBox();
            this.log = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.btnshowall = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_event_code = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_coordinatex = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_coordinatey = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_cos_form = new System.Windows.Forms.ComboBox();
            this.txt_val_form = new System.Windows.Forms.ComboBox();
            this.txt_date = new System.Windows.Forms.MonthCalendar();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_find_how = new System.Windows.Forms.ComboBox();
            this.txt_find_form = new System.Windows.Forms.TextBox();
            this.btn_find = new System.Windows.Forms.Button();
            this.txt_find_date = new System.Windows.Forms.MonthCalendar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.הוספתמשתמש = new System.Windows.Forms.ToolStripMenuItem();
            this.לקוחות = new System.Windows.Forms.ToolStripMenuItem();
            this.שאילתות = new System.Windows.Forms.ToolStripMenuItem();
            this.טופסכונן = new System.Windows.Forms.ToolStripMenuItem();
            this.אלגוריתםחכם = new System.Windows.Forms.ToolStripMenuItem();
            this.גרירות = new System.Windows.Forms.ToolStripMenuItem();
            this.כוננים = new System.Windows.Forms.ToolStripMenuItem();
            this.תקלות = new System.Windows.Forms.ToolStripMenuItem();
            this.חמל = new System.Windows.Forms.ToolStripMenuItem();
            this.טפסילקוחותToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.התנתקותToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.delete.ForeColor = System.Drawing.Color.White;
            this.delete.Location = new System.Drawing.Point(970, 592);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(110, 48);
            this.delete.TabIndex = 88;
            this.delete.Text = "מחק";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // clean
            // 
            this.clean.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.clean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clean.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.clean.ForeColor = System.Drawing.Color.White;
            this.clean.Location = new System.Drawing.Point(900, 674);
            this.clean.Name = "clean";
            this.clean.Size = new System.Drawing.Size(99, 48);
            this.clean.TabIndex = 87;
            this.clean.Text = "ניקוי";
            this.clean.UseVisualStyleBackColor = false;
            this.clean.Click += new System.EventHandler(this.clean_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.update.ForeColor = System.Drawing.Color.White;
            this.update.Location = new System.Drawing.Point(854, 592);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(110, 48);
            this.update.TabIndex = 85;
            this.update.Text = "עדכון";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // txtstatus
            // 
            this.txtstatus.AutoSize = true;
            this.txtstatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(92)))), ((int)(((byte)(136)))));
            this.txtstatus.ForeColor = System.Drawing.Color.White;
            this.txtstatus.Location = new System.Drawing.Point(854, 293);
            this.txtstatus.Name = "txtstatus";
            this.txtstatus.Size = new System.Drawing.Size(15, 14);
            this.txtstatus.TabIndex = 83;
            this.txtstatus.UseVisualStyleBackColor = false;
            // 
            // log
            // 
            this.log.AutoSize = true;
            this.log.BackColor = System.Drawing.Color.Transparent;
            this.log.Font = new System.Drawing.Font("Calibri", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.log.Location = new System.Drawing.Point(32, 701);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(60, 29);
            this.log.TabIndex = 80;
            this.log.Text = "LOG:";
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.back.ForeColor = System.Drawing.Color.White;
            this.back.Location = new System.Drawing.Point(1005, 674);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 48);
            this.back.TabIndex = 79;
            this.back.Text = "חזור";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // btnshowall
            // 
            this.btnshowall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.btnshowall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnshowall.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnshowall.ForeColor = System.Drawing.Color.White;
            this.btnshowall.Location = new System.Drawing.Point(761, 674);
            this.btnshowall.Name = "btnshowall";
            this.btnshowall.Size = new System.Drawing.Size(133, 48);
            this.btnshowall.TabIndex = 78;
            this.btnshowall.Text = "הצג הכל";
            this.btnshowall.UseVisualStyleBackColor = false;
            this.btnshowall.Click += new System.EventHandler(this.btnshowall_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnsave.ForeColor = System.Drawing.Color.White;
            this.btnsave.Location = new System.Drawing.Point(761, 592);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(87, 48);
            this.btnsave.TabIndex = 77;
            this.btnsave.Text = "שמור";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Calibri", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(963, 500);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 15);
            this.label8.TabIndex = 75;
            this.label8.Text = "מספר טופס כונן";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Calibri", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(956, 463);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 15);
            this.label7.TabIndex = 73;
            this.label7.Text = "מספר טופס לקוח";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(995, 424);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 71;
            this.label6.Text = "קוד אירוע";
            // 
            // txt_event_code
            // 
            this.txt_event_code.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(92)))), ((int)(((byte)(136)))));
            this.txt_event_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txt_event_code.ForeColor = System.Drawing.Color.White;
            this.txt_event_code.Location = new System.Drawing.Point(785, 422);
            this.txt_event_code.Name = "txt_event_code";
            this.txt_event_code.Size = new System.Drawing.Size(162, 20);
            this.txt_event_code.TabIndex = 70;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(1005, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 15);
            this.label5.TabIndex = 69;
            this.label5.Text = "סטטוס";
            // 
            // txt_coordinatex
            // 
            this.txt_coordinatex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(92)))), ((int)(((byte)(136)))));
            this.txt_coordinatex.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txt_coordinatex.ForeColor = System.Drawing.Color.White;
            this.txt_coordinatex.Location = new System.Drawing.Point(785, 384);
            this.txt_coordinatex.Name = "txt_coordinatex";
            this.txt_coordinatex.Size = new System.Drawing.Size(162, 20);
            this.txt_coordinatex.TabIndex = 68;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(998, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 67;
            this.label4.Text = "נ.צ. אורך";
            // 
            // txt_coordinatey
            // 
            this.txt_coordinatey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(92)))), ((int)(((byte)(136)))));
            this.txt_coordinatey.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txt_coordinatey.ForeColor = System.Drawing.Color.White;
            this.txt_coordinatey.Location = new System.Drawing.Point(785, 343);
            this.txt_coordinatey.Name = "txt_coordinatey";
            this.txt_coordinatey.Size = new System.Drawing.Size(162, 20);
            this.txt_coordinatey.TabIndex = 66;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(997, 386);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 65;
            this.label3.Text = "נ.צ. רוחב";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(1010, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 64;
            this.label2.Text = "תאריך";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.label1.Location = new System.Drawing.Point(945, 54);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(98, 36);
            this.label1.TabIndex = 63;
            this.label1.Text = "אירועים";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(92)))), ((int)(((byte)(136)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(65, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(674, 436);
            this.dataGridView1.TabIndex = 61;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.click_event);
            // 
            // txt_cos_form
            // 
            this.txt_cos_form.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(92)))), ((int)(((byte)(136)))));
            this.txt_cos_form.ForeColor = System.Drawing.Color.White;
            this.txt_cos_form.FormattingEnabled = true;
            this.txt_cos_form.Location = new System.Drawing.Point(785, 461);
            this.txt_cos_form.Name = "txt_cos_form";
            this.txt_cos_form.Size = new System.Drawing.Size(162, 21);
            this.txt_cos_form.TabIndex = 89;
            this.txt_cos_form.SelectedIndexChanged += new System.EventHandler(this.check_cost);
            // 
            // txt_val_form
            // 
            this.txt_val_form.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(92)))), ((int)(((byte)(136)))));
            this.txt_val_form.ForeColor = System.Drawing.Color.White;
            this.txt_val_form.FormattingEnabled = true;
            this.txt_val_form.Location = new System.Drawing.Point(785, 498);
            this.txt_val_form.Name = "txt_val_form";
            this.txt_val_form.Size = new System.Drawing.Size(162, 21);
            this.txt_val_form.TabIndex = 90;
            this.txt_val_form.SelectedIndexChanged += new System.EventHandler(this.check_val);
            // 
            // txt_date
            // 
            this.txt_date.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(92)))), ((int)(((byte)(136)))));
            this.txt_date.Location = new System.Drawing.Point(750, 99);
            this.txt_date.Name = "txt_date";
            this.txt_date.TabIndex = 91;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(739, 469);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 92;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(738, 506);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 13);
            this.label10.TabIndex = 93;
            // 
            // txt_find_how
            // 
            this.txt_find_how.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(92)))), ((int)(((byte)(136)))));
            this.txt_find_how.Enabled = false;
            this.txt_find_how.ForeColor = System.Drawing.Color.White;
            this.txt_find_how.FormattingEnabled = true;
            this.txt_find_how.Location = new System.Drawing.Point(455, 626);
            this.txt_find_how.Name = "txt_find_how";
            this.txt_find_how.Size = new System.Drawing.Size(86, 21);
            this.txt_find_how.TabIndex = 170;
            this.txt_find_how.Visible = false;
            this.txt_find_how.SelectedValueChanged += new System.EventHandler(this.txt_find_how_SelectedValueChanged);
            // 
            // txt_find_form
            // 
            this.txt_find_form.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(92)))), ((int)(((byte)(136)))));
            this.txt_find_form.Enabled = false;
            this.txt_find_form.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txt_find_form.ForeColor = System.Drawing.Color.White;
            this.txt_find_form.Location = new System.Drawing.Point(418, 674);
            this.txt_find_form.Name = "txt_find_form";
            this.txt_find_form.Size = new System.Drawing.Size(162, 20);
            this.txt_find_form.TabIndex = 169;
            this.txt_find_form.Visible = false;
            this.txt_find_form.TextChanged += new System.EventHandler(this.txt_find_form_TextChanged);
            // 
            // btn_find
            // 
            this.btn_find.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.btn_find.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_find.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_find.ForeColor = System.Drawing.Color.White;
            this.btn_find.Location = new System.Drawing.Point(607, 626);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(132, 48);
            this.btn_find.TabIndex = 168;
            this.btn_find.Text = "חפש לפי";
            this.btn_find.UseVisualStyleBackColor = false;
            this.btn_find.Click += new System.EventHandler(this.btn_find_Click);
            // 
            // txt_find_date
            // 
            this.txt_find_date.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(92)))), ((int)(((byte)(136)))));
            this.txt_find_date.Enabled = false;
            this.txt_find_date.Location = new System.Drawing.Point(179, 560);
            this.txt_find_date.Name = "txt_find_date";
            this.txt_find_date.TabIndex = 171;
            this.txt_find_date.Visible = false;
            this.txt_find_date.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.txt_find_date_DateChanged);
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
            this.menuStrip1.Size = new System.Drawing.Size(1095, 32);
            this.menuStrip1.TabIndex = 172;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.הוספתמשתמש,
            this.לקוחות,
            this.שאילתות,
            this.טופסכונן,
            this.אלגוריתםחכם,
            this.גרירות,
            this.כוננים,
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
            this.הוספתמשתמש.Click += new System.EventHandler(this.הוספתמשתמש_Click);
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
            // כוננים
            // 
            this.כוננים.Name = "כוננים";
            this.כוננים.Size = new System.Drawing.Size(204, 28);
            this.כוננים.Text = "כוננים";
            this.כוננים.Click += new System.EventHandler(this.כוננים_Click);
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
            // events
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp10.Properties.Resources.backgruond1;
            this.ClientSize = new System.Drawing.Size(1095, 749);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.txt_find_date);
            this.Controls.Add(this.txt_find_how);
            this.Controls.Add(this.txt_find_form);
            this.Controls.Add(this.btn_find);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_date);
            this.Controls.Add(this.txt_val_form);
            this.Controls.Add(this.txt_cos_form);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.clean);
            this.Controls.Add(this.update);
            this.Controls.Add(this.txtstatus);
            this.Controls.Add(this.log);
            this.Controls.Add(this.back);
            this.Controls.Add(this.btnshowall);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_event_code);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_coordinatex);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_coordinatey);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "events";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.updatefields);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button clean;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.CheckBox txtstatus;
        private System.Windows.Forms.Label log;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button btnshowall;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_event_code;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_coordinatex;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_coordinatey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox txt_cos_form;
        private System.Windows.Forms.ComboBox txt_val_form;
        private System.Windows.Forms.MonthCalendar txt_date;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox txt_find_how;
        private System.Windows.Forms.TextBox txt_find_form;
        private System.Windows.Forms.Button btn_find;
        private System.Windows.Forms.MonthCalendar txt_find_date;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem הוספתמשתמש;
        private System.Windows.Forms.ToolStripMenuItem לקוחות;
        private System.Windows.Forms.ToolStripMenuItem שאילתות;
        private System.Windows.Forms.ToolStripMenuItem טופסכונן;
        private System.Windows.Forms.ToolStripMenuItem אלגוריתםחכם;
        private System.Windows.Forms.ToolStripMenuItem גרירות;
        private System.Windows.Forms.ToolStripMenuItem כוננים;
        private System.Windows.Forms.ToolStripMenuItem תקלות;
        private System.Windows.Forms.ToolStripMenuItem חמל;
        private System.Windows.Forms.ToolStripMenuItem טפסילקוחותToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem התנתקותToolStripMenuItem;
    }
}