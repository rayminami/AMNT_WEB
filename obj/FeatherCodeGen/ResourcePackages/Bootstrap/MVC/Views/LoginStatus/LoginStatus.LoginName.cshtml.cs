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

namespace SitefinityWebApp.ResourcePackages.Bootstrap.MVC.Views.LoginStatus
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
    
    #line 3 "..\..MVC\Views\LoginStatus\LoginStatus.LoginName.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 4 "..\..MVC\Views\LoginStatus\LoginStatus.LoginName.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/LoginStatus/LoginStatus.LoginName.cshtml")]
    public partial class LoginStatus_LoginName : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Identity.Mvc.Models.LoginStatus.LoginStatusViewModel>
    {
        public LoginStatus_LoginName()
        {
        }
        public override void Execute()
        {
WriteLiteral("\n");

            
            #line 6 "..\..MVC\Views\LoginStatus\LoginStatus.LoginName.cshtml"
Write(Html.Script(ScriptRef.JQuery, "top"));

            
            #line default
            #line hidden
WriteLiteral("\n\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 221), Tuple.Create("\"", 244)
            
            #line 8 "..\..MVC\Views\LoginStatus\LoginStatus.LoginName.cshtml"
, Tuple.Create(Tuple.Create("", 229), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 229), false)
);

WriteLiteral(">\n    <div");

WriteLiteral(" data-sf-role=\"sf-logged-in-view\"");

WriteLiteral(" style=\"display: none\"");

WriteLiteral(">\n        <span>");

            
            #line 10 "..\..MVC\Views\LoginStatus\LoginStatus.LoginName.cshtml"
         Write(Html.Resource("LoggedAs"));

            
            #line default
            #line hidden
WriteLiteral(" </span>\n        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 371), Tuple.Create("\"", 408)
            
            #line 11 "..\..MVC\Views\LoginStatus\LoginStatus.LoginName.cshtml"
, Tuple.Create(Tuple.Create("", 378), Tuple.Create<System.Object, System.Int32>(Model.ProfilePageUrl ?? "#"
            
            #line default
            #line hidden
, 378), false)
);

WriteLiteral(" data-sf-role=\"sf-logged-in-name\"");

WriteLiteral(" class=\"sf-mr-m\"");

WriteLiteral("></a>\n");

WriteLiteral("        ");

            
            #line 12 "..\..MVC\Views\LoginStatus\LoginStatus.LoginName.cshtml"
   Write(Html.ActionLink(Html.Resource("Logout"), "SignOut"));

            
            #line default
            #line hidden
WriteLiteral("\n    </div>\n\n    <div");

WriteLiteral(" data-sf-role=\"sf-logged-out-view\"");

WriteLiteral(" style=\"display: none\"");

WriteLiteral(">\n        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 613), Tuple.Create("\"", 648)
            
            #line 16 "..\..MVC\Views\LoginStatus\LoginStatus.LoginName.cshtml"
, Tuple.Create(Tuple.Create("", 620), Tuple.Create<System.Object, System.Int32>(Model.LoginPageUrl ?? "#"
            
            #line default
            #line hidden
, 620), false)
);

WriteLiteral(" class=\"sf-mr-m\"");

WriteLiteral(">");

            
            #line 16 "..\..MVC\Views\LoginStatus\LoginStatus.LoginName.cshtml"
                                                          Write(Html.Resource("Login"));

            
            #line default
            #line hidden
WriteLiteral("</a>\n        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 704), Tuple.Create("\"", 746)
            
            #line 17 "..\..MVC\Views\LoginStatus\LoginStatus.LoginName.cshtml"
, Tuple.Create(Tuple.Create("", 711), Tuple.Create<System.Object, System.Int32>(Model.RegistrationPageUrl ?? "#"
            
            #line default
            #line hidden
, 711), false)
);

WriteLiteral(">");

            
            #line 17 "..\..MVC\Views\LoginStatus\LoginStatus.LoginName.cshtml"
                                                 Write(Html.Resource("RegisterNow"));

            
            #line default
            #line hidden
WriteLiteral("</a>\n    </div>\n</div>\n\n<input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"sf-status-json-endpoint-url\"");

WriteAttribute("value", Tuple.Create(" value=\"", 864), Tuple.Create("\"", 895)
            
            #line 21 "..\..MVC\Views\LoginStatus\LoginStatus.LoginName.cshtml"
, Tuple.Create(Tuple.Create("", 872), Tuple.Create<System.Object, System.Int32>(Model.StatusServiceUrl
            
            #line default
            #line hidden
, 872), false)
);

WriteLiteral("/>\n<input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"sf-logout-redirect-url\"");

WriteAttribute("value", Tuple.Create(" value=\"", 957), Tuple.Create("\"", 985)
            
            #line 22 "..\..MVC\Views\LoginStatus\LoginStatus.LoginName.cshtml"
, Tuple.Create(Tuple.Create("", 965), Tuple.Create<System.Object, System.Int32>(Model.LogoutPageUrl
            
            #line default
            #line hidden
, 965), false)
);

WriteLiteral("/>\n<input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"sf-is-design-mode-value\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1048), Tuple.Create("\"", 1088)
            
            #line 23 "..\..MVC\Views\LoginStatus\LoginStatus.LoginName.cshtml"
, Tuple.Create(Tuple.Create("", 1056), Tuple.Create<System.Object, System.Int32>(ViewBag.IsDesignMode.ToString()
            
            #line default
            #line hidden
, 1056), false)
);

WriteLiteral(" />\n<input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"sf-allow-windows-sts-login\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1155), Tuple.Create("\"", 1201)
            
            #line 24 "..\..MVC\Views\LoginStatus\LoginStatus.LoginName.cshtml"
, Tuple.Create(Tuple.Create("", 1163), Tuple.Create<System.Object, System.Int32>(Model.AllowWindowsStsLogin.ToString()
            
            #line default
            #line hidden
, 1163), false)
);

WriteLiteral(" />\n\n");

            
            #line 26 "..\..MVC\Views\LoginStatus\LoginStatus.LoginName.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/LoginStatus/login-status.js"), "bottom"));

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
