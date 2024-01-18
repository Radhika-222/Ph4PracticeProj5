using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace Ph4PracticeProject5
{
    public partial class FeedbackForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnSubmit_Click(object sender, EventArgs e)
        {
            string nameValue = TxtName.Text;
            string emailValue = TxtEmail.Text;
            string ratingsValue = TxtRatings.Text;
            string messageValue = TxtMessage.Text;
            Response.Redirect($"Thankyou.aspx?");
        }
    }
}