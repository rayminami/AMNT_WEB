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

namespace SitefinityWebApp.ResourcePackages.Bootstrap.MVC.Views.ChangePassword
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
    
    #line 4 "..\..\ResourcePackages\Bootstrap\MVC\Views\ChangePassword\ChangePassword.ChangePassword.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 3 "..\..\ResourcePackages\Bootstrap\MVC\Views\ChangePassword\ChangePassword.ChangePassword.cshtml"
    using Telerik.Sitefinity.UI.MVC;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/ResourcePackages/Bootstrap/MVC/Views/ChangePassword/ChangePassword.ChangePasswo" +
        "rd.cshtml")]
    public partial class ChangePassword_ChangePassword : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Identity.Mvc.Models.ChangePassword.ChangePasswordViewModel>
    {
        public ChangePassword_ChangePassword()
        {
        }
        public override void Execute()
        {
WriteLiteral("\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 181), Tuple.Create("\"", 204)
            
            #line 6 "..\..\ResourcePackages\Bootstrap\MVC\Views\ChangePassword\ChangePassword.ChangePassword.cshtml"
, Tuple.Create(Tuple.Create("", 189), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 189), false)
);

WriteLiteral(">\n");

            
            #line 7 "..\..\ResourcePackages\Bootstrap\MVC\Views\ChangePassword\ChangePassword.ChangePassword.cshtml"
    
            
            #line default
            #line hidden
            
            #line 7 "..\..\ResourcePackages\Bootstrap\MVC\Views\ChangePassword\ChangePassword.ChangePassword.cshtml"
     if (Model.PasswordChanged)
    {

            
            #line default
            #line hidden
WriteLiteral("        <h3>");

            
            #line 9 "..\..\ResourcePackages\Bootstrap\MVC\Views\ChangePassword\ChangePassword.ChangePassword.cshtml"
       Write(Html.Resource("ChangePasswordSuccess"));

            
            #line default
            #line hidden
WriteLiteral("</h3>\n");

            
            #line 10 "..\..\ResourcePackages\Bootstrap\MVC\Views\ChangePassword\ChangePassword.ChangePassword.cshtml"
    }
    else
    {

            
            #line default
            #line hidden
WriteLiteral("        <h3>");

            
            #line 13 "..\..\ResourcePackages\Bootstrap\MVC\Views\ChangePassword\ChangePassword.ChangePassword.cshtml"
       Write(Html.Resource("ChangePasswordHeader"));

            
            #line default
            #line hidden
WriteLiteral("</h3>\n");

            
            #line 14 "..\..\ResourcePackages\Bootstrap\MVC\Views\ChangePassword\ChangePassword.ChangePassword.cshtml"
        
		if (!string.IsNullOrEmpty(Model.ExternalProviderName))
        {

            
            #line default
            #line hidden
WriteLiteral("            <div>\n");

WriteLiteral("                ");

            
            #line 18 "..\..\ResourcePackages\Bootstrap\MVC\Views\ChangePassword\ChangePassword.ChangePassword.cshtml"
           Write(string.Format(Html.Resource("ExternalProviderMessage"), Model.ExternalProviderName));

            
            #line default
            #line hidden
WriteLiteral("\n            </div>\n");

            
            #line 20 "..\..\ResourcePackages\Bootstrap\MVC\Views\ChangePassword\ChangePassword.ChangePassword.cshtml"
        }
		else
		{
			using (Html.BeginFormSitefinity("SetChangePassword", "ChangePassword"))
			{
				if (!string.IsNullOrEmpty(Model.Error))
				{


            
            #line default
            #line hidden
WriteLiteral("\t\t\t\t\t<div");

WriteLiteral(" class=\"alert alert-danger\"");

WriteLiteral(">\n");

WriteLiteral("\t\t\t\t\t\t");

            
            #line 29 "..\..\ResourcePackages\Bootstrap\MVC\Views\ChangePassword\ChangePassword.ChangePassword.cshtml"
                   Write(Model.Error);

            
            #line default
            #line hidden
WriteLiteral("\n\t\t\t\t\t</div>\n");

            
            #line 31 "..\..\ResourcePackages\Bootstrap\MVC\Views\ChangePassword\ChangePassword.ChangePassword.cshtml"

				}
		

            
            #line default
            #line hidden
WriteLiteral("\t\t\t\t<div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\n\t\t\t\t\t<label>\n");

WriteLiteral("\t\t\t\t\t\t");

            
            #line 36 "..\..\ResourcePackages\Bootstrap\MVC\Views\ChangePassword\ChangePassword.ChangePassword.cshtml"
                   Write(Html.Resource("ChangePasswordOldPassword"));

            
            #line default
            #line hidden
WriteLiteral("\n\t\t\t\t\t</label>\n");

WriteLiteral("\t\t\t\t   ");

            
            #line 38 "..\..\ResourcePackages\Bootstrap\MVC\Views\ChangePassword\ChangePassword.ChangePassword.cshtml"
              Write(Html.PasswordFor(u => u.OldPassword, new { @class = "form-control" }));

            
            #line default
            #line hidden
WriteLiteral("\n\n\t\t\t\t</div>\n");

WriteLiteral("\t\t\t\t<div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\n\t\t\t\t\t<label>\n");

WriteLiteral("\t\t\t\t\t\t");

            
            #line 43 "..\..\ResourcePackages\Bootstrap\MVC\Views\ChangePassword\ChangePassword.ChangePassword.cshtml"
                   Write(Html.Resource("ChangePasswordNewPassword"));

            
            #line default
            #line hidden
WriteLiteral("\n\t\t\t\t\t</label>\n\n");

WriteLiteral("\t\t\t\t\t");

            
            #line 46 "..\..\ResourcePackages\Bootstrap\MVC\Views\ChangePassword\ChangePassword.ChangePassword.cshtml"
               Write(Html.PasswordFor(u => u.NewPassword, new { @class = "form-control" }));

            
            #line default
            #line hidden
WriteLiteral("\n\n\t\t\t\t</div>\n");

WriteLiteral("\t\t\t\t<div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\n\t\t\t\t\t<label>\n");

WriteLiteral("\t\t\t\t\t\t");

            
            #line 51 "..\..\ResourcePackages\Bootstrap\MVC\Views\ChangePassword\ChangePassword.ChangePassword.cshtml"
                   Write(Html.Resource("ChangePasswordRepeatPassword"));

            
            #line default
            #line hidden
WriteLiteral("\n\t\t\t\t\t</label>\n\n");

WriteLiteral("\t\t\t\t\t");

            
            #line 54 "..\..\ResourcePackages\Bootstrap\MVC\Views\ChangePassword\ChangePassword.ChangePassword.cshtml"
               Write(Html.PasswordFor(u => u.RepeatPassword, new { @class = "form-control" }));

            
            #line default
            #line hidden
WriteLiteral("\n\n\t\t\t\t</div>    \n");

            
            #line 57 "..\..\ResourcePackages\Bootstrap\MVC\Views\ChangePassword\ChangePassword.ChangePassword.cshtml"
				

            
            #line default
            #line hidden
WriteLiteral("\t\t\t   <button");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"btn btn-primary\"");

WriteLiteral(">");

            
            #line 58 "..\..\ResourcePackages\Bootstrap\MVC\Views\ChangePassword\ChangePassword.ChangePassword.cshtml"
                                                        Write(Html.Resource("ChangePasswordSaveButton"));

            
            #line default
            #line hidden
WriteLiteral("</button> \n");

            
            #line 59 "..\..\ResourcePackages\Bootstrap\MVC\Views\ChangePassword\ChangePassword.ChangePassword.cshtml"
			}
		}
    }

            
            #line default
            #line hidden
WriteLiteral("</div>\n\n");

        }
    }
}
#pragma warning restore 1591
