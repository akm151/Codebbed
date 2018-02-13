using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace Codebbed
{
    public class BundleConfig
    {

        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.UseCdn = true;

            Bundle cssBundle = new StyleBundle("~/bundles/css");
            cssBundle.Include("~/Resources/css/bootstrap.css");
            cssBundle.Include("~/Resources/font-awesome-4.2.0/css/font-awesome.css");
            cssBundle.Include("~/Resources/css/jasny-bootstrap.min.css");
            cssBundle.Include("~/Resources/css/animate.css");
            cssBundle.Include("~/Resources/css/owl.carousel.css");
            cssBundle.Include("~/Resources/css/owl.theme.css");
            cssBundle.Include("~/Resources/css/style.css");
            cssBundle.Include("~/Resources/css/responsive.css");
            cssBundle.Include("~/Resources/css/app.css");
            cssBundle.Include("~/Resources/css/montserrat.css");
            cssBundle.Include("~/Resources/css/font-awesome.min.css");
            

            bundles.Add(cssBundle);

            Bundle jsBundle = new ScriptBundle("~/bundles/js");
            jsBundle.Include("~/Resources/js/modernizr.custom.js");
            jsBundle.Include("~/Resources/js/jquery.min.js");
            jsBundle.Include("~/Resources/js/jquery.1.11.1.js");
            jsBundle.Include("~/Resources/js/bootstrap.js");
            jsBundle.Include("~/Resources/js/bootstrap.min.js");
            jsBundle.Include("~/Resources/js/SmoothScroll.js");
            jsBundle.Include("~/Resources/js/jasny-bootstrap.min.js");
            jsBundle.Include("~/Resources/js/owl.carousel.js");
            jsBundle.Include("~/Resources/js/owl.autoplay.js");
            jsBundle.Include("~/Resources/js/typed.js");
            jsBundle.Include("~/Resources/js/widgets.js");
            jsBundle.Include("~/Resources/js/in.js");
            jsBundle.Include("~/Resources/js/main.js");
            jsBundle.Include("~/Resources/js/app.js");

            bundles.Add(jsBundle);

            //    <!-- jQuery (necessary for Bootstrap's JavaScript plugins) -->
            //<script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.1/jquery.min.js"></script>
            //<script type="text/javascript" src="@Url.Content("~/Resources/js/jquery.1.11.1.js")"></script>
            //<!-- Include all compiled plugins (below), or include individual files as needed -->
            //<script type="text/javascript" src="@Url.Content("~/Resources/js/bootstrap.js")"></script>
            //<script type="text/javascript" src="@Url.Content("~/Resources/js/SmoothScroll.js")"></script>
            //<script type="text/javascript" src="@Url.Content("~/Resources/js/jasny-bootstrap.min.js")"></script>
            //<script src="@Url.Content("~/Resources/js/owl.carousel.js")"></script>
            //<script src="@Url.Content("~/Resources/js/typed.js")"></script>
            //<script async src="https://platform.twitter.com/widgets.js" charset="utf-8"></script>
            //<script src="//platform.linkedin.com/in.js" type="text/javascript"></script>

            //    <script type="text/javascript" src="@Url.Content("~/Resources/js/main.js")"></script>
            //<script type="text/javascript" src="@Url.Content("~/Resources/js/app.js")"></script>


            //         <!-- Bootstrap -->
            //<link rel="stylesheet" type="text/css" href="@Url.Content("~/Resources/css/bootstrap.css")">
            //<link rel="stylesheet" type="text/css" href="@Url.Content("~/Resources/font-awesome-4.2.0/css/font-awesome.css")">
            //<link rel="stylesheet" type="text/css" href="@Url.Content("~/Resources/css/jasny-bootstrap.min.css")">
            //<link rel="stylesheet" type="text/css" href="@Url.Content("~/Resources/css/animate.css")">

            //<!-- Slider
            //================================================== -->
            //<link href="@Url.Content("~/Resources/css/owl.carousel.css")" rel="stylesheet" media="screen">
            //<link href="@Url.Content("~/Resources/css/owl.theme.css")" rel="stylesheet" media="screen">
            //<!-- Stylesheet
            //================================================== -->
            //<link rel="stylesheet" type="text/css" href="@Url.Content("~/Resources/css/style.css")">
            //<link rel="stylesheet" type="text/css" href="@Url.Content("~/Resources/css/responsive.css")">
            //<link rel="stylesheet" type="text/css" href="@Url.Content("~/Resources/css/app.css")">

            //<link href='http://fonts.googleapis.com/css?family=Montserrat:400,700' rel='stylesheet' type='text/css'>

            //<link rel="stylesheet" href="@Url.Content("https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css")">

            //<script type="text/javascript" src="@Url.Content("~/Resources/js/modernizr.custom.js")"></script

        }
    }
}