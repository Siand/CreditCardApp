using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CreditCardApp.Models
{
    public class Result
    {
        public int Id { get; set; }
        public string imgURL { set; get; }
        public string APR { set; get; }
        public string flavourText { set; get; }
        public string sol { get; set; }
        public Result()
        {

        }
        public Result(Request r)
        {
            DateTime eya = DateTime.Today.AddYears(-18);
            if(eya < r.dob)
            {
                Id = r.Id;
                sol = Constants.none;
                imgURL = "";
                APR = "";
                flavourText = Constants.flavourTextNoCard;
                return;
            }
            if(r.income < 30000)
            {
                sol = Constants.vanq;
                imgURL = Constants.urlVanquis;
                APR = Constants.VanquisAPR;
                flavourText = Constants.flavourTextVanquis;
                return;
            }
            sol = Constants.barc;
            imgURL = Constants.urlBarclays;
            APR = Constants.BarclaysAPR;
            flavourText = Constants.flavourTextBarclays;
        }


    }
}