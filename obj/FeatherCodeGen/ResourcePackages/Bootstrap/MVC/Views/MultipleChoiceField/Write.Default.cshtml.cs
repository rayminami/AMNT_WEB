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

namespace SitefinityWebApp.ResourcePackages.Bootstrap.MVC.Views.MultipleChoiceField
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
    
    #line 4 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
    using Telerik.Sitefinity.Frontend.Forms.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 5 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 6 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    #line 3 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
    using Telerik.Sitefinity.UI.MVC;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/MultipleChoiceField/Write.Default.cshtml")]
    public partial class Write_Default : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Forms.Mvc.Models.Fields.MultipleChoiceField.MultipleChoiceFieldViewModel>
    {
        public Write_Default()
        {
        }
        public override void Execute()
        {
WriteLiteral("\n");

            
            #line 8 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
Write(Html.Script(ScriptRef.JQuery, "top", false));

            
            #line default
            #line hidden
WriteLiteral("\n\n");

            
            #line 10 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
  
    var fieldName = string.IsNullOrEmpty(Model.MetaField.FieldName) ? "multiple-choice-field-name" : Model.MetaField.FieldName;
    var requiredAttributes = MvcHtmlString.Create(Model.ValidationAttributes);

            
            #line default
            #line hidden
WriteLiteral("\n\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 550), Tuple.Create("\"", 584)
            
            #line 15 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 558), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 558), false)
, Tuple.Create(Tuple.Create(" ", 573), Tuple.Create("form-group", 574), true)
);

WriteLiteral(" data-sf-role=\"multiple-choice-field-container\"");

WriteLiteral(">\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"violation-messages\"");

WriteAttribute("value", Tuple.Create(" value=\'", 692), Tuple.Create("\'", 748)
, Tuple.Create(Tuple.Create("", 700), Tuple.Create("{", 700), true)
, Tuple.Create(Tuple.Create(" ", 701), Tuple.Create("\"required\":", 702), true)
, Tuple.Create(Tuple.Create(" ", 713), Tuple.Create("\"", 714), true)
            
            #line 16 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
  , Tuple.Create(Tuple.Create("", 715), Tuple.Create<System.Object, System.Int32>(Model.RequiredViolationMessage
            
            #line default
            #line hidden
, 715), false)
, Tuple.Create(Tuple.Create("", 746), Tuple.Create("\"}", 746), true)
);

WriteLiteral(" />\n\n        <strong>");

            
            #line 18 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
           Write(Model.MetaField.Title);

            
            #line default
            #line hidden
WriteLiteral("</strong>\n");

            
            #line 19 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
        
            
            #line default
            #line hidden
            
            #line 19 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
         if (!string.IsNullOrEmpty(Model.MetaField.Description)) 
        {

            
            #line default
            #line hidden
WriteLiteral("           <p");

WriteLiteral(" class=\"text-muted\"");

WriteLiteral(">");

            
            #line 21 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
                            Write(Model.MetaField.Description);

            
            #line default
            #line hidden
WriteLiteral("</p>\n");

            
            #line 22 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("        ");

            
            #line 23 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
         foreach (var choice in Model.Choices)
        {
            string value = !string.IsNullOrEmpty(Model.Value as string) ? Model.Value as string : string.Empty;
            bool isSelected = (!string.IsNullOrEmpty(value) && choice == value) ||
                                (string.IsNullOrEmpty(value) && !Model.IsRequired && choice == Model.MetaField.DefaultValue as string);

            var selctedAttributes = isSelected ? "checked" : string.Empty;

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"radio\"");

WriteLiteral(">\n                <label>\n                  <input");

WriteLiteral(" type=\"radio\"");

WriteAttribute("name", Tuple.Create(" name=\"", 1515), Tuple.Create("\"", 1532)
            
            #line 32 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 1522), Tuple.Create<System.Object, System.Int32>(fieldName
            
            #line default
            #line hidden
, 1522), false)
);

WriteAttribute("value", Tuple.Create(" value=\"", 1533), Tuple.Create("\"", 1548)
            
            #line 32 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 1541), Tuple.Create<System.Object, System.Int32>(choice
            
            #line default
            #line hidden
, 1541), false)
);

WriteLiteral(" data-sf-role=\"multiple-choice-field-input\"");

WriteLiteral(" ");

            
            #line 32 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
                                                                                                              Write(selctedAttributes);

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 32 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
                                                                                                                                 Write(requiredAttributes);

            
            #line default
            #line hidden
WriteLiteral(" />\n");

WriteLiteral("                    ");

            
            #line 33 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
               Write(choice);

            
            #line default
            #line hidden
WriteLiteral("\n                </label>\n            </div>\n");

            
            #line 36 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("\n");

            
            #line 38 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
        
            
            #line default
            #line hidden
            
            #line 38 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
         if(Model.HasOtherChoice)
        {

            
            #line default
            #line hidden
WriteLiteral("           <div");

WriteLiteral(" class=\"radio\"");

WriteLiteral(">\n               <label>\n                    <input");

WriteLiteral(" type=\"radio\"");

WriteAttribute("name", Tuple.Create(" name=\"", 1855), Tuple.Create("\"", 1872)
            
            #line 42 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 1862), Tuple.Create<System.Object, System.Int32>(fieldName
            
            #line default
            #line hidden
, 1862), false)
);

WriteLiteral(" data-sf-multiple-choice-role=\"other-choice-radio\"");

WriteLiteral(" data-sf-role=\"multiple-choice-field-input\"");

WriteLiteral("/>\n");

WriteLiteral("                    ");

            
            #line 43 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
               Write(Html.Resource("Other"));

            
            #line default
            #line hidden
WriteLiteral("\n               </label>\n               <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-multiple-choice-role=\"other-choice-text\"");

WriteLiteral(" />\n           </div>\n");

            
            #line 47 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
          
        }

            
            #line default
            #line hidden
WriteLiteral("\n\n</div>\n\n");

            
            #line 53 "..\..MVC\Views\MultipleChoiceField\Write.Default.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/MultipleChoiceField/multiple-choice-field.js"), "bottom", false));

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
