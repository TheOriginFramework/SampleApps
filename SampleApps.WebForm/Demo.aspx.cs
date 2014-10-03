using TOF.Framework.Configuration;
using TOF.Service.LogServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TOF.SampleApps.WebForm
{
    public partial class Demo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var configReader = ConfigurationProvider.GetReader("config.json");
            Response.Write(configReader.GetConnectionStringFromName("app"));
            Response.Write("<br />");
            Response.Write(configReader.GetConnectionStringFromName("log"));

            Log.WriteInfo("Test");
        }
    }
}