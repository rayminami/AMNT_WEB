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

namespace SitefinityWebApp.ResourcePackages.Bootstrap.MVC.Views.EventScheduler
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
    
    #line 3 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
    using Telerik.Sitefinity.Frontend.Events.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 4 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 5 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
    using Telerik.Sitefinity.Web.DataResolving;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/EventScheduler/Detail.EventDetails.cshtml")]
    public partial class Detail_EventDetails : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Mvc.Models.ContentDetailsViewModel>
    {
        public Detail_EventDetails()
        {
        }
        public override void Execute()
        {
WriteLiteral("\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 224), Tuple.Create("\"", 247)
            
            #line 7 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
, Tuple.Create(Tuple.Create("", 232), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 232), false)
);

WriteLiteral(" ");

            
            #line 7 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
                        Write(Html.InlineEditingAttributes(Model.ProviderName, Model.ContentType.FullName, (Guid)Model.Item.Fields.Id));

            
            #line default
            #line hidden
WriteLiteral(">\n    <h3>\n        <span ");

            
            #line 9 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
         Write(Html.InlineEditingFieldAttributes("Title", "ShortText"));

            
            #line default
            #line hidden
WriteLiteral(">");

            
            #line 9 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
                                                                  Write(Model.Item.Fields.Title);

            
            #line default
            #line hidden
WriteLiteral("</span>\n    </h3>\n    <span");

WriteAttribute("style", Tuple.Create(" style=\"", 487), Tuple.Create("\"", 540)
, Tuple.Create(Tuple.Create("", 495), Tuple.Create("background:", 495), true)
            
            #line 11 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
, Tuple.Create(Tuple.Create(" ", 506), Tuple.Create<System.Object, System.Int32>(Model.Item.EventCalendarColour()
            
            #line default
            #line hidden
, 507), false)
);

WriteLiteral("></span>\n\n");

            
            #line 13 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
    
            
            #line default
            #line hidden
            
            #line 13 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
     if (!string.IsNullOrEmpty(Model.Item.EventDates())) 
	{

            
            #line default
            #line hidden
WriteLiteral("    <p>\n        <time>");

            
            #line 16 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
         Write(Model.Item.EventDates());

            
            #line default
            #line hidden
WriteLiteral("</time>\n    </p>\n");

            
            #line 18 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("    \n");

            
            #line 20 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
    
            
            #line default
            #line hidden
            
            #line 20 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
     if (!string.IsNullOrEmpty(Model.Item.Fields.City) || !string.IsNullOrEmpty(Model.Item.Fields.Country))
    {
            
            #line default
            #line hidden
WriteLiteral("<address>\n\n");

            
            #line 23 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
        
            
            #line default
            #line hidden
            
            #line 23 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
         if (!string.IsNullOrEmpty(Model.Item.Fields.City) && !string.IsNullOrEmpty(Model.Item.Fields.Country))
        {
            
            
            #line default
            #line hidden
            
            #line 25 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
       Write(Model.Item.Fields.City);

            
            #line default
            #line hidden
WriteLiteral(" <span>,</span> ");

            
            #line 25 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
                                                   
            
            #line default
            #line hidden
            
            #line 25 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
                                              Write(Model.Item.Fields.Country);

            
            #line default
            #line hidden
            
            #line 25 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
                                                                             

            
            #line default
            #line hidden
WriteLiteral("            <br>\n");

            
            #line 27 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
        }
        else
        {
            
            
            #line default
            #line hidden
            
            #line 30 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
        Write(string.IsNullOrEmpty(Model.Item.Fields.City) ? Model.Item.Fields.Country : Model.Item.Fields.City);

            
            #line default
            #line hidden
            
            #line 30 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
                                                                                                                

            
            #line default
            #line hidden
WriteLiteral("             <br>\n");

            
            #line 32 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("\n");

            
            #line 34 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
        
            
            #line default
            #line hidden
            
            #line 34 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
         if (!string.IsNullOrEmpty(Model.Item.Fields.Street))
        {
            
            
            #line default
            #line hidden
            
            #line 36 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
       Write(Model.Item.Fields.Street);

            
            #line default
            #line hidden
            
            #line 36 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
                                     
        }

            
            #line default
            #line hidden
WriteLiteral("    </address>\n");

            
            #line 39 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("    \n    <div>\n");

            
            #line 42 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
        
            
            #line default
            #line hidden
            
            #line 42 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
         if (!string.IsNullOrEmpty(Model.Item.Fields.ContactName))
        {
            
            
            #line default
            #line hidden
            
            #line 44 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
       Write(Model.Item.Fields.ContactName);

            
            #line default
            #line hidden
            
            #line 44 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
                                          

            
            #line default
            #line hidden
WriteLiteral("            <br>\n");

            
            #line 46 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("\n");

            
            #line 48 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
        
            
            #line default
            #line hidden
            
            #line 48 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
         if (!string.IsNullOrEmpty(Model.Item.Fields.ContactPhone))
        {
            
            
            #line default
            #line hidden
            
            #line 50 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
       Write(Model.Item.Fields.ContactPhone);

            
            #line default
            #line hidden
            
            #line 50 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
                                           

            
            #line default
            #line hidden
WriteLiteral("            <br>\n");

            
            #line 52 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("\n");

            
            #line 54 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
        
            
            #line default
            #line hidden
            
            #line 54 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
         if (!string.IsNullOrEmpty(Model.Item.Fields.ContactCell))
        {
            
            
            #line default
            #line hidden
            
            #line 56 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
       Write(Model.Item.Fields.ContactCell);

            
            #line default
            #line hidden
            
            #line 56 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
                                          

            
            #line default
            #line hidden
WriteLiteral("            <br>\n");

            
            #line 58 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("            \n");

            
            #line 60 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
        
            
            #line default
            #line hidden
            
            #line 60 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
         if (!string.IsNullOrEmpty(Model.Item.Fields.ContactEmail))
        {

            
            #line default
            #line hidden
WriteLiteral("            <address><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1917), Tuple.Create("\"", 1964)
, Tuple.Create(Tuple.Create("", 1924), Tuple.Create("mailto:", 1924), true)
            
            #line 62 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
, Tuple.Create(Tuple.Create("", 1931), Tuple.Create<System.Object, System.Int32>(Model.Item.Fields.ContactEmail
            
            #line default
            #line hidden
, 1931), false)
);

WriteLiteral(" target=\"_blank\"");

WriteLiteral(">");

            
            #line 62 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
                                                                                   Write(Model.Item.Fields.ContactEmail);

            
            #line default
            #line hidden
WriteLiteral("</a></address>\n");

            
            #line 63 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("\n");

            
            #line 65 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
        
            
            #line default
            #line hidden
            
            #line 65 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
         if (!string.IsNullOrEmpty(Model.Item.Fields.ContactWeb))
        {

            
            #line default
            #line hidden
WriteLiteral("            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 2129), Tuple.Create("\"", 2167)
            
            #line 67 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
, Tuple.Create(Tuple.Create("", 2136), Tuple.Create<System.Object, System.Int32>(Model.Item.Fields.ContactWeb
            
            #line default
            #line hidden
, 2136), false)
);

WriteLiteral(" target=\"_blank\"");

WriteLiteral(">");

            
            #line 67 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
                                                                 Write(Model.Item.Fields.ContactWeb);

            
            #line default
            #line hidden
WriteLiteral("</a>\n");

            
            #line 68 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </div>\n\n");

            
            #line 71 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
    
            
            #line default
            #line hidden
            
            #line 71 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
     if (!string.IsNullOrEmpty(Model.Item.Fields.Location))
    {        

            
            #line default
            #line hidden
WriteLiteral("        <p>\n\t\t\t");

WriteLiteral("\n");

WriteLiteral("\t\t\t");

            
            #line 75 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
       Write(Model.Item.Fields.Location);

            
            #line default
            #line hidden
WriteLiteral("\n\t\t</p>\n");

            
            #line 77 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("\n");

            
            #line 79 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
    
            
            #line default
            #line hidden
            
            #line 79 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
     if (!string.IsNullOrEmpty(Model.Item.Fields.Description))
    {        

            
            #line default
            #line hidden
WriteLiteral("        <p>\n");

WriteLiteral("            ");

            
            #line 82 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
       Write(Model.Item.Fields.Description);

            
            #line default
            #line hidden
WriteLiteral("\n        </p>\n");

            
            #line 84 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("\n    <p>\n");

WriteLiteral("        ");

            
            #line 87 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
   Write(Html.CommentsCount(string.Empty, Model.Item.DataItem));

            
            #line default
            #line hidden
WriteLiteral("\n\t</p>\n    \n");

            
            #line 90 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
    
            
            #line default
            #line hidden
            
            #line 90 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
     if (ViewBag.AllowCalendarExport)
    {

            
            #line default
            #line hidden
WriteLiteral("        <div>\n            <span>");

            
            #line 93 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
             Write(Html.Resource("AddTo"));

            
            #line default
            #line hidden
WriteLiteral("</span>\n            <ul>\n                <li><a");

WriteAttribute("href", Tuple.Create(" href=\"", 2780), Tuple.Create("\"", 2819)
            
            #line 95 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
, Tuple.Create(Tuple.Create("", 2787), Tuple.Create<System.Object, System.Int32>(Model.Item.GenerateOutlookUrl()
            
            #line default
            #line hidden
, 2787), false)
);

WriteLiteral(" target=\"_blank\"");

WriteLiteral(">");

            
            #line 95 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
                                                                          Write(Html.Resource("OutlookEventExporterTitle"));

            
            #line default
            #line hidden
WriteLiteral("</a>,</li>\n                <li><a");

WriteAttribute("href", Tuple.Create(" href=\"", 2913), Tuple.Create("\"", 2949)
            
            #line 96 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
, Tuple.Create(Tuple.Create("", 2920), Tuple.Create<System.Object, System.Int32>(Model.Item.GenerateICalUrl()
            
            #line default
            #line hidden
, 2920), false)
);

WriteLiteral(" target=\"_blank\"");

WriteLiteral(">");

            
            #line 96 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
                                                                       Write(Html.Resource("ICalEventExporterTitle"));

            
            #line default
            #line hidden
WriteLiteral("</a>,</li>\n                <li><a");

WriteAttribute("href", Tuple.Create(" href=\"", 3040), Tuple.Create("\"", 3078)
            
            #line 97 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
, Tuple.Create(Tuple.Create("", 3047), Tuple.Create<System.Object, System.Int32>(Model.Item.GenerateGoogleUrl()
            
            #line default
            #line hidden
, 3047), false)
);

WriteLiteral(" target=\"_blank\"");

WriteLiteral(">");

            
            #line 97 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
                                                                         Write(Html.Resource("GoogleEventExporterTitle"));

            
            #line default
            #line hidden
WriteLiteral("</a></li>\n            </ul>\n        </div>\n");

            
            #line 100 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("\n");

            
            #line 102 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
    
            
            #line default
            #line hidden
            
            #line 102 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
     if (!string.IsNullOrEmpty(Model.Item.Fields.Summary))
    {        

            
            #line default
            #line hidden
WriteLiteral("        <p ");

            
            #line 104 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
      Write(Html.InlineEditingFieldAttributes("Summary", "LongText"));

            
            #line default
            #line hidden
WriteLiteral(">");

            
            #line 104 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
                                                                Write(Html.Raw(Model.Item.Fields.Summary));

            
            #line default
            #line hidden
WriteLiteral("</p>\n");

            
            #line 105 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("\n");

            
            #line 107 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
    
            
            #line default
            #line hidden
            
            #line 107 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
     if (!string.IsNullOrEmpty(Model.Item.Fields.Content))
    {        

            
            #line default
            #line hidden
WriteLiteral("        <p ");

            
            #line 109 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
      Write(Html.InlineEditingFieldAttributes("Content", "LongText"));

            
            #line default
            #line hidden
WriteLiteral(">");

            
            #line 109 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
                                                                Write(Html.Raw(Model.Item.Fields.Content));

            
            #line default
            #line hidden
WriteLiteral("</p>\n");

            
            #line 110 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("    \n");

            
            #line 112 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
    
            
            #line default
            #line hidden
            
            #line 112 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
              
        if (Model.EnableSocialSharing)
        {
            var item = Model.Item.DataItem as Telerik.Sitefinity.Model.IHasTitle;
            
            
            #line default
            #line hidden
            
            #line 116 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
       Write(Html.SocialShareOptions(item));

            
            #line default
            #line hidden
            
            #line 116 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
                                          ;
        }
    
            
            #line default
            #line hidden
WriteLiteral("\n\n");

WriteLiteral("    ");

            
            #line 120 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
Write(Html.CommentsList(Model.Item.DataItem));

            
            #line default
            #line hidden
WriteLiteral("\n\n</div>\n");

        }
    }
}
#pragma warning restore 1591
