using MobileHandsetInformation.DAL;
using MobileHandsetInformation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MobileHandsetInformation.BLL
{
   
    public class MobileManager
    {
        MobileHandsetGateway gateway = new MobileHandsetGateway();
        public string GetMobileInfo(MobileHandset mobile)
        {
            bool isExist = gateway.GetExistMobileHandset(mobile);
           
            if (isExist)
            {
                return "This IMEI Already Exist Try Another";
            }
            else
            {  
                
                bool isSave = gateway.SaveMobileInfo(mobile);
                if (isSave)
                {
                    return "Save Succesfully";
                }
                return "Not Save";
              
            }
        }

        public List<MobileHandset> ShowMobileHandsetByPrice(int price1,int price2)
        {
            return gateway.GetAllMobileByPrice(price1,price2);
        }

        internal string IsUniqeMobileHandset(string imei)
        {
            if (imei.Length != 15)
            {
                return "Must Be 15 Character";
            }
            else
            {
                return "unique";
            }
        }

        public List<MobileHandset> ShowMobileHandsetByImei(string imei)
        {
            return gateway.GetAllMobileByImei(imei);
        }
        public List<MobileHandset> ShowMobileHandsetAutoLoad()
        {
            return gateway.GetAllMobileAutoLoad();
        }
       
    }
}