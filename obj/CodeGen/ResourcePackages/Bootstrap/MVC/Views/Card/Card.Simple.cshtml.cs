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

namespace SitefinityWebApp.ResourcePackages.Bootstrap.MVC.Views.Card
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/ResourcePackages/Bootstrap/MVC/Views/Card/Card.Simple.cshtml")]
    public partial class Card_Simple : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Card.Mvc.Models.Card.CardViewModel>
    {
        public Card_Simple()
        {
        }
        public override void Execute()
        {
WriteLiteral("<div");

WriteAttribute("class", Tuple.Create(" class=\"", 75), Tuple.Create("\"", 98)
            
            #line 3 "..\..\ResourcePackages\Bootstrap\MVC\Views\Card\Card.Simple.cshtml"
, Tuple.Create(Tuple.Create("", 83), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 83), false)
);

WriteLiteral(">\n    <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\n        <div");

WriteLiteral(" class=\"col-md-6\"");

WriteLiteral(">\n            <img");

WriteAttribute("src", Tuple.Create(" src=\"", 170), Tuple.Create("\"", 198)
            
            #line 6 "..\..\ResourcePackages\Bootstrap\MVC\Views\Card\Card.Simple.cshtml"
, Tuple.Create(Tuple.Create("", 176), Tuple.Create<System.Object, System.Int32>(Model.SelectedSizeUrl
            
            #line default
            #line hidden
, 176), false)
);

WriteAttribute("title", Tuple.Create(" title=\"", 199), Tuple.Create("\"", 224)
            
            #line 6 "..\..\ResourcePackages\Bootstrap\MVC\Views\Card\Card.Simple.cshtml"
, Tuple.Create(Tuple.Create("", 207), Tuple.Create<System.Object, System.Int32>(Model.ImageTitle
            
            #line default
            #line hidden
, 207), false)
);

WriteAttribute("alt", Tuple.Create(" alt=\"", 225), Tuple.Create("\"", 258)
            
            #line 6 "..\..\ResourcePackages\Bootstrap\MVC\Views\Card\Card.Simple.cshtml"
, Tuple.Create(Tuple.Create("", 231), Tuple.Create<System.Object, System.Int32>(Model.ImageAlternativeText
            
            #line default
            #line hidden
, 231), false)
);

WriteLiteral(" class=\"img-responsive\"");

WriteLiteral(">\n        </div>\n        <div");

WriteLiteral(" class=\"col-md-6 \"");

WriteLiteral(">\n            <div");

WriteLiteral(" class=\"caption\"");

WriteLiteral(">\n                <h3>");

            
            #line 10 "..\..\ResourcePackages\Bootstrap\MVC\Views\Card\Card.Simple.cshtml"
               Write(Html.Raw(Model.Heading));

            
            #line default
            #line hidden
WriteLiteral("</h3>\n                <p>");

            
            #line 11 "..\..\ResourcePackages\Bootstrap\MVC\Views\Card\Card.Simple.cshtml"
              Write(Html.Raw(Model.Description));

            
            #line default
            #line hidden
WriteLiteral("</p>\n\n");

            
            #line 13 "..\..\ResourcePackages\Bootstrap\MVC\Views\Card\Card.Simple.cshtml"
                
            
            #line default
            #line hidden
            
            #line 13 "..\..\ResourcePackages\Bootstrap\MVC\Views\Card\Card.Simple.cshtml"
                 if (!string.IsNullOrEmpty(Model.ActionName))
                {

            
            #line default
            #line hidden
WriteLiteral("                    <p><a");

WriteAttribute("href", Tuple.Create(" href=\"", 573), Tuple.Create("\"", 596)
            
            #line 15 "..\..\ResourcePackages\Bootstrap\MVC\Views\Card\Card.Simple.cshtml"
, Tuple.Create(Tuple.Create("", 580), Tuple.Create<System.Object, System.Int32>(Model.ActionUrl
            
            #line default
            #line hidden
, 580), false)
);

WriteLiteral(" class=\"btn btn-primary\"");

WriteLiteral(" role=\"button\"");

WriteLiteral(" >");

            
            #line 15 "..\..\ResourcePackages\Bootstrap\MVC\Views\Card\Card.Simple.cshtml"
                                                                                    Write(Model.ActionName);

            
            #line default
            #line hidden
WriteLiteral("</a></p>\n");

            
            #line 16 "..\..\ResourcePackages\Bootstrap\MVC\Views\Card\Card.Simple.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </div>\n        </div>\n    </div>\n</div>\n");

        }
    }
}
#pragma warning restore 1591
