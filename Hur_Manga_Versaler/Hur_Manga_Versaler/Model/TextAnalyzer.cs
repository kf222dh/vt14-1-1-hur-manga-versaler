using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace Hur_Manga_Versaler.Model
{
    //Innehåller metod för att analysera strängen som kommer in
    public static class TextAnalyzer
    {
        //Retunerar antal versaler i en sträng
        public static int numberOfCapitals(string text)
        {
            Regex rgx = new Regex(@"[^A-ZÅÄÖ]");
            string capInText = rgx.Replace(text, "");

            return capInText.Length;
        }
    }
}