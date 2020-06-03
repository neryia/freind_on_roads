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
    static class querytxt
    {
        public static string query1 = "select code_Volunteers,COUNT(code_Volunteers) as num from val_form group by code_Volunteers order by num DESC"; // הכוננים הכי פעילים

        public static string query2 = "select error_code, COUNT(error_code) as num from val_form group by error_code order by num desc"; // התקלות הנפוצות

        public static string query3 = "select code_costumer,COUNT(code_costumer) as num from costumer_form group by code_costumer order by num desc"; // הלקוחות שקראו הכי הרבה פעמים

        public static string query4 = "select * from events_ where date > CURRENT_TIMESTAMP - 30" ;// אירועי החודש

        public static string query5 = "SELECT *FROM events_ INNER JOIN drag ON drag.event_code = events_.event_code where date > CURRENT_TIMESTAMP - 30"; // גרירות החודש האחרון

        public static string query6 = "select sum(profit) as profit from drag INNER JOIN events_ ON drag.event_code = events_.event_code where date > CURRENT_TIMESTAMP - 365"; // הרווח מגרירות בשנה האחרונה

        public static string query7 = "select COUNT(*) from error_Prediction inner join events_ on error_Prediction.Num_of_costumer_form = events_.Num_of_costumer_form inner join val_form on events_.Num_of_val_form = val_form.Num_of_val_form where error_Prediction.error_code = val_form.error_code"; // כמה פעמים האלגוריתם החכם פעל טוב

        public static string query8 = "select COUNT(*) from error_Prediction inner join events_ on error_Prediction.Num_of_costumer_form = events_.Num_of_costumer_form inner join val_form on events_.Num_of_val_form = val_form.Num_of_val_form where error_Prediction.error_code != val_form.error_code"; //כמה פעמים האלגוריתם החכם לא פעל טוב

        public static string query9 = "select * from Volunteers where status_availability = 1"; // הכוננים הזמינים

        public static string query10 = "SELECT COUNT(CASE WHEN val_form.code_Volunteers > 5 THEN 1 ELSE NULL END) as c ,first_name, last_name, Volunteers.code_Volunteers, coordiant_x, coordiant_y, status_availability FROM Volunteers INNER JOIN val_form ON Volunteers.code_Volunteers = val_form.code_Volunteers group by first_name, last_name, Volunteers.code_Volunteers, coordiant_x, coordiant_y, status_availability"; // איזה כוננים עשו יותר מחמש קריאות

        public static string query11 = "select COUNT(costumer_form.Num_of_costumer_form) as times, type_car from costumer_form inner join costumer on costumer.code_costumer = costumer_form.code_costumer group by(type_car) order by(times) desc"; // הרכבים התקולים ביותר

        public static string query12 = "select COUNT(company) as times, company from drag group by company order by times"; // החברה שעשתה הכי הרבה גרירות
    }

}
