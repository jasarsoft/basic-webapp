using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BasicWebApp
{
    public partial class FirstWebPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string myStr = "Loading...";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = TextBox1.Text + ", welcome to Visual Studio!";
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            Label1.Text = Calendar1.SelectedDate.ToLongDateString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            System.Collections.ArrayList ArrayList1 = new System.Collections.ArrayList();

            int i;
            string arrayValue;

            for (i = 0; i < 5; i++)
            {
                arrayValue = "i = " + i.ToString();
                ArrayList1.Add(arrayValue);
            }

            i = DisplyArray(ArrayList1);
        }

        private int DisplyArray(System.Collections.ArrayList alist)
        {
            int i;
            for (i = 0; i < alist.Count; i++)
            {
                Response.Write("<br />" + alist[i]);
            };
            return i;
        }
    }
}