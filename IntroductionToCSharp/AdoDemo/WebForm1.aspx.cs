using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AdoDemo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Customer C1 = new Customer();
            C1.FirstName = "Rizwan";
            C1.LastName = "Khan";
            string FullName1 = C1.GetFullName();
            Response.Write("Full Name = " + FullName1 + "<br/>");

            PartialCustomer C2 = new PartialCustomer();
            C2.FirstName = "Faizan";
            C2.LastName = "Khan";
            string FullName2 = C2.GetFullName();
            Response.Write("Full Name2 = " + FullName2 + "<br/>");
        }
    }
}