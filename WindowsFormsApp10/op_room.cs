using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class op_room : Form
    {
        public op_room()
        {
            InitializeComponent();
        }

        string con = "Data Source=DESKTOP-CJS9RE8;Initial Catalog=project;Integrated Security=True";
        string format = "yyyy-MM-dd";
        private void op_room_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(con))
            {
                try
                { 
                    string query2 = "select events_.coordiant_x,events_.coordiant_y,events_.date, events_.event_code, val_form.Num_of_val_form, Volunteers.first_name,Volunteers.last_name,Volunteers.phone, costumer_form.Num_of_costumer_form, costumer.first_name,costumer.last_name,costumer.phone, costumer.type_car from events_ inner join val_form on events_.Num_of_val_form = val_form.Num_of_val_form inner join Volunteers on val_form.code_Volunteers = Volunteers.code_Volunteers inner join costumer_form on events_.Num_of_costumer_form = costumer_form.Num_of_costumer_form inner join costumer on costumer_form.code_costumer = costumer.code_costumer  where events_.status_ = 0 and events_.date = '" + DateTime.Today.ToString(format) + "' ";
                    SqlCommand command1 = new SqlCommand(query2, connection);
                    SqlDataAdapter datadp1 = new SqlDataAdapter(command1);
                    DataTable dt1 = new DataTable("כוננים");
                    datadp1.Fill(dt1);
                    dataGridView1.DataSource = dt1.DefaultView;
                }
                catch (Exception ee) { }
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            restart();

        }

        public void restart() // ריענון הדף 
        {
            using (SqlConnection connection = new SqlConnection(con))
            {
                try
                {
                    string query2 = "select events_.coordiant_x,events_.coordiant_y,events_.date, events_.event_code, val_form.Num_of_val_form, Volunteers.first_name,Volunteers.last_name,Volunteers.phone, costumer_form.Num_of_costumer_form, costumer.first_name,costumer.last_name,costumer.phone, costumer.type_car from events_ inner join val_form on events_.Num_of_val_form = val_form.Num_of_val_form inner join Volunteers on val_form.code_Volunteers = Volunteers.code_Volunteers inner join costumer_form on events_.Num_of_costumer_form = costumer_form.Num_of_costumer_form inner join costumer on costumer_form.code_costumer = costumer.code_costumer  where events_.status_ = 0 and events_.date = '" + DateTime.Today.ToString(format) + "' ";
                    SqlCommand command1 = new SqlCommand(query2, connection);
                    SqlDataAdapter datadp1 = new SqlDataAdapter(command1);
                    DataTable dt1 = new DataTable("כוננים");
                    datadp1.Fill(dt1);
                    dataGridView1.DataSource = dt1.DefaultView;
                }
                catch (Exception ee) { }
            }

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
