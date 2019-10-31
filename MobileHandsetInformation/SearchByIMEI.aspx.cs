using MobileHandsetInformation.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MobileHandsetInformation
{
    public partial class SearchByIMEI : System.Web.UI.Page
    {
        MobileManager manager = new MobileManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            showMobileGrideView.DataSource = manager.ShowMobileHandsetAutoLoad();
            showMobileGrideView.DataBind();

        }

        protected void searchButton_Click(object sender, EventArgs e)
        {
          
            string imei =imeiTextBox.Text;

            showMobileGrideView.DataSource = manager.ShowMobileHandsetByImei(imei);
            showMobileGrideView.DataBind();
        }
    }
}