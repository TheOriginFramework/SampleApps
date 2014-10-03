using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TOF.Web.Configuration;
using TOF.Service.LogServices.Web;
using TOF.Service.Web.HttpDependencyInjection;

[assembly: TOFAppStartup(typeof(TOF.SampleApps.WebForm.Startup))]

namespace TOF.SampleApps.WebForm
{
    public class Startup
    {
        public void Configuration(ITOFAppBuilder app)
        {
            app.UseJsonConfiguration("config.json", "~/AppConfigs/");
            app.UseJsonConfiguration("framework.json", "~/AppConfigs/");

            app.UseDatabaseLog(new LogOptions());
        }
    }
}