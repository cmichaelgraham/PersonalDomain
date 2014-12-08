using System.Web.Optimization;

namespace PersonalDomain.UI.Web
{
    public static class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            var cssBundle = new StyleBundle("~/Content/css")
                                .Include("~/Content/css/bootstrap/bootstrap.css")
                                .Include("~/Content/css/site.css");

            var appBundle = new ScriptBundle("~/Scripts/app")
                                .Include("~/app/app.js");

            var angularBundle = new ScriptBundle("~/Scripts/angular")
                                .Include("~/Scripts/angular/angular.js")
                                .Include("~/Scripts/angular/angular-animate.js")
                                .Include("~/Scripts/angular/angular-cookies.js")
                                .Include("~/Scripts/angular/angular-route.js")
                                .Include("~/Scripts/angular/angular-sanitize.js")
                                .Include("~/Scripts/angular/angular-resource.js");

            var bootstrapBundle = new ScriptBundle("~/Scripts/bootstrap")   
                                      .Include("~/Scripts/bootstrap/bootstrap.js")
                                      .Include("~/Scripts/respond/respond.js");

            var jqueryBundle = new ScriptBundle("~/Scripts/jquery")   
                                   .Include("~/Scripts/jquery/jquery-{version}.js");

            var modernierBundle = new ScriptBundle("~/Scripts/modernizer")   
                                      .Include("~/Scripts/modernizer/modernizr-{version}.js");

            bundles.Add(cssBundle);
            bundles.Add(appBundle);
            bundles.Add(angularBundle);
            bundles.Add(bootstrapBundle);
            bundles.Add(jqueryBundle);
            bundles.Add(modernierBundle);

            BundleTable.EnableOptimizations = false;
        }
    }
}