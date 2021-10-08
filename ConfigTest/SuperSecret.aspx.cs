using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ConfigTest
{
    public partial class SuperSecret : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BindData();
        }

        private void BindData()
        {
            string secret = ConfigurationManager.AppSettings["SuperSecret"];
            this.lblSecret.Text = secret;

            // get the config section
            var dbSettings = (NameValueCollection)ConfigurationManager.GetSection("DBSettings");

            string db_secret = dbSettings["DBS_Secret"];
            this.lblDBSecret.Text = db_secret;
        }
    }

}