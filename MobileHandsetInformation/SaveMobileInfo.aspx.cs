using MobileHandsetInformation.BLL;
using MobileHandsetInformation.DAL;
using MobileHandsetInformation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MobileHandsetInformation
{
    public partial class SaveMobileInfo : System.Web.UI.Page
    {
        MobileManager manager = new MobileManager();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            string modelName = modelNameTextBox.Text;
            string imei = imeiTextBox.Text;
            int price = Convert.ToInt32(priceTextBox.Text);
           
            if ("unique" == manager.IsUniqeMobileHandset(imei)){
                MobileHandset mobileHandset = new MobileHandset(modelName, imei, price);
                messageLabel.Text = manager.GetMobileInfo(mobileHandset);

            }
            else
            {
                messageLabel.Text = manager.IsUniqeMobileHandset(imei);
            }
            ClearField();
        }

        public void ClearField()
        {
            modelNameTextBox.Text = String.Empty;
            imeiTextBox.Text = String.Empty;
            priceTextBox.Text= String.Empty;
        }
    }
}