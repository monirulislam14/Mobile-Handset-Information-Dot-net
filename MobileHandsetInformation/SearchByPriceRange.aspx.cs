using MobileHandsetInformation.BLL;
using MobileHandsetInformation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MobileHandsetInformation
{
    public partial class SearchByPriceRange : System.Web.UI.Page
    {
        MobileManager manager = new MobileManager();
       
        protected void Page_Load(object sender, EventArgs e)
        {
            showMobileGrideView.DataSource = manager.ShowMobileHandsetAutoLoad();
            showMobileGrideView.DataBind();


        }

        protected void searchButton_Click(object sender, EventArgs e)
        {
            int price1 = Convert.ToInt32(TextBox1.Text);
            int price2 = Convert.ToInt32(TextBox2.Text);

            showMobileGrideView.DataSource= manager.ShowMobileHandsetByPrice(price1,price2);
            showMobileGrideView.DataBind();
        }
    }
}