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

namespace SitefinityWebApp.ResourcePackages.Bootstrap.MVC.Views.Navigation
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
    
    #line 3 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 4 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
    using Telerik.Sitefinity.Frontend.Navigation.Mvc.Models;
    
    #line default
    #line hidden
    
    #line 5 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/ResourcePackages/Bootstrap/MVC/Views/Navigation/NavigationView.Sitemap.cshtml")]
    public partial class NavigationView_Sitemap : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Navigation.Mvc.Models.INavigationModel>
    {

#line 20 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
public System.Web.WebPages.HelperResult RenderRootLevelNode(NodeViewModel node)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 21 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
 


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <li>\n        <a");

WriteAttributeTo(__razor_helper_writer, "href", Tuple.Create(" href=\"", 643), Tuple.Create("\"", 659)

#line 23 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
, Tuple.Create(Tuple.Create("", 650), Tuple.Create<System.Object, System.Int32>(node.Url

#line default
#line hidden
, 650), false)
);

WriteAttributeTo(__razor_helper_writer, "target", Tuple.Create(" target=\"", 660), Tuple.Create("\"", 685)

#line 23 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
, Tuple.Create(Tuple.Create("", 669), Tuple.Create<System.Object, System.Int32>(node.LinkTarget

#line default
#line hidden
, 669), false)
);

WriteLiteralTo(__razor_helper_writer, "><strong>");


#line 23 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
                                WriteTo(__razor_helper_writer, node.Title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</strong></a>\n");


#line 24 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
        

#line default
#line hidden

#line 24 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
         if (node.ChildNodes.Count > 0)
        {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            <ul");

WriteLiteralTo(__razor_helper_writer, " class=\"nav nav-stacked\"");

WriteLiteralTo(__razor_helper_writer, ">\n");


#line 27 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
                

#line default
#line hidden

#line 27 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
                 foreach (var childNode in node.ChildNodes)
                {
                    

#line default
#line hidden

#line 29 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
WriteTo(__razor_helper_writer, RenderSubLevelsRecursive(childNode));


#line default
#line hidden

#line 29 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
                                                        
                }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            </ul>\n");


#line 32 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
        }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    </li>\n");


#line 34 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Sitemap.cshtml"


#line default
#line hidden
});

#line 34 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
}
#line default
#line hidden

#line 37 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
public System.Web.WebPages.HelperResult RenderSubLevelsRecursive(NodeViewModel node)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 38 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
 


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <li>\n        <a");

WriteAttributeTo(__razor_helper_writer, "href", Tuple.Create(" href=\"", 1134), Tuple.Create("\"", 1150)

#line 40 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
, Tuple.Create(Tuple.Create("", 1141), Tuple.Create<System.Object, System.Int32>(node.Url

#line default
#line hidden
, 1141), false)
);

WriteLiteralTo(__razor_helper_writer, " target =\"");


#line 40 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
       WriteTo(__razor_helper_writer, node.LinkTarget);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\">");


#line 40 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
                         WriteTo(__razor_helper_writer, node.Title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</a>\n");


#line 41 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
        

#line default
#line hidden

#line 41 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
         if (node.ChildNodes.Count > 0)
        {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            <ul");

WriteLiteralTo(__razor_helper_writer, " class=\"nav\"");

WriteLiteralTo(__razor_helper_writer, ">\n");


#line 44 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
                

#line default
#line hidden

#line 44 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
                 foreach (var childNode in node.ChildNodes)
                {
                    

#line default
#line hidden

#line 46 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
WriteTo(__razor_helper_writer, RenderSubLevelsRecursive(childNode));


#line default
#line hidden

#line 46 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
                                                        
                }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            </ul>\n");


#line 49 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
        }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    </li>\n");


#line 51 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Sitemap.cshtml"


#line default
#line hidden
});

#line 51 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
}
#line default
#line hidden

        public NavigationView_Sitemap()
        {
        }
        public override void Execute()
        {
WriteLiteral("\n");

WriteLiteral("\n\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 260), Tuple.Create("\"", 283)
            
            #line 9 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
, Tuple.Create(Tuple.Create("", 268), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 268), false)
);

WriteLiteral(">\n    ");

WriteLiteral("\n\n    <ul");

WriteLiteral(" class=\"nav nav-sitemap\"");

WriteLiteral(">\n");

            
            #line 13 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
        
            
            #line default
            #line hidden
            
            #line 13 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
         foreach (var node in Model.Nodes)
        {
            
            
            #line default
            #line hidden
            
            #line 15 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
       Write(RenderRootLevelNode(node));

            
            #line default
            #line hidden
            
            #line 15 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
                                      ;
        }

            
            #line default
            #line hidden
WriteLiteral("    </ul>\n</div>\n");

WriteLiteral("\n");

WriteLiteral("\n");

WriteLiteral("\n");

        }
    }
}
#pragma warning restore 1591
