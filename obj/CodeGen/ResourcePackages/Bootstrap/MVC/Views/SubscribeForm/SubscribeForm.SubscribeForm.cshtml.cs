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

namespace SitefinityWebApp.ResourcePackages.Bootstrap.MVC.Views.SubscribeForm
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
    
    #line 4 "..\..\ResourcePackages\Bootstrap\MVC\Views\SubscribeForm\SubscribeForm.SubscribeForm.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 5 "..\..\ResourcePackages\Bootstrap\MVC\Views\SubscribeForm\SubscribeForm.SubscribeForm.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    #line 6 "..\..\ResourcePackages\Bootstrap\MVC\Views\SubscribeForm\SubscribeForm.SubscribeForm.cshtml"
    using Telerik.Sitefinity.Services;
    
    #line default
    #line hidden
    
    #line 3 "..\..\ResourcePackages\Bootstrap\MVC\Views\SubscribeForm\SubscribeForm.SubscribeForm.cshtml"
    using Telerik.Sitefinity.UI.MVC;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/ResourcePackages/Bootstrap/MVC/Views/SubscribeForm/SubscribeForm.SubscribeForm." +
        "cshtml")]
    public partial class SubscribeForm_SubscribeForm : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.EmailCampaigns.Mvc.Models.SubscribeFormViewModel>
    {
        public SubscribeForm_SubscribeForm()
        {
        }
        public override void Execute()
        {
WriteLiteral("\n");

WriteLiteral("\n");

            
            #line 9 "..\..\ResourcePackages\Bootstrap\MVC\Views\SubscribeForm\SubscribeForm.SubscribeForm.cshtml"
Write(Html.Script(ScriptRef.JQuery, "top", false));

            
            #line default
            #line hidden
WriteLiteral("\n");

            
            #line 10 "..\..\ResourcePackages\Bootstrap\MVC\Views\SubscribeForm\SubscribeForm.SubscribeForm.cshtml"
Write(Html.Script("//ajax.aspnetcdn.com/ajax/jquery.validate/1.8.1/jquery.validate.js", "top", false));

            
            #line default
            #line hidden
WriteLiteral("\n");

            
            #line 11 "..\..\ResourcePackages\Bootstrap\MVC\Views\SubscribeForm\SubscribeForm.SubscribeForm.cshtml"
Write(Html.Script("//ajax.aspnetcdn.com/ajax/mvc/4.0/jquery.validate.unobtrusive.min.js", "top", false));

            
            #line default
            #line hidden
WriteLiteral("\n\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 523), Tuple.Create("\"", 546)
            
            #line 13 "..\..\ResourcePackages\Bootstrap\MVC\Views\SubscribeForm\SubscribeForm.SubscribeForm.cshtml"
, Tuple.Create(Tuple.Create("", 531), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 531), false)
);

WriteLiteral(">\n");

            
            #line 14 "..\..\ResourcePackages\Bootstrap\MVC\Views\SubscribeForm\SubscribeForm.SubscribeForm.cshtml"
	
            
            #line default
            #line hidden
            
            #line 14 "..\..\ResourcePackages\Bootstrap\MVC\Views\SubscribeForm\SubscribeForm.SubscribeForm.cshtml"
     using (Html.BeginFormSitefinity())
	{

            
            #line default
            #line hidden
WriteLiteral("\t\t<h3>");

            
            #line 16 "..\..\ResourcePackages\Bootstrap\MVC\Views\SubscribeForm\SubscribeForm.SubscribeForm.cshtml"
       Write(Html.Resource("Subscribe"));

            
            #line default
            #line hidden
WriteLiteral("</h3>\n");

            
            #line 17 "..\..\ResourcePackages\Bootstrap\MVC\Views\SubscribeForm\SubscribeForm.SubscribeForm.cshtml"
	

            
            #line default
            #line hidden
WriteLiteral("\t\t<p");

WriteLiteral(" class=\"text-muted\"");

WriteLiteral(">\n");

WriteLiteral("\t\t\t");

            
            #line 19 "..\..\ResourcePackages\Bootstrap\MVC\Views\SubscribeForm\SubscribeForm.SubscribeForm.cshtml"
       Write(Html.Resource("SubscribeMail"));

            
            #line default
            #line hidden
WriteLiteral("\n\t\t</p>\n");

            
            #line 21 "..\..\ResourcePackages\Bootstrap\MVC\Views\SubscribeForm\SubscribeForm.SubscribeForm.cshtml"
	
		if (ViewBag.IsSucceeded == true)
		{

            
            #line default
            #line hidden
WriteLiteral("\t\t\t<div");

WriteLiteral(" class=\"alert alert-success\"");

WriteLiteral(">\n");

WriteLiteral("\t\t\t\t");

            
            #line 25 "..\..\ResourcePackages\Bootstrap\MVC\Views\SubscribeForm\SubscribeForm.SubscribeForm.cshtml"
           Write(Html.Resource("ThankYou"));

            
            #line default
            #line hidden
WriteLiteral(". ");

            
            #line 25 "..\..\ResourcePackages\Bootstrap\MVC\Views\SubscribeForm\SubscribeForm.SubscribeForm.cshtml"
                                       Write(Html.Resource("ThankYouMessage"));

            
            #line default
            #line hidden
WriteLiteral(" (");

            
            #line 25 "..\..\ResourcePackages\Bootstrap\MVC\Views\SubscribeForm\SubscribeForm.SubscribeForm.cshtml"
                                                                          Write(ViewBag.Email);

            
            #line default
            #line hidden
WriteLiteral(")\n\t\t\t</div>\n");

            
            #line 27 "..\..\ResourcePackages\Bootstrap\MVC\Views\SubscribeForm\SubscribeForm.SubscribeForm.cshtml"
		}
	
		
            
            #line default
            #line hidden
            
            #line 29 "..\..\ResourcePackages\Bootstrap\MVC\Views\SubscribeForm\SubscribeForm.SubscribeForm.cshtml"
   Write(Html.ValidationSummary(true));

            
            #line default
            #line hidden
            
            #line 29 "..\..\ResourcePackages\Bootstrap\MVC\Views\SubscribeForm\SubscribeForm.SubscribeForm.cshtml"
                                     
		 if(!string.IsNullOrEmpty(ViewBag.Error))
		{

            
            #line default
            #line hidden
WriteLiteral("\t\t\t<div");

WriteLiteral(" class=\"alert alert-warning\"");

WriteLiteral(">\n");

WriteLiteral("\t\t\t\t");

            
            #line 33 "..\..\ResourcePackages\Bootstrap\MVC\Views\SubscribeForm\SubscribeForm.SubscribeForm.cshtml"
           Write(ViewBag.Error);

            
            #line default
            #line hidden
WriteLiteral("\n\t\t\t</div>\n");

            
            #line 35 "..\..\ResourcePackages\Bootstrap\MVC\Views\SubscribeForm\SubscribeForm.SubscribeForm.cshtml"
		}
	
	
            
            #line default
            #line hidden
            
            #line 56 "..\..\ResourcePackages\Bootstrap\MVC\Views\SubscribeForm\SubscribeForm.SubscribeForm.cshtml"
                


            
            #line default
            #line hidden
WriteLiteral("\t<div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\n\n\t\t<label>\n");

WriteLiteral("\t\t   ");

            
            #line 61 "..\..\ResourcePackages\Bootstrap\MVC\Views\SubscribeForm\SubscribeForm.SubscribeForm.cshtml"
      Write(Html.Resource("Email"));

            
            #line default
            #line hidden
WriteLiteral("\n\t\t</label>\n\n\t\t<div");

WriteLiteral(" class=\"form-inline\"");

WriteLiteral(">\n\t\t   \n");

WriteLiteral("\t\t\t");

            
            #line 66 "..\..\ResourcePackages\Bootstrap\MVC\Views\SubscribeForm\SubscribeForm.SubscribeForm.cshtml"
       Write(Html.TextBoxFor(m => m.Email, new { @class = "form-control", type = "email" }));

            
            #line default
            #line hidden
WriteLiteral("\n\n\t\t\t<button");

WriteLiteral(" class=\"btn btn-primary\"");

WriteLiteral(" type=\"submit\"");

WriteLiteral(">");

            
            #line 68 "..\..\ResourcePackages\Bootstrap\MVC\Views\SubscribeForm\SubscribeForm.SubscribeForm.cshtml"
                                                     Write(Html.Resource("ButtonSubscribe"));

            
            #line default
            #line hidden
WriteLiteral("</button>\n\t\t\t\n\t\t</div>\n\n");

            
            #line 72 "..\..\ResourcePackages\Bootstrap\MVC\Views\SubscribeForm\SubscribeForm.SubscribeForm.cshtml"
		
            
            #line default
            #line hidden
            
            #line 72 "..\..\ResourcePackages\Bootstrap\MVC\Views\SubscribeForm\SubscribeForm.SubscribeForm.cshtml"
         if (Html.ValidationMessageFor(m => m.Email) != null)
		{

            
            #line default
            #line hidden
WriteLiteral("\t\t\t<div");

WriteLiteral(" class=\"has-error\"");

WriteLiteral(">\n\t\t\t\t<span");

WriteLiteral(" class=\"help-block\"");

WriteLiteral(">");

            
            #line 75 "..\..\ResourcePackages\Bootstrap\MVC\Views\SubscribeForm\SubscribeForm.SubscribeForm.cshtml"
                                    Write(Html.ValidationMessageFor(u => u.Email));

            
            #line default
            #line hidden
WriteLiteral("</span>\n\t\t\t</div>\n");

            
            #line 77 "..\..\ResourcePackages\Bootstrap\MVC\Views\SubscribeForm\SubscribeForm.SubscribeForm.cshtml"
		}

            
            #line default
            #line hidden
WriteLiteral("\n\t</div>\n");

            
            #line 80 "..\..\ResourcePackages\Bootstrap\MVC\Views\SubscribeForm\SubscribeForm.SubscribeForm.cshtml"

	}

            
            #line default
            #line hidden
WriteLiteral("</div>\n");

        }
    }
}
#pragma warning restore 1591
