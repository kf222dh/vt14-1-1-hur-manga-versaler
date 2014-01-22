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
                int numberOfCapitals = Model.TextAnalyzer.numberOfCapitals(textBox.Text);//Koden som kollar hur många versaler körs
                textBox.Enabled = false;//Gör så att man inte kan ändra i boxen
                sendButton.Text = "Återställ";//sendButton ändras då den default är något annat
                resultLabel.Text = String.Format("Texten har {0} versaler.", numberOfCapitals);//Text som skriver ut hur många versaler det är
                resultLabel.Visible = true;//Gör den synbar
            }
            else
            {
                textBox.Text = "";//Tom box
                textBox.Enabled = true;//Enablar den igen ifall koden ovan har körts
                sendButton.Text = "Räkna ut antalet versaler";
                resultLabel.Text = "";
                resultLabel.Visible = false;
            }
        }
    }
}