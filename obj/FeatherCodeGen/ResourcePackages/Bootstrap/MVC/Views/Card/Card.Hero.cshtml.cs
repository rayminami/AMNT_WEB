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
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/Card/Card.Hero.cshtml")]
    public partial class Card_Hero : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Card.Mvc.Models.Card.CardViewModel>
    {
        public Card_Hero()
        {
        }
        public override void Execute()
        {
WriteLiteral("<div");

WriteAttribute("class", Tuple.Create(" class=\"", 75), Tuple.Create("\"", 108)
            
            #line 3 "..\..MVC\Views\Card\Card.Hero.cshtml"
, Tuple.Create(Tuple.Create("", 83), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 83), false)
, Tuple.Create(Tuple.Create(" ", 98), Tuple.Create("container", 99), true)
);

WriteLiteral(">\n    <div");

WriteLiteral(" class=\"jumbotron\"");

WriteAttribute("style", Tuple.Create(" style=\"", 137), Tuple.Create("\"", 225)
, Tuple.Create(Tuple.Create("", 145), Tuple.Create("background:", 145), true)
, Tuple.Create(Tuple.Create(" ", 156), Tuple.Create("url(\'", 157), true)
            
            #line 4 "..\..MVC\Views\Card\Card.Hero.cshtml"
, Tuple.Create(Tuple.Create("", 162), Tuple.Create<System.Object, System.Int32>(Model.SelectedSizeUrl
            
            #line default
            #line hidden
, 162), false)
, Tuple.Create(Tuple.Create("", 184), Tuple.Create("\')", 184), true)
, Tuple.Create(Tuple.Create(" ", 186), Tuple.Create("center", 187), true)
, Tuple.Create(Tuple.Create(" ", 193), Tuple.Create("center;", 194), true)
, Tuple.Create(Tuple.Create(" ", 201), Tuple.Create("background-size:", 202), true)
, Tuple.Create(Tuple.Create(" ", 218), Tuple.Create("cover;", 219), true)
);

WriteLiteral(">\n        <h1>");

            
            #line 5 "..\..MVC\Views\Card\Card.Hero.cshtml"
       Write(Html.Raw(Model.Heading));

            
            #line default
            #line hidden
WriteLiteral("</h1>\n        <p>");

            
            #line 6 "..\..MVC\Views\Card\Card.Hero.cshtml"
      Write(Html.Raw(Model.Description));

            
            #line default
            #line hidden
WriteLiteral("</p>\n");

            
            #line 7 "..\..MVC\Views\Card\Card.Hero.cshtml"
        
            
            #line default
            #line hidden
            
            #line 7 "..\..MVC\Views\Card\Card.Hero.cshtml"
         if (!string.IsNullOrEmpty(Model.ActionName))
        {

            
            #line default
            #line hidden
WriteLiteral("            <p><a");

WriteAttribute("href", Tuple.Create(" href=\"", 395), Tuple.Create("\"", 418)
            
            #line 9 "..\..MVC\Views\Card\Card.Hero.cshtml"
, Tuple.Create(Tuple.Create("", 402), Tuple.Create<System.Object, System.Int32>(Model.ActionUrl
            
            #line default
            #line hidden
, 402), false)
);

WriteLiteral(" class=\"btn btn-primary btn-lg\"");

WriteLiteral(" role=\"button\"");

WriteLiteral(" >");

            
            #line 9 "..\..MVC\Views\Card\Card.Hero.cshtml"
                                                                                   Write(Model.ActionName);

            
            #line default
            #line hidden
WriteLiteral("</a></p>\n");

            
            #line 10 "..\..MVC\Views\Card\Card.Hero.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </div>\n</div>");

        }
    }
}
#pragma warning restore 1591
