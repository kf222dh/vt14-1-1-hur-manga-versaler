using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Hur_Manga_Versaler
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        //Kod som körs när en användare klickar på kanppen
        protected void sendButton_Click(object sender, EventArgs e)
        {
            //Kollar statusen på sidan
            if (textBox.Enabled)
            {
                int numberOfCapitals = Model.TextAnalyzer.numberOfCapitals(textBox.Text);
                textBox.Enabled = false;
                sendButton.Text = "Återställ";
                resultLabel.Text = String.Format("Texten har {0} versaler.", numberOfCapitals);
                resultLabel.Visible = true;
            }
            else
            {
                textBox.Text = "";
                textBox.Enabled = true;
                sendButton.Text = "Räkna ut antalet versaler";
                resultLabel.Text = "";
                resultLabel.Visible = false;
            }
        }
    }
}