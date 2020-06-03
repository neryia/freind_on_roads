namespace WindowsFormsApp10
{
    partial class op_room
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
            this.log = new System.Windows.Forms.Label();
            this.btn_find = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.הוספתמשתמש = new System.Windows.Forms.ToolStripMenuItem();
            this.לקוחות = new System.Windows.Forms.ToolStripMenuItem();
            this.שאילתות = new System.Windows.Forms.ToolStripMenuItem();
            this.טופסכונן = new System.Windows.Forms.ToolStripMenuItem();
            this.אירועים = new System.Windows.Forms.ToolStripMenuItem();
            this.אלגוריתםחכם = new System.Windows.Forms.ToolStripMenuItem();
            this.גרירות = new System.Windows.Forms.ToolStripMenuItem();
            this.כוננים = new System.Windows.Forms.ToolStripMenuItem();
            this.תקלות = new System.Windows.Forms.ToolStripMenuItem();
            this.טפסילקוחותToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.התנתקותToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // log
            // 
            this.log.AutoSize = true;
            this.log.BackColor = System.Drawing.Color.Transparent;
            this.log.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.log.ForeColor = System.Drawing.Color.White;
            this.log.Location = new System.Drawing.Point(12, 438);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(73, 29);
            this.log.TabIndex = 67;
            this.log.Text = "LOG:";
            // 
            // btn_find
            // 
            this.btn_find.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.btn_find.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_find.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btn_find.ForeColor = System.Drawing.Color.White;
            this.btn_find.Location = new System.Drawing.Point(656, 423);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(183, 41);
            this.btn_find.TabIndex = 65;
            this.btn_find.Text = "ריענון";
            this.btn_find.UseVisualStyleBackColor = false;
            this.btn_find.Click += new System.EventHandler(this.btn_find_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.back.ForeColor = System.Drawing.Color.White;
            this.back.Location = new System.Drawing.Point(845, 423);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(155, 41);
            this.back.TabIndex = 61;
            this.back.Text = "חזור";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(92)))), ((int)(((byte)(136)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(988, 321);
            this.dataGridView1.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.label2.Location = new System.Drawing.Point(925, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 36);
            this.label2.TabIndex = 57;
            this.label2.Text = "חמ\"ל";
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
            this.menuStrip1.Size = new System.Drawing.Size(1012, 32);
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
            this.כוננים,
            this.תקלות,
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
            // op_room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp10.Properties.Resources.backgruond1;
            this.ClientSize = new System.Drawing.Size(1012, 476);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.log);
            this.Controls.Add(this.btn_find);
            this.Controls.Add(this.back);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Name = "op_room";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.op_room_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label log;
        private System.Windows.Forms.Button btn_find;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem הוספתמשתמש;
        private System.Windows.Forms.ToolStripMenuItem לקוחות;
        private System.Windows.Forms.ToolStripMenuItem שאילתות;
        private System.Windows.Forms.ToolStripMenuItem טופסכונן;
        private System.Windows.Forms.ToolStripMenuItem אירועים;
        private System.Windows.Forms.ToolStripMenuItem אלגוריתםחכם;
        private System.Windows.Forms.ToolStripMenuItem גרירות;
        private System.Windows.Forms.ToolStripMenuItem כוננים;
        private System.Windows.Forms.ToolStripMenuItem תקלות;
        private System.Windows.Forms.ToolStripMenuItem טפסילקוחותToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem התנתקותToolStripMenuItem;
    }
}