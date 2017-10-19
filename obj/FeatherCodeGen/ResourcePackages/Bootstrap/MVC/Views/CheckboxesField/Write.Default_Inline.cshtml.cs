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

namespace SitefinityWebApp.ResourcePackages.Bootstrap.MVC.Views.CheckboxesField
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
    
    #line 4 "..\..MVC\Views\CheckboxesField\Write.Default_Inline.cshtml"
    using Telerik.Sitefinity.Frontend.Forms.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 5 "..\..MVC\Views\CheckboxesField\Write.Default_Inline.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 6 "..\..MVC\Views\CheckboxesField\Write.Default_Inline.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    #line 3 "..\..MVC\Views\CheckboxesField\Write.Default_Inline.cshtml"
    using Telerik.Sitefinity.UI.MVC;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/CheckboxesField/Write.Default_Inline.cshtml")]
    public partial class Write_Default_Inline : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Forms.Mvc.Models.Fields.CheckboxesField.CheckboxesFieldViewModel>
    {
        public Write_Default_Inline()
        {
        }
        public override void Execute()
        {
WriteLiteral("\n");

            
            #line 8 "..\..MVC\Views\CheckboxesField\Write.Default_Inline.cshtml"
Write(Html.Script(ScriptRef.JQuery, "top", false));

            
            #line default
            #line hidden
WriteLiteral("\n\n");

            
            #line 10 "..\..MVC\Views\CheckboxesField\Write.Default_Inline.cshtml"
  
    var fieldName = Model.MetaField.FieldName;
    var requiredAttributes = MvcHtmlString.Create(Model.ValidationAttributes);

            
            #line default
            #line hidden
WriteLiteral("\n\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 461), Tuple.Create("\"", 495)
            
            #line 15 "..\..MVC\Views\CheckboxesField\Write.Default_Inline.cshtml"
, Tuple.Create(Tuple.Create("", 469), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 469), false)
, Tuple.Create(Tuple.Create(" ", 484), Tuple.Create("form-group", 485), true)
);

WriteLiteral(" data-sf-role=\"checkboxes-field-container\"");

WriteLiteral(">\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"violation-messages\"");

WriteAttribute("value", Tuple.Create(" value=\'", 598), Tuple.Create("\'", 654)
, Tuple.Create(Tuple.Create("", 606), Tuple.Create("{", 606), true)
, Tuple.Create(Tuple.Create(" ", 607), Tuple.Create("\"required\":", 608), true)
, Tuple.Create(Tuple.Create(" ", 619), Tuple.Create("\"", 620), true)
            
            #line 16 "..\..MVC\Views\CheckboxesField\Write.Default_Inline.cshtml"
  , Tuple.Create(Tuple.Create("", 621), Tuple.Create<System.Object, System.Int32>(Model.RequiredViolationMessage
            
            #line default
            #line hidden
, 621), false)
, Tuple.Create(Tuple.Create("", 652), Tuple.Create("\"}", 652), true)
);

WriteLiteral(" />\n\t<input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"required-validator\"");

WriteAttribute("value", Tuple.Create(" value=\'", 714), Tuple.Create("\'", 750)
            
            #line 17 "..\..MVC\Views\CheckboxesField\Write.Default_Inline.cshtml"
, Tuple.Create(Tuple.Create("", 722), Tuple.Create<System.Object, System.Int32>(Model.IsRequired.ToString()
            
            #line default
            #line hidden
, 722), false)
);

WriteLiteral(" />\n\t\n       <strong> ");

            
            #line 19 "..\..MVC\Views\CheckboxesField\Write.Default_Inline.cshtml"
           Write(Model.MetaField.Title);

            
            #line default
            #line hidden
WriteLiteral("</strong>\n");

            
            #line 20 "..\..MVC\Views\CheckboxesField\Write.Default_Inline.cshtml"
         
            
            #line default
            #line hidden
            
            #line 20 "..\..MVC\Views\CheckboxesField\Write.Default_Inline.cshtml"
          if (!string.IsNullOrEmpty(Model.MetaField.Description)) 
         {

            
            #line default
            #line hidden
WriteLiteral("                <p");

WriteLiteral(" class=\"text-muted\"");

WriteLiteral(">");

            
            #line 22 "..\..MVC\Views\CheckboxesField\Write.Default_Inline.cshtml"
                                 Write(Model.MetaField.Description);

            
            #line default
            #line hidden
WriteLiteral("</p>\n");

            
            #line 23 "..\..MVC\Views\CheckboxesField\Write.Default_Inline.cshtml"
         }

            
            #line default
            #line hidden
WriteLiteral("        \n");

            
            #line 25 "..\..MVC\Views\CheckboxesField\Write.Default_Inline.cshtml"
        
            
            #line default
            #line hidden
            
            #line 25 "..\..MVC\Views\CheckboxesField\Write.Default_Inline.cshtml"
         foreach (var choice in Model.Choices)
        {
            string value = !string.IsNullOrEmpty(Model.Value as string) ? Model.Value as string : string.Empty;
            string selectedValue = !string.IsNullOrEmpty(value) ? value : Model.MetaField.DefaultValue;
            var selctedAttributes = !string.IsNullOrEmpty(selectedValue) && selectedValue.Contains(choice as string) ? "checked" : string.Empty;

            
            #line default
            #line hidden
WriteLiteral("            <label");

WriteLiteral(" class=\"checkbox-inline\"");

WriteLiteral(">\n                <input");

WriteLiteral(" type=\"checkbox\"");

WriteAttribute("name", Tuple.Create(" name=\"", 1477), Tuple.Create("\"", 1494)
            
            #line 31 "..\..MVC\Views\CheckboxesField\Write.Default_Inline.cshtml"
, Tuple.Create(Tuple.Create("", 1484), Tuple.Create<System.Object, System.Int32>(fieldName
            
            #line default
            #line hidden
, 1484), false)
);

WriteAttribute("value", Tuple.Create(" value=\"", 1495), Tuple.Create("\"", 1510)
            
            #line 31 "..\..MVC\Views\CheckboxesField\Write.Default_Inline.cshtml"
, Tuple.Create(Tuple.Create("", 1503), Tuple.Create<System.Object, System.Int32>(choice
            
            #line default
            #line hidden
, 1503), false)
);

WriteLiteral(" data-sf-role=\"checkboxes-field-input\"");

WriteLiteral(" ");

            
            #line 31 "..\..MVC\Views\CheckboxesField\Write.Default_Inline.cshtml"
                                                                                                          Write(selctedAttributes);

            
            #line default
            #line hidden
WriteLiteral(" />\n");

WriteLiteral("                ");

            
            #line 32 "..\..MVC\Views\CheckboxesField\Write.Default_Inline.cshtml"
           Write(choice);

            
            #line default
            #line hidden
WriteLiteral("\n            </label>\n");

            
            #line 34 "..\..MVC\Views\CheckboxesField\Write.Default_Inline.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("\n");

            
            #line 36 "..\..MVC\Views\CheckboxesField\Write.Default_Inline.cshtml"
        
            
            #line default
            #line hidden
            
            #line 36 "..\..MVC\Views\CheckboxesField\Write.Default_Inline.cshtml"
         if(Model.HasOtherChoice)
        {

            
            #line default
            #line hidden
WriteLiteral("            <label");

WriteLiteral(" class=\"checkbox-inline\"");

WriteLiteral(">\n                <input");

WriteLiteral(" type=\"checkbox\"");

WriteAttribute("name", Tuple.Create(" name=\"", 1754), Tuple.Create("\"", 1771)
            
            #line 39 "..\..MVC\Views\CheckboxesField\Write.Default_Inline.cshtml"
, Tuple.Create(Tuple.Create("", 1761), Tuple.Create<System.Object, System.Int32>(fieldName
            
            #line default
            #line hidden
, 1761), false)
);

WriteLiteral(" data-sf-checkboxes-role=\"other-choice-checkbox\"");

WriteLiteral(" data-sf-role=\"checkboxes-field-input\"");

WriteLiteral("/>\n");

WriteLiteral("                ");

            
            #line 40 "..\..MVC\Views\CheckboxesField\Write.Default_Inline.cshtml"
           Write(Html.Resource("Other"));

            
            #line default
            #line hidden
WriteLiteral("\n                <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-checkboxes-role=\"other-choice-text\"");

WriteLiteral(" data-sf-role=\"checkboxes-field-input\"");

WriteLiteral(" />\n            </label>\n");

            
            #line 43 "..\..MVC\Views\CheckboxesField\Write.Default_Inline.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("\n</div>\n\n");

            
            #line 47 "..\..MVC\Views\CheckboxesField\Write.Default_Inline.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/CheckboxesField/checkboxes-field.js"), "bottom", false));

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
