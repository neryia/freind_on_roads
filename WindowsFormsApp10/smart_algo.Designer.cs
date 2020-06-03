namespace WindowsFormsApp10
{
    partial class smart_algo
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
            this.btn_expected = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_code_conan = new System.Windows.Forms.Label();
            this.txt_expected = new System.Windows.Forms.Label();
            this.txt_num_form = new System.Windows.Forms.ComboBox();
            this.code_mach = new System.Windows.Forms.TextBox();
            this.expected = new System.Windows.Forms.TextBox();
            this.last = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.clean = new System.Windows.Forms.Button();
            this.btn_show_all = new System.Windows.Forms.Button();
            this.log = new System.Windows.Forms.Label();
            this.btn_find = new System.Windows.Forms.Button();
            this.txt_find_how = new System.Windows.Forms.ComboBox();
            this.txt_find = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.הוספתמשתמש = new System.Windows.Forms.ToolStripMenuItem();
            this.לקוחות = new System.Windows.Forms.ToolStripMenuItem();
            this.שאילתות = new System.Windows.Forms.ToolStripMenuItem();
            this.טופסכונן = new System.Windows.Forms.ToolStripMenuItem();
            this.אירועים = new System.Windows.Forms.ToolStripMenuItem();
            this.גרירות = new System.Windows.Forms.ToolStripMenuItem();
            this.כוננים = new System.Windows.Forms.ToolStripMenuItem();
            this.תקלות = new System.Windows.Forms.ToolStripMenuItem();
            this.חמל = new System.Windows.Forms.ToolStripMenuItem();
            this.טפסילקוחותToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.התנתקותToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.label6 = new System.Windows.Forms.Label();
            this.secondery = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_expected
            // 
            this.btn_expected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.btn_expected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_expected.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_expected.ForeColor = System.Drawing.Color.White;
            this.btn_expected.Location = new System.Drawing.Point(139, 511);
            this.btn_expected.Name = "btn_expected";
            this.btn_expected.Size = new System.Drawing.Size(201, 40);
            this.btn_expected.TabIndex = 0;
            this.btn_expected.Text = "לקבלת התקלה הצפוייה והכונן המתאים לחץ כאן";
            this.btn_expected.UseVisualStyleBackColor = false;
            this.btn_expected.Click += new System.EventHandler(this.btn_expected_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(587, 389);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 14);
            this.label1.TabIndex = 4;
            this.label1.Text = "מספר טופס לקוח";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(295, 433);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "שם הכונן";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(596, 432);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 14);
            this.label3.TabIndex = 6;
            this.label3.Text = "התקלה הצפויה";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(92)))), ((int)(((byte)(136)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 136);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(663, 226);
            this.dataGridView1.TabIndex = 7;
            // 
            // txt_code_conan
            // 
            this.txt_code_conan.AutoSize = true;
            this.txt_code_conan.Location = new System.Drawing.Point(36, 318);
            this.txt_code_conan.Name = "txt_code_conan";
            this.txt_code_conan.Size = new System.Drawing.Size(0, 13);
            this.txt_code_conan.TabIndex = 8;
            // 
            // txt_expected
            // 
            this.txt_expected.AutoSize = true;
            this.txt_expected.ForeColor = System.Drawing.Color.White;
            this.txt_expected.Location = new System.Drawing.Point(243, 390);
            this.txt_expected.Name = "txt_expected";
            this.txt_expected.Size = new System.Drawing.Size(0, 13);
            this.txt_expected.TabIndex = 9;
            // 
            // txt_num_form
            // 
            this.txt_num_form.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(92)))), ((int)(((byte)(136)))));
            this.txt_num_form.ForeColor = System.Drawing.Color.White;
            this.txt_num_form.FormattingEnabled = true;
            this.txt_num_form.Location = new System.Drawing.Point(424, 386);
            this.txt_num_form.Name = "txt_num_form";
            this.txt_num_form.Size = new System.Drawing.Size(121, 21);
            this.txt_num_form.TabIndex = 10;
            this.txt_num_form.SelectedIndexChanged += new System.EventHandler(this.txt_num_form_SelectedIndexChanged);
            // 
            // code_mach
            // 
            this.code_mach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(92)))), ((int)(((byte)(136)))));
            this.code_mach.ForeColor = System.Drawing.Color.White;
            this.code_mach.Location = new System.Drawing.Point(145, 432);
            this.code_mach.Name = "code_mach";
            this.code_mach.ReadOnly = true;
            this.code_mach.Size = new System.Drawing.Size(100, 20);
            this.code_mach.TabIndex = 14;
            // 
            // expected
            // 
            this.expected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(92)))), ((int)(((byte)(136)))));
            this.expected.ForeColor = System.Drawing.Color.White;
            this.expected.Location = new System.Drawing.Point(424, 426);
            this.expected.Name = "expected";
            this.expected.ReadOnly = true;
            this.expected.Size = new System.Drawing.Size(121, 20);
            this.expected.TabIndex = 15;
            // 
            // last
            // 
            this.last.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(92)))), ((int)(((byte)(136)))));
            this.last.ForeColor = System.Drawing.Color.White;
            this.last.Location = new System.Drawing.Point(39, 432);
            this.last.Name = "last";
            this.last.ReadOnly = true;
            this.last.Size = new System.Drawing.Size(100, 20);
            this.last.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.label4.Location = new System.Drawing.Point(502, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 36);
            this.label4.TabIndex = 17;
            this.label4.Text = "אלגוריתם חכם";
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.back.ForeColor = System.Drawing.Color.White;
            this.back.Location = new System.Drawing.Point(559, 511);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(113, 40);
            this.back.TabIndex = 18;
            this.back.Text = "חזור";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // clean
            // 
            this.clean.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.clean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clean.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.clean.ForeColor = System.Drawing.Color.White;
            this.clean.Location = new System.Drawing.Point(11, 511);
            this.clean.Name = "clean";
            this.clean.Size = new System.Drawing.Size(113, 40);
            this.clean.TabIndex = 19;
            this.clean.Text = "ניקוי";
            this.clean.UseVisualStyleBackColor = false;
            this.clean.Click += new System.EventHandler(this.clean_Click);
            // 
            // btn_show_all
            // 
            this.btn_show_all.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.btn_show_all.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_show_all.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_show_all.ForeColor = System.Drawing.Color.White;
            this.btn_show_all.Location = new System.Drawing.Point(349, 511);
            this.btn_show_all.Name = "btn_show_all";
            this.btn_show_all.Size = new System.Drawing.Size(201, 40);
            this.btn_show_all.TabIndex = 20;
            this.btn_show_all.Text = "הצג הכל";
            this.btn_show_all.UseVisualStyleBackColor = false;
            this.btn_show_all.Click += new System.EventHandler(this.btn_show_all_Click);
            // 
            // log
            // 
            this.log.AutoSize = true;
            this.log.BackColor = System.Drawing.Color.Transparent;
            this.log.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.log.Location = new System.Drawing.Point(12, 583);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(29, 13);
            this.log.TabIndex = 21;
            this.log.Text = "LOG";
            // 
            // btn_find
            // 
            this.btn_find.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.btn_find.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_find.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_find.ForeColor = System.Drawing.Color.White;
            this.btn_find.Location = new System.Drawing.Point(559, 555);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(113, 40);
            this.btn_find.TabIndex = 22;
            this.btn_find.Text = "חפש לפי";
            this.btn_find.UseVisualStyleBackColor = false;
            this.btn_find.Click += new System.EventHandler(this.btn_find_Click);
            // 
            // txt_find_how
            // 
            this.txt_find_how.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(92)))), ((int)(((byte)(136)))));
            this.txt_find_how.Enabled = false;
            this.txt_find_how.ForeColor = System.Drawing.Color.White;
            this.txt_find_how.FormattingEnabled = true;
            this.txt_find_how.Items.AddRange(new object[] {
            "קוד טופס לקוח",
            "תקלה צפויה"});
            this.txt_find_how.Location = new System.Drawing.Point(492, 567);
            this.txt_find_how.Name = "txt_find_how";
            this.txt_find_how.Size = new System.Drawing.Size(58, 21);
            this.txt_find_how.TabIndex = 23;
            this.txt_find_how.Visible = false;
            // 
            // txt_find
            // 
            this.txt_find.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(92)))), ((int)(((byte)(136)))));
            this.txt_find.Enabled = false;
            this.txt_find.ForeColor = System.Drawing.Color.White;
            this.txt_find.Location = new System.Drawing.Point(386, 567);
            this.txt_find.Name = "txt_find";
            this.txt_find.Size = new System.Drawing.Size(100, 20);
            this.txt_find.TabIndex = 24;
            this.txt_find.Visible = false;
            this.txt_find.TextChanged += new System.EventHandler(this.txt_find_text_changed);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(418, 385);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 14);
            this.label5.TabIndex = 25;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Font = new System.Drawing.Font("Aharoni", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.התנתקותToolStripMenuItem,
            this.toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(685, 32);
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
            // אירועים
            // 
            this.אירועים.Name = "אירועים";
            this.אירועים.Size = new System.Drawing.Size(204, 28);
            this.אירועים.Text = "אירועים";
            this.אירועים.Click += new System.EventHandler(this.אירועים_Click);
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
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(29, 28);
            this.toolStripMenuItem2.Text = " ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(556, 476);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 14);
            this.label6.TabIndex = 172;
            this.label6.Text = "התקלה המשנית הצפויה";
            // 
            // secondery
            // 
            this.secondery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(92)))), ((int)(((byte)(136)))));
            this.secondery.ForeColor = System.Drawing.Color.White;
            this.secondery.Location = new System.Drawing.Point(424, 470);
            this.secondery.Name = "secondery";
            this.secondery.ReadOnly = true;
            this.secondery.Size = new System.Drawing.Size(121, 20);
            this.secondery.TabIndex = 173;
            // 
            // smart_algo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(92)))), ((int)(((byte)(136)))));
            this.BackgroundImage = global::WindowsFormsApp10.Properties.Resources.backgruond1;
            this.ClientSize = new System.Drawing.Size(685, 605);
            this.Controls.Add(this.secondery);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_find);
            this.Controls.Add(this.txt_find_how);
            this.Controls.Add(this.btn_find);
            this.Controls.Add(this.log);
            this.Controls.Add(this.btn_show_all);
            this.Controls.Add(this.clean);
            this.Controls.Add(this.back);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.last);
            this.Controls.Add(this.expected);
            this.Controls.Add(this.code_mach);
            this.Controls.Add(this.txt_num_form);
            this.Controls.Add(this.txt_expected);
            this.Controls.Add(this.txt_code_conan);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_expected);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "smart_algo";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_expected;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label txt_code_conan;
        private System.Windows.Forms.Label txt_expected;
        private System.Windows.Forms.ComboBox txt_num_form;
        private System.Windows.Forms.TextBox code_mach;
        private System.Windows.Forms.TextBox expected;
        private System.Windows.Forms.TextBox last;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button clean;
        private System.Windows.Forms.Button btn_show_all;
        private System.Windows.Forms.Label log;
        private System.Windows.Forms.Button btn_find;
        private System.Windows.Forms.ComboBox txt_find_how;
        private System.Windows.Forms.TextBox txt_find;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem הוספתמשתמש;
        private System.Windows.Forms.ToolStripMenuItem לקוחות;
        private System.Windows.Forms.ToolStripMenuItem שאילתות;
        private System.Windows.Forms.ToolStripMenuItem טופסכונן;
        private System.Windows.Forms.ToolStripMenuItem אירועים;
        private System.Windows.Forms.ToolStripMenuItem גרירות;
        private System.Windows.Forms.ToolStripMenuItem כוננים;
        private System.Windows.Forms.ToolStripMenuItem תקלות;
        private System.Windows.Forms.ToolStripMenuItem חמל;
        private System.Windows.Forms.ToolStripMenuItem טפסילקוחותToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem התנתקותToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox secondery;
    }
}