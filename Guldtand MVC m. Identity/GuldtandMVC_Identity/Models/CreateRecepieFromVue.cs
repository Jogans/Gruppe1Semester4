using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuldtandMVC_Identity.Models
{
    public class CreateRecepieFromVue
    {

        public string testCreateRecepieFunc(string name, int prepareTime, string unit)
        {
            
            string initString = "" +
                                "<html>";
            string endString = "</html>";

            string bodystring = "";

            bodystring += "<p>" + 
                          "Name: " + name +
                          "<br/>" +
                          " Forberedelses tid: " + prepareTime  +
                          "<br/>" +
                          " Unit: " + unit + 
                          "</p>";

            return initString + bodystring + endString; ;
        }

    }
}
