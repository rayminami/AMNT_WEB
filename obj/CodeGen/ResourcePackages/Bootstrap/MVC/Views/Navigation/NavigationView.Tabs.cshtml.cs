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
    
    #line 3 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Tabs.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 4 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Tabs.cshtml"
    using Telerik.Sitefinity.Frontend.Navigation.Mvc.Models;
    
    #line default
    #line hidden
    
    #line 5 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Tabs.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/ResourcePackages/Bootstrap/MVC/Views/Navigation/NavigationView.Tabs.cshtml")]
    public partial class NavigationView_Tabs : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Navigation.Mvc.Models.INavigationModel>
    {

#line 17 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Tabs.cshtml"
public System.Web.WebPages.HelperResult RenderRootLevelNode(IList<NodeViewModel> nodes)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 18 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Tabs.cshtml"
 


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <ul");

WriteLiteralTo(__razor_helper_writer, " class=\"nav nav-tabs\"");

WriteLiteralTo(__razor_helper_writer, ">\n");


#line 20 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Tabs.cshtml"
        

#line default
#line hidden

#line 20 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Tabs.cshtml"
         foreach(var node in nodes)
        {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            <li");

WriteAttributeTo(__razor_helper_writer, "class", Tuple.Create(" class=\"", 661), Tuple.Create("\"", 684)

#line 22 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Tabs.cshtml"
, Tuple.Create(Tuple.Create("", 669), Tuple.Create<System.Object, System.Int32>(GetClass(node)

#line default
#line hidden
, 669), false)
);

WriteLiteralTo(__razor_helper_writer, ">\n                <a");

WriteAttributeTo(__razor_helper_writer, "href", Tuple.Create(" href=\"", 705), Tuple.Create("\"", 721)

#line 23 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Tabs.cshtml"
, Tuple.Create(Tuple.Create("", 712), Tuple.Create<System.Object, System.Int32>(node.Url

#line default
#line hidden
, 712), false)
);

WriteAttributeTo(__razor_helper_writer, "target", Tuple.Create(" target=\"", 722), Tuple.Create("\"", 747)

#line 23 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Tabs.cshtml"
, Tuple.Create(Tuple.Create("", 731), Tuple.Create<System.Object, System.Int32>(node.LinkTarget

#line default
#line hidden
, 731), false)
);

WriteLiteralTo(__razor_helper_writer, ">");


#line 23 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Tabs.cshtml"
                                WriteTo(__razor_helper_writer, node.Title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</a>\n            </li>\n");


#line 25 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Tabs.cshtml"
        }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    </ul>\n");


#line 27 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Tabs.cshtml"


#line default
#line hidden
});

#line 27 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Tabs.cshtml"
}
#line default
#line hidden

#line 30 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Tabs.cshtml"
public System.Web.WebPages.HelperResult RenderSubLevelsRecursive(IList<NodeViewModel> nodes)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 31 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Tabs.cshtml"
 
    var selectedNode = nodes.SingleOrDefault(node => node.IsCurrentlyOpened || node.HasChildOpen);

    if(selectedNode !=null)
    {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "         <ul");

WriteLiteralTo(__razor_helper_writer, " class=\"nav nav-pills\"");

WriteLiteralTo(__razor_helper_writer, ">\n");


#line 37 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Tabs.cshtml"
            

#line default
#line hidden

#line 37 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Tabs.cshtml"
             foreach (var node in selectedNode.ChildNodes)
            {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "                <li");

WriteAttributeTo(__razor_helper_writer, "class", Tuple.Create(" class=\"", 1188), Tuple.Create("\"", 1211)

#line 39 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Tabs.cshtml"
, Tuple.Create(Tuple.Create("", 1196), Tuple.Create<System.Object, System.Int32>(GetClass(node)

#line default
#line hidden
, 1196), false)
);

WriteLiteralTo(__razor_helper_writer, ">\n                    <a");

WriteAttributeTo(__razor_helper_writer, "href", Tuple.Create(" href=\"", 1236), Tuple.Create("\"", 1252)

#line 40 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Tabs.cshtml"
, Tuple.Create(Tuple.Create("", 1243), Tuple.Create<System.Object, System.Int32>(node.Url

#line default
#line hidden
, 1243), false)
);

WriteAttributeTo(__razor_helper_writer, "target", Tuple.Create(" target=\"", 1253), Tuple.Create("\"", 1278)

#line 40 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Tabs.cshtml"
, Tuple.Create(Tuple.Create("", 1262), Tuple.Create<System.Object, System.Int32>(node.LinkTarget

#line default
#line hidden
, 1262), false)
);

WriteLiteralTo(__razor_helper_writer, ">");


#line 40 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Tabs.cshtml"
                                    WriteTo(__razor_helper_writer, node.Title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</a>\n                </li>\n");


#line 42 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Tabs.cshtml"
            }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        </ul>\n");


#line 44 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Tabs.cshtml"
        

#line default
#line hidden

#line 44 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Tabs.cshtml"
WriteTo(__razor_helper_writer, RenderSubLevelsRecursive(selectedNode.ChildNodes));


#line default
#line hidden

#line 44 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Tabs.cshtml"
                                                          ;
    }


#line default
#line hidden
});

#line 46 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Tabs.cshtml"
}
#line default
#line hidden

#line 49 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Tabs.cshtml"
public System.Web.WebPages.HelperResult GetClass(NodeViewModel node)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 50 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Tabs.cshtml"
 
    if (node.IsCurrentlyOpened)
    {
        

#line default
#line hidden

#line 53 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Tabs.cshtml"
WriteTo(__razor_helper_writer, Html.Raw("active"));


#line default
#line hidden

#line 53 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Tabs.cshtml"
                           ;
    }
    else if (node.HasChildOpen)
    {
        

#line default
#line hidden

#line 57 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Tabs.cshtml"
WriteTo(__razor_helper_writer, Html.Raw("active"));


#line default
#line hidden

#line 57 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Tabs.cshtml"
                           ;
    }


#line default
#line hidden
});

#line 59 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Tabs.cshtml"
}
#line default
#line hidden

        public NavigationView_Tabs()
        {
        }
        public override void Execute()
        {
WriteLiteral("\n");

WriteLiteral("\n\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 260), Tuple.Create("\"", 283)
            
            #line 9 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Tabs.cshtml"
, Tuple.Create(Tuple.Create("", 268), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 268), false)
);

WriteLiteral(">\n    ");

WriteLiteral("\n\n");

WriteLiteral("    ");

            
            #line 12 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Tabs.cshtml"
Write(RenderRootLevelNode(@Model.Nodes));

            
            #line default
            #line hidden
WriteLiteral("\n");

WriteLiteral("    ");

            
            #line 13 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Tabs.cshtml"
Write(RenderSubLevelsRecursive(@Model.Nodes));

            
            #line default
            #line hidden
WriteLiteral("\n</div>\n\n");

WriteLiteral("\n");

WriteLiteral("\n");

WriteLiteral("\n");

WriteLiteral("\n");

WriteLiteral("\n");

        }
    }
}
#pragma warning restore 1591
