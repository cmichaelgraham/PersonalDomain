using System.Web.Optimization;

namespace PersonalDomain.UI.Web
{
    public static class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            var cssBundle = new StyleBundle("~/Content/css")
                                    .Include("~/Content/css/bootstrap/bootstrap.css")
                                    .Include("~/Content/css/font-awesome/font-awesome.css")
                                    .Include("~/Content/css/toastr/toastr.css")
                                    .Include("~/Content/css/site.css");

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

            var lodashBundle = new ScriptBundle("~/Scripts/lodash")
                                    .Include("~/Scripts/lodash/lodash-{version}.js");

            var markedBundle = new ScriptBundle("~/Scripts/marked")
                                    .Include("~/Scripts/marked/marked.js");

            var modernierBundle = new ScriptBundle("~/Scripts/modernizer")   
                                    .Include("~/Scripts/modernizer/modernizr-{version}.js");

            var toastrBundle = new ScriptBundle("~/Scripts/toastr")
                                      .Include("~/Scripts/toastr/toastr.js");
            bundles.Add(cssBundle);
            bundles.Add(angularBundle);
            bundles.Add(bootstrapBundle);
            bundles.Add(jqueryBundle);
            bundles.Add(lodashBundle);
            bundles.Add(markedBundle);
            bundles.Add(modernierBundle);
            bundles.Add(toastrBundle);

            BundleTable.EnableOptimizations = false;
        }
    }
}