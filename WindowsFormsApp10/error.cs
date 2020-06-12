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
    class error
    {
        private int[] num_errors;
        
        public error(int errorsb)
        {
            num_errors = new int[errorsb];
                for (int g = 0; g < num_errors.Length; g++)
                {
                    num_errors[g] = 0;
                }            
        }

        public void setNUMError_()
        {
            for (int i = 0; i < this.num_errors.Length; i++)
            {
                this.num_errors[i] = 0;
            }
        }
        public void setNUMError_plus(int a)
        {
            this.num_errors[a]++;
        }
        public int GET_NUM_OF_ERRORS(int a)
        {
            return num_errors[a];
        }
        public int[] GET_num_errors()
        {
            return num_errors;
        }
    }
}
