using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace apteka
{
    public partial class Summary : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["totalCost"]!=null)
            totalTextBox.Text = Session["totalCost"].ToString();

            if(Session["shipType"]!=null)
            shipTextBox.Text = Session["shipType"].ToString();

            //czytam z sesji
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Server.Transfer("Default.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Session.Abandon(); //czyszcze sesje
            Server.Transfer("Default.aspx");
        }
    }
}