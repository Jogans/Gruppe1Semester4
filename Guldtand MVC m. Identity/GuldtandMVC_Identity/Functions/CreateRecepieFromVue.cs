using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace GuldtandMVC_Identity.Models
{
    public class CreateRecepieFromVue
    {

        public string testCreateRecepieFunc(string name, int prepareTime, string description, string ingridients, string imgUrl)
        {

            string initString = "" +
                                "<html>";

            string style = "<head>" +
                           "<style>" +

                           ".img1{" +
                           "display: block;" +
                           "position: absolute;" +
                           "width: 700px;" +
                           "height: 400px;}" +

                           "</style>" +
                           "</head> ";

            string endString = "</html>";

            string bodystring = "";

            bodystring += "<p>" +
                          "Name: " + name +
                          "<br/>" +
                          " Forberedelses tid: " + prepareTime +
                          "<br/>" +
                          " Fremgangsmåde: " + "<br/>";

            string[] descriptionData = description.Split(';', StringSplitOptions.RemoveEmptyEntries);
            int counter = 1;
            foreach (var index in descriptionData)
            {
                if (index != "null")
                {
                    bodystring += counter++ + ". " + index + "<br/>";
                }
            }

            bodystring += " Ingridiens liste: " + "<br/>";

            string[] ingridientData = ingridients.Split(';', StringSplitOptions.RemoveEmptyEntries);
            int counterIngridient = 1;
            foreach (var indexIngridient in ingridientData)
            {
                if (indexIngridient != "null")
                {
                    bodystring += counterIngridient++ + ". Ingridient: " + indexIngridient + "<br/>";
                }
            }

            bodystring += "<br/>" +
                          "<img class='img1' src = '" + imgUrl + "' />" +
                "</p>";

            return initString + style + bodystring + endString; ;
        }

    }
}
