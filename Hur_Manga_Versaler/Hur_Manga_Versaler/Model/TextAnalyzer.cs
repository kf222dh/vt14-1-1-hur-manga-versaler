using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace Hur_Manga_Versaler.Model
{
    //Inneh�ller metod f�r att analysera str�ngen som kommer in
    public static class TextAnalyzer
    {
        //Retunerar antal versaler i en str�ng
        public static int numberOfCapitals(string text)
        {
            Regex rgx = new Regex(@"[^A-Z���]");//Inga stora bokst�ver med svenska tecken ocks�
            string capInText = rgx.Replace(text, "");//Tar bort alla andra tecken
            return capInText.Length;//R�knar ut det som �r kvar, allts� bara stora bokst�ver
        }
    }
}