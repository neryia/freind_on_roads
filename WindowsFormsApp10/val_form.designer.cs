namespace WindowsFormsApp10
{
    partial class val_form
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
            this.log = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.btnshowall = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.light_show = new System.Windows.Forms.PictureBox();
            this.txt_real = new System.Windows.Forms.ComboBox();
            this.txt_damage_visible = new System.Windows.Forms.CheckedListBox();
            this.txt_starter = new System.Windows.Forms.CheckBox();
            this.txt_val_code = new System.Windows.Forms.ComboBox();
            this.txt_sound = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_form_code = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_light = new System.Windows.Forms.CheckedListBox();
            this.btn_find = new System.Windows.Forms.Button();
            this.txt_find_form = new System.Windows.Forms.TextBox();
            this.txt_find_how = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.הוספתמשתמש = new System.Windows.Forms.ToolStripMenuItem();
            this.לקוחות = new System.Windows.Forms.ToolStripMenuItem();
            this.שאילתות = new System.Windows.Forms.ToolStripMenuItem();
            this.אירועים = new System.Windows.Forms.ToolStripMenuItem();
            this.אלגוריתםחכם = new System.Windows.Forms.ToolStripMenuItem();
            this.גרירות = new System.Windows.Forms.ToolStripMenuItem();
            this.כוננים = new System.Windows.Forms.ToolStripMenuItem();
            this.תקלות = new System.Windows.Forms.ToolStripMenuItem();
            this.חמל = new System.Windows.Forms.ToolStripMenuItem();
            this.טפסילקוחותToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.התנתקותToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.light_show)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.delete.ForeColor = System.Drawing.Color.White;
            this.delete.Location = new System.Drawing.Point(821, 536);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(110, 48);
            this.delete.TabIndex = 111;
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
            this.clean.Location = new System.Drawing.Point(943, 489);
            this.clean.Name = "clean";
            this.clean.Size = new System.Drawing.Size(75, 41);
            this.clean.TabIndex = 110;
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
            this.update.Location = new System.Drawing.Point(821, 489);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(110, 41);
            this.update.TabIndex = 109;
            this.update.Text = "עדכון";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // log
            // 
            this.log.AutoSize = true;
            this.log.BackColor = System.Drawing.Color.Transparent;
            this.log.Font = new System.Drawing.Font("Calibri", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.log.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.log.Location = new System.Drawing.Point(10, 549);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(60, 29);
            this.log.TabIndex = 107;
            this.log.Text = "LOG:";
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.back.ForeColor = System.Drawing.Color.White;
            this.back.Location = new System.Drawing.Point(943, 536);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 48);
            this.back.TabIndex = 106;
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
            this.btnshowall.Location = new System.Drawing.Point(726, 536);
            this.btnshowall.Name = "btnshowall";
            this.btnshowall.Size = new System.Drawing.Size(87, 48);
            this.btnshowall.TabIndex = 105;
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
            this.btnsave.Location = new System.Drawing.Point(726, 489);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(87, 41);
            this.btnsave.TabIndex = 104;
            this.btnsave.Text = "שמור";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.label1.Location = new System.Drawing.Point(829, 91);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(173, 36);
            this.label1.TabIndex = 93;
            this.label1.Text = "טפסי מתנדבים";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(92)))), ((int)(((byte)(136)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(674, 421);
            this.dataGridView1.TabIndex = 91;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.click_event);
            // 
            // light_show
            // 
            this.light_show.BackColor = System.Drawing.Color.Transparent;
            this.light_show.Location = new System.Drawing.Point(780, 402);
            this.light_show.Name = "light_show";
            this.light_show.Size = new System.Drawing.Size(100, 50);
            this.light_show.TabIndex = 163;
            this.light_show.TabStop = false;
            // 
            // txt_real
            // 
            this.txt_real.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(92)))), ((int)(((byte)(136)))));
            this.txt_real.ForeColor = System.Drawing.Color.White;
            this.txt_real.FormattingEnabled = true;
            this.txt_real.Location = new System.Drawing.Point(743, 277);
            this.txt_real.Name = "txt_real";
            this.txt_real.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_real.Size = new System.Drawing.Size(162, 21);
            this.txt_real.TabIndex = 162;
            // 
            // txt_damage_visible
            // 
            this.txt_damage_visible.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(92)))), ((int)(((byte)(136)))));
            this.txt_damage_visible.ForeColor = System.Drawing.Color.White;
            this.txt_damage_visible.FormattingEnabled = true;
            this.txt_damage_visible.Items.AddRange(new object[] {
            "עשן",
            "עף גלגל",
            "פנצ\'ר"});
            this.txt_damage_visible.Location = new System.Drawing.Point(743, 188);
            this.txt_damage_visible.Name = "txt_damage_visible";
            this.txt_damage_visible.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_damage_visible.Size = new System.Drawing.Size(162, 34);
            this.txt_damage_visible.TabIndex = 161;
            // 
            // txt_starter
            // 
            this.txt_starter.AutoSize = true;
            this.txt_starter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(92)))), ((int)(((byte)(136)))));
            this.txt_starter.ForeColor = System.Drawing.Color.White;
            this.txt_starter.Location = new System.Drawing.Point(811, 138);
            this.txt_starter.Name = "txt_starter";
            this.txt_starter.Size = new System.Drawing.Size(15, 14);
            this.txt_starter.TabIndex = 160;
            this.txt_starter.UseVisualStyleBackColor = false;
            // 
            // txt_val_code
            // 
            this.txt_val_code.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(92)))), ((int)(((byte)(136)))));
            this.txt_val_code.ForeColor = System.Drawing.Color.White;
            this.txt_val_code.FormattingEnabled = true;
            this.txt_val_code.Location = new System.Drawing.Point(743, 314);
            this.txt_val_code.Name = "txt_val_code";
            this.txt_val_code.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_val_code.Size = new System.Drawing.Size(162, 21);
            this.txt_val_code.TabIndex = 159;
            // 
            // txt_sound
            // 
            this.txt_sound.AutoSize = true;
            this.txt_sound.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(92)))), ((int)(((byte)(136)))));
            this.txt_sound.ForeColor = System.Drawing.Color.White;
            this.txt_sound.Location = new System.Drawing.Point(811, 158);
            this.txt_sound.Name = "txt_sound";
            this.txt_sound.Size = new System.Drawing.Size(15, 14);
            this.txt_sound.TabIndex = 157;
            this.txt_sound.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Calibri", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(977, 317);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 14);
            this.label8.TabIndex = 156;
            this.label8.Text = "קוד כונן";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Calibri", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(955, 280);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(66, 14);
            this.label7.TabIndex = 155;
            this.label7.Text = "סיבת התקלה";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(972, 244);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(49, 14);
            this.label6.TabIndex = 154;
            this.label6.Text = "קוד טופס";
            // 
            // txt_form_code
            // 
            this.txt_form_code.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(92)))), ((int)(((byte)(136)))));
            this.txt_form_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txt_form_code.ForeColor = System.Drawing.Color.White;
            this.txt_form_code.Location = new System.Drawing.Point(743, 240);
            this.txt_form_code.Name = "txt_form_code";
            this.txt_form_code.Size = new System.Drawing.Size(162, 20);
            this.txt_form_code.TabIndex = 153;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(983, 158);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(38, 14);
            this.label5.TabIndex = 152;
            this.label5.Text = "קולות?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(974, 198);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(47, 14);
            this.label4.TabIndex = 151;
            this.label4.Text = "נזק גלוי?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(920, 360);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(101, 14);
            this.label3.TabIndex = 150;
            this.label3.Text = "נורות אזהרה דולקות?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(981, 138);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(40, 14);
            this.label2.TabIndex = 149;
            this.label2.Text = "מתניע?";
            // 
            // txt_light
            // 
            this.txt_light.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(92)))), ((int)(((byte)(136)))));
            this.txt_light.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_light.ForeColor = System.Drawing.Color.White;
            this.txt_light.FormattingEnabled = true;
            this.txt_light.Location = new System.Drawing.Point(743, 341);
            this.txt_light.Name = "txt_light";
            this.txt_light.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_light.Size = new System.Drawing.Size(162, 49);
            this.txt_light.TabIndex = 164;
            this.txt_light.SelectedIndexChanged += new System.EventHandler(this.txt_light_SelectedIndexChanged);
            // 
            // btn_find
            // 
            this.btn_find.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.btn_find.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_find.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_find.ForeColor = System.Drawing.Color.White;
            this.btn_find.Location = new System.Drawing.Point(572, 533);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(132, 48);
            this.btn_find.TabIndex = 165;
            this.btn_find.Text = "חפש לפי";
            this.btn_find.UseVisualStyleBackColor = false;
            this.btn_find.Click += new System.EventHandler(this.btn_find_Click);
            // 
            // txt_find_form
            // 
            this.txt_find_form.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(92)))), ((int)(((byte)(136)))));
            this.txt_find_form.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txt_find_form.ForeColor = System.Drawing.Color.White;
            this.txt_find_form.Location = new System.Drawing.Point(296, 549);
            this.txt_find_form.Name = "txt_find_form";
            this.txt_find_form.Size = new System.Drawing.Size(162, 20);
            this.txt_find_form.TabIndex = 166;
            this.txt_find_form.Visible = false;
            this.txt_find_form.TextChanged += new System.EventHandler(this.txt_find_form_TextChanged);
            // 
            // txt_find_how
            // 
            this.txt_find_how.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(92)))), ((int)(((byte)(136)))));
            this.txt_find_how.Enabled = false;
            this.txt_find_how.ForeColor = System.Drawing.Color.White;
            this.txt_find_how.FormattingEnabled = true;
            this.txt_find_how.Location = new System.Drawing.Point(464, 549);
            this.txt_find_how.Name = "txt_find_how";
            this.txt_find_how.Size = new System.Drawing.Size(86, 21);
            this.txt_find_how.TabIndex = 167;
            this.txt_find_how.Visible = false;
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
            this.menuStrip1.Size = new System.Drawing.Size(1035, 32);
            this.menuStrip1.TabIndex = 171;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.הוספתמשתמש,
            this.לקוחות,
            this.שאילתות,
            this.אירועים,
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
            // val_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp10.Properties.Resources.backgruond1;
            this.ClientSize = new System.Drawing.Size(1035, 598);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.txt_find_how);
            this.Controls.Add(this.txt_find_form);
            this.Controls.Add(this.btn_find);
            this.Controls.Add(this.txt_light);
            this.Controls.Add(this.light_show);
            this.Controls.Add(this.txt_real);
            this.Controls.Add(this.txt_damage_visible);
            this.Controls.Add(this.txt_starter);
            this.Controls.Add(this.txt_val_code);
            this.Controls.Add(this.txt_sound);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_form_code);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.clean);
            this.Controls.Add(this.update);
            this.Controls.Add(this.log);
            this.Controls.Add(this.back);
            this.Controls.Add(this.btnshowall);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "val_form";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.updatefields);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.light_show)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button clean;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Label log;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button btnshowall;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox light_show;
        private System.Windows.Forms.ComboBox txt_real;
        private System.Windows.Forms.CheckedListBox txt_damage_visible;
        private System.Windows.Forms.CheckBox txt_starter;
        private System.Windows.Forms.ComboBox txt_val_code;
        private System.Windows.Forms.CheckBox txt_sound;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_form_code;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox txt_light;
        private System.Windows.Forms.Button btn_find;
        private System.Windows.Forms.TextBox txt_find_form;
        private System.Windows.Forms.ComboBox txt_find_how;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem הוספתמשתמש;
        private System.Windows.Forms.ToolStripMenuItem לקוחות;
        private System.Windows.Forms.ToolStripMenuItem שאילתות;
        private System.Windows.Forms.ToolStripMenuItem אירועים;
        private System.Windows.Forms.ToolStripMenuItem אלגוריתםחכם;
        private System.Windows.Forms.ToolStripMenuItem גרירות;
        private System.Windows.Forms.ToolStripMenuItem כוננים;
        private System.Windows.Forms.ToolStripMenuItem תקלות;
        private System.Windows.Forms.ToolStripMenuItem חמל;
        private System.Windows.Forms.ToolStripMenuItem טפסילקוחותToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem התנתקותToolStripMenuItem;
    }
}