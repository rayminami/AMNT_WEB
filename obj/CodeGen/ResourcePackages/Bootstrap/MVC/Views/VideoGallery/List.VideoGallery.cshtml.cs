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

namespace SitefinityWebApp.ResourcePackages.Bootstrap.MVC.Views.VideoGallery
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
    
    #line 3 "..\..\ResourcePackages\Bootstrap\MVC\Views\VideoGallery\List.VideoGallery.cshtml"
    using Telerik.Sitefinity;
    
    #line default
    #line hidden
    
    #line 6 "..\..\ResourcePackages\Bootstrap\MVC\Views\VideoGallery\List.VideoGallery.cshtml"
    using Telerik.Sitefinity.Frontend.Media.Mvc.Models.VideoGallery;
    
    #line default
    #line hidden
    
    #line 4 "..\..\ResourcePackages\Bootstrap\MVC\Views\VideoGallery\List.VideoGallery.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 5 "..\..\ResourcePackages\Bootstrap\MVC\Views\VideoGallery\List.VideoGallery.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/ResourcePackages/Bootstrap/MVC/Views/VideoGallery/List.VideoGallery.cshtml")]
    public partial class List_VideoGallery : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Mvc.Models.ContentListViewModel>
    {
        public List_VideoGallery()
        {
        }
        public override void Execute()
        {
WriteLiteral("\n");

            
            #line 8 "..\..\ResourcePackages\Bootstrap\MVC\Views\VideoGallery\List.VideoGallery.cshtml"
Write(Html.Script(ScriptRef.JQuery, "top"));

            
            #line default
            #line hidden
WriteLiteral("\n\n<div");

WriteLiteral(" class=\"sf-Gallery-thumbs-container\"");

WriteLiteral(">\n    <div");

WriteAttribute("class", Tuple.Create(" class=\"", 340), Tuple.Create("\"", 415)
            
            #line 11 "..\..\ResourcePackages\Bootstrap\MVC\Views\VideoGallery\List.VideoGallery.cshtml"
, Tuple.Create(Tuple.Create("", 348), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 348), false)
, Tuple.Create(Tuple.Create(" ", 363), Tuple.Create("sf-Gallery-thumbs", 364), true)
, Tuple.Create(Tuple.Create(" ", 381), Tuple.Create("sf-Gallery-thumbs--video", 382), true)
, Tuple.Create(Tuple.Create(" ", 406), Tuple.Create("clearfix", 407), true)
);

WriteLiteral(">\n\n");

            
            #line 13 "..\..\ResourcePackages\Bootstrap\MVC\Views\VideoGallery\List.VideoGallery.cshtml"
        
            
            #line default
            #line hidden
            
            #line 13 "..\..\ResourcePackages\Bootstrap\MVC\Views\VideoGallery\List.VideoGallery.cshtml"
         for (int i = 0; i < Model.Items.Count(); i++)
        {
            var item = Model.Items.ElementAt(i);
            var itemIndex = (Model.CurrentPage - 1) * ViewBag.ItemsPerPage + i + 1;
            var detailPageUrl = ViewBag.OpenInSamePage ? HyperLinkHelpers.GetDetailPageUrl(item, ViewBag.DetailsPageId, ViewBag.OpenInSamePage, Model.UrlKeyPrefix, itemIndex) :
                HyperLinkHelpers.GetDetailPageUrl(item, ViewBag.DetailsPageId, ViewBag.OpenInSamePage, Model.UrlKeyPrefix);

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"pull-left\"");

WriteLiteral(">\n\t\t        <a\n               href=\"");

            
            #line 21 "..\..\ResourcePackages\Bootstrap\MVC\Views\VideoGallery\List.VideoGallery.cshtml"
                Write(detailPageUrl);

            
            #line default
            #line hidden
WriteLiteral("\"\n               title=\"");

            
            #line 22 "..\..\ResourcePackages\Bootstrap\MVC\Views\VideoGallery\List.VideoGallery.cshtml"
                  Write(string.IsNullOrEmpty(item.Fields.Description) ? item.Fields.Title : item.Fields.Description);

            
            #line default
            #line hidden
WriteLiteral("\">\n\t\t\t        <img");

WriteAttribute("src", Tuple.Create(" src=\"", 1138), Tuple.Create("\"", 1191)
            
            #line 23 "..\..\ResourcePackages\Bootstrap\MVC\Views\VideoGallery\List.VideoGallery.cshtml"
, Tuple.Create(Tuple.Create("", 1144), Tuple.Create<System.Object, System.Int32>(((VideoThumbnailViewModel)item).ThumbnailUrl
            
            #line default
            #line hidden
, 1144), false)
);

WriteAttribute("alt", Tuple.Create(" alt=\'", 1192), Tuple.Create("\'", 1280)
            
            #line 23 "..\..\ResourcePackages\Bootstrap\MVC\Views\VideoGallery\List.VideoGallery.cshtml"
    , Tuple.Create(Tuple.Create("", 1198), Tuple.Create<System.Object, System.Int32>(System.Text.RegularExpressions.Regex.Replace(item.Fields.Title, @"[^\w\d_-]", "")
            
            #line default
            #line hidden
, 1198), false)
);

WriteLiteral(" />\n                </a>\n                <h3>");

            
            #line 25 "..\..\ResourcePackages\Bootstrap\MVC\Views\VideoGallery\List.VideoGallery.cshtml"
               Write(item.Fields.Title);

            
            #line default
            #line hidden
WriteLiteral("</h3>\n            </div>\n");

            
            #line 27 "..\..\ResourcePackages\Bootstrap\MVC\Views\VideoGallery\List.VideoGallery.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("\n    </div>\n</div>\n");

            
            #line 31 "..\..\ResourcePackages\Bootstrap\MVC\Views\VideoGallery\List.VideoGallery.cshtml"
        
            
            #line default
            #line hidden
            
            #line 31 "..\..\ResourcePackages\Bootstrap\MVC\Views\VideoGallery\List.VideoGallery.cshtml"
         if (Model.ShowPager)
        {
            
            
            #line default
            #line hidden
            
            #line 33 "..\..\ResourcePackages\Bootstrap\MVC\Views\VideoGallery\List.VideoGallery.cshtml"
       Write(Html.Action("Index", "ContentPager", new
               {
                   currentPage = Model.CurrentPage,
                   totalPagesCount = Model.TotalPagesCount.Value,
                   redirectUrlTemplate = ViewBag.RedirectPageUrlTemplate
               }));

            
            #line default
            #line hidden
            
            #line 38 "..\..\ResourcePackages\Bootstrap\MVC\Views\VideoGallery\List.VideoGallery.cshtml"
                 
        }

            
            #line default
            #line hidden
WriteLiteral("\n");

        }
    }
}
#pragma warning restore 1591
