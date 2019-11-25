using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace GuldtandMVC_Identity.Models
{
    public class CreateRecepieFromVue
    {

        public string testCreateRecepieFunc(string name, int prepareTime, string[] description, string imgUrl)
        {
            
            string initString = "" +
                                "<html>";
            string endString = "</html>";

            string bodystring = "";

            bodystring += "<p>" +
                          "Name: " + name +
                          "<br/>" +
                          " Forberedelses tid: " + prepareTime +
                          "<br/>" +
                          " Fremgangsmåde: " + "<br/>";

                        for (int i = 0; i < description.Length; i++)
                        {
                            bodystring += 1 + i + ". " + description[i] + "<br/>";
                        }


            bodystring += "<br/>" +
                          "<img src = '" + imgUrl + "' />" +
                "</p>";

            return initString + bodystring + endString; ;
        }

    }
}
