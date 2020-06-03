using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class querybtn : Form
    {
        public querybtn()
        {
            InitializeComponent();
        }

        string con = "Data Source=DESKTOP-CJS9RE8;Initial Catalog=project;Integrated Security=True";


        private void button7_Click(object sender, EventArgs e)
        {
            string a,query;
            using (SqlConnection connection = new SqlConnection(con))
            {
                SqlCommand command = new SqlCommand(querytxt.query1 , connection);
                connection.Open();
                SqlDataAdapter datadp = new SqlDataAdapter(command);
                DataTable dt = new DataTable("שאילתות");
                datadp.Fill(dt);
                a = dt.Rows[0]["code_Volunteers"].ToString();
                query = "select * from Volunteers where code_Volunteers = " + a; 

            }
                new query(query).Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
                new query(querytxt.query2).Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            new query(querytxt.query3).Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new query(querytxt.query4).Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new query(querytxt.query5).Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new query(querytxt.query6).Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new query(querytxt.query7).Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            new query(querytxt.query8).Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            new query(querytxt.query9).Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            new query(querytxt.query10).Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            new query(querytxt.query11).Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new query(querytxt.query12).Show();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void טופסלקוחToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new cost_form().Show();
        }

        private void הוספתמשתמש_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new add_user().Show();
        }

        private void לקוחות_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new costumer().Show();
        }

        private void שאילתות_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new querybtn().Show();
        }

        private void טופסכונן_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new val_form().Show();
        }

        private void אירועים_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new events().Show();

        }

        private void אלגוריתםחכם_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new smart_algo().Show();

        }

        private void טופסלקוח_CLICK(object sender, EventArgs e)
        {
            this.Visible = false;
            new drags().Show();

        }

        private void כוננים_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new Volunteers().Show();

        }

        private void תקלות_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new errors().Show(); 

        }

        private void חמל_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new op_room().Show();

        }

        private void התנתקותToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name != "opening_screen")
                {
                    Application.OpenForms[i].Close();
                }
            }
            Application.Restart();
        }

        private void גרירות_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new drags().Show();
        }

        private void טפסילקוחותToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new cost_form().Show();
        }
    }
}
