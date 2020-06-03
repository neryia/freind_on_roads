using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void val_form_Click(object sender, EventArgs e)
        {
            new val_form().Show();
        }

        private void valunteers_click(object sender, EventArgs e)
        {
            new Volunteers().Show();
        }

        private void drags_Click(object sender, EventArgs e)
        {
            new drags().Show();
        }

        private void costumer_form_Click(object sender, EventArgs e)
        {
            new cost_form().Show();
        }

        private void events_Click(object sender, EventArgs e)
        {
            new events().Show();
        }

        private void costumer_Click(object sender, EventArgs e)
        {
            new costumer().Show();
        }

        private void Query_Click(object sender, EventArgs e)
        {
            new querybtn().Show();
        }

        private void smart_al_Click(object sender, EventArgs e)
        {
            new smart_algo().Show();
        }

        private void hamal_Click(object sender, EventArgs e)
        {
            new op_room().Show();
        }

        private void errors_Click(object sender, EventArgs e)
        {
            new errors().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new add_user().Show();
        }
    }
}
