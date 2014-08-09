using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using SubstractLogic;
using System.Web.UI.WebControls;

namespace Substract
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double x, y;
            Substaction sub = new Substaction();
            x = double.Parse(tb1.Text);
            y = double.Parse(tb2.Text);
            if(x>y)

                result.Text = sub.Substract(x, y).ToString();
            else

                result.Text = sub.Substract(y,x).ToString();


        }


    }
}
