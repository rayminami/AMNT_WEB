#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SitefinityWebApp.ResourcePackages.Bootstrap.MVC.Views.SocialShare
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 3 "..\..\ResourcePackages\Bootstrap\MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 2 "..\..\ResourcePackages\Bootstrap\MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
    using Telerik.Sitefinity.Frontend.SocialShare.SocialShareHelpers;
    
    #line default
    #line hidden
    
    #line 4 "..\..\ResourcePackages\Bootstrap\MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/ResourcePackages/Bootstrap/MVC/Views/SocialShare/SocialShareIconsWithText.cshtm" +
        "l")]
    public partial class SocialShareIconsWithText : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.SocialShare.Mvc.Models.SocialShareModel>
    {
        public SocialShareIconsWithText()
        {
        }
        public override void Execute()
        {
WriteLiteral("\n");

            
            #line 6 "..\..\ResourcePackages\Bootstrap\MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
  
    var shareUrl = SocialShareButtons.ShareUrl;
    var unencodedPageTitle = Model.ItemTitle != null ? Model.ItemTitle : SocialShareButtons.PageTitle;
    var pageTitle = HttpUtility.UrlEncode(unencodedPageTitle);

            
            #line default
            #line hidden
WriteLiteral("\n\n");

            
            #line 12 "..\..\ResourcePackages\Bootstrap\MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
Write(Html.StyleSheet(Url.WidgetContent("assets/dist/css/sf-social-share.min.css"), "head", false));

            
            #line default
            #line hidden
WriteLiteral("\n");

            
            #line 13 "..\..\ResourcePackages\Bootstrap\MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
Write(Html.Script(ScriptRef.JQuery, "head", false));

            
            #line default
            #line hidden
WriteLiteral("\n\n<style>\n    .color {color: blue;}\n</style>\n\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 639), Tuple.Create("\"", 662)
            
            #line 19 "..\..\ResourcePackages\Bootstrap\MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
, Tuple.Create(Tuple.Create("", 647), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 647), false)
);

WriteLiteral(">\n    <ul");

WriteLiteral(" class=\"list-inline sf-social-share\"");

WriteLiteral(">\n");

            
            #line 21 "..\..\ResourcePackages\Bootstrap\MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
        
            
            #line default
            #line hidden
            
            #line 21 "..\..\ResourcePackages\Bootstrap\MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
         foreach (var button in Model.SocialButtons)
        {
            switch (button.ButtonName)
            {
                case "Facebook":

            
            #line default
            #line hidden
WriteLiteral("                    <li");

WriteLiteral(" data-sf-role=\"socialShare\"");

WriteLiteral(" data-sf-socialshareoption=\"");

            
            #line 26 "..\..\ResourcePackages\Bootstrap\MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
                                                                         Write(button.ButtonName);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(">\n                        <div");

WriteLiteral(" class=\'fb-share-button\'");

WriteLiteral(" data-href=\'");

            
            #line 27 "..\..\ResourcePackages\Bootstrap\MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
                                                           Write(shareUrl);

            
            #line default
            #line hidden
WriteLiteral("\'");

WriteLiteral(" data-type=\'button_count\'");

WriteLiteral("></div>\n                        <div");

WriteLiteral(" id=\'fb-root\'");

WriteLiteral(@"></div>
                        <script>
                            (function (d, s, id) { var js, fjs = d.getElementsByTagName(s)[0]; if (d.getElementById(id)) return; js = d.createElement(s); js.id = id; js.src = '//connect.facebook.net/en_EN/all.js#xfbml=1'; fjs.parentNode.insertBefore(js, fjs); }(document, 'script', 'facebook-jssdk'));
                        </script>
                    </li>
");

            
            #line 33 "..\..\ResourcePackages\Bootstrap\MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
                    break;
                case "Twitter":

            
            #line default
            #line hidden
WriteLiteral("                    <li");

WriteLiteral(" data-sf-role=\"socialShare\"");

WriteLiteral(" data-sf-socialshareoption=\"");

            
            #line 35 "..\..\ResourcePackages\Bootstrap\MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
                                                                         Write(button.ButtonName);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(">\n                        <a");

WriteLiteral(" href=\'https://twitter.com/share\'");

WriteLiteral(" title=\'Share on Twitter\'");

WriteLiteral(" class=\'twitter-share-button\'");

WriteLiteral(" data-url=");

            
            #line 36 "..\..\ResourcePackages\Bootstrap\MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
                                                                                                                      Write(shareUrl);

            
            #line default
            #line hidden
WriteLiteral(" data-count=\'horizontal\'");

WriteLiteral(@">
                            Tweet
                        </a>
                        <script>
                            !function (d, s, id) { var js, fjs = d.getElementsByTagName(s)[0], p = /^http:/.test(d.location) ? 'http' : 'https'; if (!d.getElementById(id)) { js = d.createElement(s); js.id = id; js.src = p + '://platform.twitter.com/widgets.js'; fjs.parentNode.insertBefore(js, fjs); } }(document, 'script', 'twitter-wjs');
                        </script>
                    </li>
");

            
            #line 43 "..\..\ResourcePackages\Bootstrap\MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
                    break;
                case "LinkedIn":

            
            #line default
            #line hidden
WriteLiteral("                <li");

WriteLiteral(" data-sf-role=\"socialShare\"");

WriteLiteral(" data-sf-socialshareoption=\"");

            
            #line 45 "..\..\ResourcePackages\Bootstrap\MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
                                                                     Write(button.ButtonName);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(">\n                    <script");

WriteLiteral(" src=\"//platform.linkedin.com/in.js\"");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\n                        lang: en_US\n                    </script>\n             " +
"       <script");

WriteLiteral(" type=\"IN/Share\"");

WriteLiteral(" data-url=\'");

            
            #line 49 "..\..\ResourcePackages\Bootstrap\MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
                                                 Write(shareUrl);

            
            #line default
            #line hidden
WriteLiteral("\'");

WriteLiteral(" data-counter=\"right\"");

WriteLiteral(">\n                    </script>\n                </li>\n");

            
            #line 52 "..\..\ResourcePackages\Bootstrap\MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
                    break;
                case "GooglePlusOne":

            
            #line default
            #line hidden
WriteLiteral("                <li");

WriteLiteral(" data-sf-role=\"socialShare\"");

WriteLiteral(" data-sf-socialshareoption=\"");

            
            #line 54 "..\..\ResourcePackages\Bootstrap\MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
                                                                     Write(button.ButtonName);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(">\n                    <div");

WriteLiteral(" class=\'g-plusone\'");

WriteLiteral(" data-size=\'medium\'");

WriteLiteral(" data-callback=\"googleShareCallback\"");

WriteLiteral("></div>\n                    <script");

WriteLiteral(" type=\'text/javascript\'");

WriteLiteral(@">
                        (function () { var po = document.createElement('script'); po.type = 'text/javascript'; po.async = true; po.src = 'https://apis.google.com/js/platform.js'; var s = document.getElementsByTagName('script')[0]; s.parentNode.insertBefore(po, s); })();
                    </script>
                </li>
");

            
            #line 60 "..\..\ResourcePackages\Bootstrap\MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
                    break;
                case "Blogger":

            
            #line default
            #line hidden
WriteLiteral("                <li");

WriteLiteral(" data-sf-role=\"socialShare\"");

WriteLiteral(" data-sf-socialshareoption=\"");

            
            #line 62 "..\..\ResourcePackages\Bootstrap\MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
                                                                     Write(button.ButtonName);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(">\n                    <a");

WriteLiteral(" class=\"sf-share-button\"");

WriteLiteral(" href=\"#\"");

WriteAttribute("onclick", Tuple.Create(" onclick=\"", 3618), Tuple.Create("\"", 3767)
, Tuple.Create(Tuple.Create("", 3628), Tuple.Create("window.open(\'https://www.blogger.com/blog_this.pyra?t&u=", 3628), true)
            
            #line 63 "..\..\ResourcePackages\Bootstrap\MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
                                         , Tuple.Create(Tuple.Create("", 3684), Tuple.Create<System.Object, System.Int32>(shareUrl
            
            #line default
            #line hidden
, 3684), false)
, Tuple.Create(Tuple.Create("", 3693), Tuple.Create("&n=", 3693), true)
            
            #line 63 "..\..\ResourcePackages\Bootstrap\MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
                                                     , Tuple.Create(Tuple.Create("", 3696), Tuple.Create<System.Object, System.Int32>(pageTitle
            
            #line default
            #line hidden
, 3696), false)
, Tuple.Create(Tuple.Create("", 3706), Tuple.Create("\',", 3706), true)
, Tuple.Create(Tuple.Create(" ", 3708), Tuple.Create("\'Blogger\',\'toolbar=no,width=550,height=550\');", 3709), true)
, Tuple.Create(Tuple.Create(" ", 3754), Tuple.Create("return", 3755), true)
, Tuple.Create(Tuple.Create(" ", 3761), Tuple.Create("false", 3762), true)
);

WriteLiteral(" title=\"Share on Blogger\"");

WriteLiteral(">\n                        <span");

WriteLiteral(" class=\"sf-icon-blogger\"");

WriteLiteral("></span>\n                        <strong>Blogger</strong>\n                    </a" +
">\n                </li>\n");

            
            #line 68 "..\..\ResourcePackages\Bootstrap\MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
                    break;
                case "Delicious":

            
            #line default
            #line hidden
WriteLiteral("                <li");

WriteLiteral(" data-sf-role=\"socialShare\"");

WriteLiteral(" data-sf-socialshareoption=\"");

            
            #line 70 "..\..\ResourcePackages\Bootstrap\MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
                                                                     Write(button.ButtonName);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(">\n                    <a");

WriteLiteral(" href=\"#\"");

WriteAttribute("onclick", Tuple.Create(" onclick=\"", 4140), Tuple.Create("\"", 4321)
, Tuple.Create(Tuple.Create("", 4150), Tuple.Create("window.open(\'https://delicious.com/save?v=5&provider=Telerik&noui&jump=close&url=" +
"", 4150), true)
            
            #line 71 "..\..\ResourcePackages\Bootstrap\MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
                                          , Tuple.Create(Tuple.Create("", 4231), Tuple.Create<System.Object, System.Int32>(shareUrl
            
            #line default
            #line hidden
, 4231), false)
, Tuple.Create(Tuple.Create("", 4240), Tuple.Create("&title=", 4240), true)
            
            #line 71 "..\..\ResourcePackages\Bootstrap\MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
                                                          , Tuple.Create(Tuple.Create("", 4247), Tuple.Create<System.Object, System.Int32>(pageTitle
            
            #line default
            #line hidden
, 4247), false)
, Tuple.Create(Tuple.Create("", 4257), Tuple.Create("\',", 4257), true)
, Tuple.Create(Tuple.Create(" ", 4259), Tuple.Create("\'delicious\',\'toolbar=no,width=550,height=550\');", 4260), true)
, Tuple.Create(Tuple.Create(" ", 4307), Tuple.Create("return", 4308), true)
, Tuple.Create(Tuple.Create(" ", 4314), Tuple.Create("false;", 4315), true)
);

WriteLiteral(">\n                        <img");

WriteLiteral(" src=\"https://delicious.com/img/logo.png\"");

WriteLiteral(" height=\"16\"");

WriteLiteral(" width=\"16\"");

WriteLiteral(" alt=\"Delicious\"");

WriteLiteral("> Save this on Delicious\n                    </a>\n                </li>\n");

            
            #line 75 "..\..\ResourcePackages\Bootstrap\MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
                    break;
                case "Tumblr":

            
            #line default
            #line hidden
WriteLiteral("                <li");

WriteLiteral(" data-sf-role=\"socialShare\"");

WriteLiteral(" data-sf-socialshareoption=\"");

            
            #line 77 "..\..\ResourcePackages\Bootstrap\MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
                                                                     Write(button.ButtonName);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(">\n                    <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" onclick=\"window.open(\'http://www.tumblr.com/share\', \'Tumblr\',\'toolbar=no,width=9" +
"00,height=550\')\"");

WriteLiteral(";S");

WriteLiteral(" title=\"Share on Tumblr\"");

WriteLiteral(" style=\"display:inline-block; text-indent:-9999px; overflow:hidden; width:81px; h" +
"eight:20px; background:url(\'https://platform.tumblr.com/v1/share_1.png\') top lef" +
"t no-repeat transparent;\"");

WriteLiteral(">Share on Tumblr</a>\n                </li>\n");

            
            #line 80 "..\..\ResourcePackages\Bootstrap\MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
                    break;
                case "GoogleBookmarks":

            
            #line default
            #line hidden
WriteLiteral("                <li");

WriteLiteral(" data-sf-role=\"socialShare\"");

WriteLiteral(" data-sf-socialshareoption=\"");

            
            #line 82 "..\..\ResourcePackages\Bootstrap\MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
                                                                     Write(button.ButtonName);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(">\n                    <a");

WriteLiteral(" class=\"sf-share-button\"");

WriteLiteral(" href=\"#\"");

WriteAttribute("onclick", Tuple.Create(" onclick=\"", 5257), Tuple.Create("\"", 5426)
, Tuple.Create(Tuple.Create("", 5267), Tuple.Create("window.open(\'https://www.google.com/bookmarks/mark?op=add&bkmk=", 5267), true)
            
            #line 83 "..\..\ResourcePackages\Bootstrap\MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
                                                , Tuple.Create(Tuple.Create("", 5330), Tuple.Create<System.Object, System.Int32>(shareUrl
            
            #line default
            #line hidden
, 5330), false)
, Tuple.Create(Tuple.Create("", 5339), Tuple.Create("&title=", 5339), true)
            
            #line 83 "..\..\ResourcePackages\Bootstrap\MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
                                                                , Tuple.Create(Tuple.Create("", 5346), Tuple.Create<System.Object, System.Int32>(pageTitle
            
            #line default
            #line hidden
, 5346), false)
, Tuple.Create(Tuple.Create("", 5356), Tuple.Create("\',", 5356), true)
, Tuple.Create(Tuple.Create(" ", 5358), Tuple.Create("\'Google", 5359), true)
, Tuple.Create(Tuple.Create(" ", 5366), Tuple.Create("bookmarks\',\'toolbar=no,width=550,height=550\');", 5367), true)
, Tuple.Create(Tuple.Create(" ", 5413), Tuple.Create("return", 5414), true)
, Tuple.Create(Tuple.Create(" ", 5420), Tuple.Create("false", 5421), true)
);

WriteLiteral(" title=\"Share on GoogleBookmarks\"");

WriteLiteral(">\n                        <span");

WriteLiteral(" class=\"sf-icon-google\"");

WriteLiteral("></span>\n                        <strong>Google Bookmarks</strong>\n              " +
"      </a>\n                </li>\n");

            
            #line 88 "..\..\ResourcePackages\Bootstrap\MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
                    break;
                case "Digg":

            
            #line default
            #line hidden
WriteLiteral("                <li");

WriteLiteral(" data-sf-role=\"socialShare\"");

WriteLiteral(" data-sf-socialshareoption=\"");

            
            #line 90 "..\..\ResourcePackages\Bootstrap\MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
                                                                     Write(button.ButtonName);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(">\n                    <a");

WriteLiteral(" class=\"sf-share-button\"");

WriteLiteral(" href=\"#\"");

WriteAttribute("onclick", Tuple.Create(" onclick=\"", 5834), Tuple.Create("\"", 5968)
, Tuple.Create(Tuple.Create("", 5844), Tuple.Create("window.open(\'http://digg.com/submit?url=", 5844), true)
            
            #line 91 "..\..\ResourcePackages\Bootstrap\MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
                         , Tuple.Create(Tuple.Create("", 5884), Tuple.Create<System.Object, System.Int32>(shareUrl
            
            #line default
            #line hidden
, 5884), false)
, Tuple.Create(Tuple.Create("", 5893), Tuple.Create("&title=", 5893), true)
            
            #line 91 "..\..\ResourcePackages\Bootstrap\MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
                                         , Tuple.Create(Tuple.Create("", 5900), Tuple.Create<System.Object, System.Int32>(pageTitle
            
            #line default
            #line hidden
, 5900), false)
, Tuple.Create(Tuple.Create("", 5910), Tuple.Create("\',", 5910), true)
, Tuple.Create(Tuple.Create(" ", 5912), Tuple.Create("\'Digg\',\'toolbar=no,width=550,height=550\');", 5913), true)
, Tuple.Create(Tuple.Create(" ", 5955), Tuple.Create("return", 5956), true)
, Tuple.Create(Tuple.Create(" ", 5962), Tuple.Create("false", 5963), true)
);

WriteLiteral(" title=\"Share on Digg\"");

WriteLiteral(">\n                        <span");

WriteLiteral(" class=\"sf-icon-digg\"");

WriteLiteral("></span> <strong>Digg</strong>\n                    </a>\n                </li>\n");

            
            #line 95 "..\..\ResourcePackages\Bootstrap\MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
                    break;
                case "MySpace":

            
            #line default
            #line hidden
WriteLiteral("                <li");

WriteLiteral(" data-sf-role=\"socialShare\"");

WriteLiteral(" data-sf-socialshareoption=\"");

            
            #line 97 "..\..\ResourcePackages\Bootstrap\MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
                                                                     Write(button.ButtonName);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(">\n                    <a");

WriteLiteral(" class=\"sf-share-button\"");

WriteLiteral(" href=\"#\"");

WriteAttribute("onclick", Tuple.Create(" onclick=\"", 6330), Tuple.Create("\"", 6480)
, Tuple.Create(Tuple.Create("", 6340), Tuple.Create("window.open(\'http://myspace.com/Modules/PostTo/Pages/?u=", 6340), true)
            
            #line 98 "..\..\ResourcePackages\Bootstrap\MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
                                         , Tuple.Create(Tuple.Create("", 6396), Tuple.Create<System.Object, System.Int32>(shareUrl
            
            #line default
            #line hidden
, 6396), false)
, Tuple.Create(Tuple.Create("", 6405), Tuple.Create("&t=", 6405), true)
            
            #line 98 "..\..\ResourcePackages\Bootstrap\MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
                                                     , Tuple.Create(Tuple.Create("", 6408), Tuple.Create<System.Object, System.Int32>(pageTitle
            
            #line default
            #line hidden
, 6408), false)
, Tuple.Create(Tuple.Create("", 6418), Tuple.Create("\',", 6418), true)
, Tuple.Create(Tuple.Create(" ", 6420), Tuple.Create("\'My", 6421), true)
, Tuple.Create(Tuple.Create(" ", 6424), Tuple.Create("Space\',\'toolbar=no,width=550,height=550\');", 6425), true)
, Tuple.Create(Tuple.Create(" ", 6467), Tuple.Create("return", 6468), true)
, Tuple.Create(Tuple.Create(" ", 6474), Tuple.Create("false", 6475), true)
);

WriteLiteral(" title=\"Share on MySpace\"");

WriteLiteral(">\n                        <span");

WriteLiteral(" class=\"sf-icon-myspace\"");

WriteLiteral("></span>\n                        <strong>MySpace</strong>\n                    </a" +
">\n                </li>\n");

            
            #line 103 "..\..\ResourcePackages\Bootstrap\MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
                    break;
                case "StumbleUpon":

            
            #line default
            #line hidden
WriteLiteral("                <li");

WriteLiteral(" data-sf-role=\"socialShare\"");

WriteLiteral(" data-sf-socialshareoption=\"");

            
            #line 105 "..\..\ResourcePackages\Bootstrap\MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
                                                                     Write(button.ButtonName);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(">\n                    <!-- Place this tag where you want the su badge to render -" +
"->\n                    <su:badge");

WriteLiteral(" layout=\"2\"");

WriteLiteral("></su:badge>\n\n                    <!-- Place this snippet wherever appropriate --" +
">\n                    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(@">
                        (function () {
                            var li = document.createElement('script'); li.type = 'text/javascript'; li.async = true;
                            li.src = ('https:' == document.location.protocol ? 'https:' : 'http:') + '//platform.stumbleupon.com/1/widgets.js';
                            var s = document.getElementsByTagName('script')[0]; s.parentNode.insertBefore(li, s);
                        })();
                    </script>

                </li>
");

            
            #line 119 "..\..\ResourcePackages\Bootstrap\MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
                    break;
                case "Reddit":

            
            #line default
            #line hidden
WriteLiteral("                <li");

WriteLiteral(" data-sf-role=\"socialShare\"");

WriteLiteral(" data-sf-socialshareoption=\"");

            
            #line 121 "..\..\ResourcePackages\Bootstrap\MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
                                                                     Write(button.ButtonName);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(">\n                    <a");

WriteLiteral(" href=\"//www.reddit.com/submit\"");

WriteAttribute("onclick", Tuple.Create(" onclick=\"", 7784), Tuple.Create("\"", 7865)
, Tuple.Create(Tuple.Create("", 7794), Tuple.Create("window.location", 7794), true)
, Tuple.Create(Tuple.Create(" ", 7809), Tuple.Create("=", 7810), true)
, Tuple.Create(Tuple.Create(" ", 7811), Tuple.Create("\'//www.reddit.com/submit?url=", 7812), true)
            
            #line 122 "..\..\ResourcePackages\Bootstrap\MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
                              , Tuple.Create(Tuple.Create("", 7841), Tuple.Create<System.Object, System.Int32>(shareUrl
            
            #line default
            #line hidden
, 7841), false)
, Tuple.Create(Tuple.Create("", 7850), Tuple.Create("\';", 7850), true)
, Tuple.Create(Tuple.Create(" ", 7852), Tuple.Create("return", 7853), true)
, Tuple.Create(Tuple.Create(" ", 7859), Tuple.Create("false", 7860), true)
);

WriteLiteral("> <img");

WriteLiteral(" src=\"//www.redditstatic.com/spreddit7.gif\"");

WriteLiteral(" alt=\"submit to reddit\"");

WriteLiteral(" border=\"0\"");

WriteLiteral(" /> </a>\n                </li>\n");

            
            #line 124 "..\..\ResourcePackages\Bootstrap\MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
                    break;

                case "MailTo":

            
            #line default
            #line hidden
WriteLiteral("                <li");

WriteLiteral(" data-sf-role=\"socialShare\"");

WriteLiteral(" data-sf-socialshareoption=\"");

            
            #line 127 "..\..\ResourcePackages\Bootstrap\MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
                                                                     Write(button.ButtonName);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(">\n                    <a");

WriteAttribute("href", Tuple.Create(" href=\"", 8156), Tuple.Create("\"", 8204)
, Tuple.Create(Tuple.Create("", 8163), Tuple.Create("mailto:?body=", 8163), true)
            
            #line 128 "..\..\ResourcePackages\Bootstrap\MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
, Tuple.Create(Tuple.Create("", 8176), Tuple.Create<System.Object, System.Int32>(shareUrl
            
            #line default
            #line hidden
, 8176), false)
, Tuple.Create(Tuple.Create("", 8185), Tuple.Create("&subject=", 8185), true)
            
            #line 128 "..\..\ResourcePackages\Bootstrap\MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
, Tuple.Create(Tuple.Create("", 8194), Tuple.Create<System.Object, System.Int32>(pageTitle
            
            #line default
            #line hidden
, 8194), false)
);

WriteLiteral(" class=\"sf-share-button\"");

WriteLiteral(" title=\"Tell a friend\"");

WriteLiteral(">\n                        <span");

WriteLiteral(" class=\"sf-icon-mailto\"");

WriteLiteral("></span>\n                        <strong>Email</strong>\n                    </a>\n" +
"                </li>\n");

            
            #line 133 "..\..\ResourcePackages\Bootstrap\MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
                    break;
                default:
                    break;
            }
        }

            
            #line default
            #line hidden
WriteLiteral("    </ul>\n</div>\n\n");

            
            #line 141 "..\..\ResourcePackages\Bootstrap\MVC\Views\SocialShare\SocialShareIconsWithText.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/SocialShare/social-share.js"), "bottom", false));

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
