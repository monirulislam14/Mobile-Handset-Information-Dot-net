using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MobileHandsetInformation.Models
{
    public class MobileHandset
    {
        public int MobileId { get; set; }
        public string MobileModelName { get; set; }
        public string MobileIMEI { get; set; }
        public int MobilePrice { get; set; }
       
        public MobileHandset(string mobileModelName,string mobileIMEI,int mobilePrice)
        {
            MobileModelName = mobileModelName;

            MobileIMEI = mobileIMEI;
            MobilePrice = mobilePrice;

        }

        public MobileHandset(string mobileImei)
        {
            MobileIMEI = mobileImei;
        }
    }
}