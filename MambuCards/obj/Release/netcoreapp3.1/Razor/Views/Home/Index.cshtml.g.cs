#pragma checksum "/Users/salinas/Projects/TestForm/MambuCards/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0dda28c9beab6578b1efd58f00f0f8bb71abe7da"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "/Users/salinas/Projects/TestForm/MambuCards/Views/_ViewImports.cshtml"
using MambuCards;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/salinas/Projects/TestForm/MambuCards/Views/_ViewImports.cshtml"
using MambuCards.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0dda28c9beab6578b1efd58f00f0f8bb71abe7da", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6232143896b971bda5554ac826d9ad118501cdc5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("loginform"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("Home/SetParameters"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/salinas/Projects/TestForm/MambuCards/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"text-center\">\n    <p class=\"h5\">Card Management</p>\n</div>\n\n");
#nullable restore
#line 9 "/Users/salinas/Projects/TestForm/MambuCards/Views/Home/Index.cshtml"
 if (TempData["withoutContetntPage"] != null && !String.IsNullOrEmpty(TempData["withoutContetntPage"].ToString()) && TempData["withoutContetntPage"].ToString() == "true")
{


#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0dda28c9beab6578b1efd58f00f0f8bb71abe7da5046", async() => {
                WriteLiteral(@"
    
        <div class=""form-group mb-2"">
            <label for=""staticEmail2"" >Account</label>
            <input type=""text"" class=""form-control input-group-lg reg_name"" name=""accountId"" id=""accountId"">
        </div>
    
            <button type=""submit"" class=""btn btn-primary mb-2"">Set Account</button>
       
    
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 23 "/Users/salinas/Projects/TestForm/MambuCards/Views/Home/Index.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
#nullable restore
#line 27 "/Users/salinas/Projects/TestForm/MambuCards/Views/Home/Index.cshtml"
 if (!String.IsNullOrEmpty(ViewBag.Error))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\n        <div class=\"alert alert-danger\" role=\"alert\">\n            ");
#nullable restore
#line 31 "/Users/salinas/Projects/TestForm/MambuCards/Views/Home/Index.cshtml"
       Write(ViewBag.Error);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br>\n        </div>\n    </div>\n");
#nullable restore
#line 34 "/Users/salinas/Projects/TestForm/MambuCards/Views/Home/Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<table id=""myTable"" class=""display"" style=""width:100%"">
    <thead>
        <tr>
            <th>cardToken</th>
            <th>externalReferenceId</th>
            <th>advice</th>
            <th>amount</th>
            <th>status</th>
            <th>creditDebitIndicator</th>
            <th>encodedKey</th>
            <th>Reverse</th>
            <th>Approve</th>
        </tr>
    </thead>
</table>

<script>$(document).ready(function () {
    var encodekey = '");
#nullable restore
#line 52 "/Users/salinas/Projects/TestForm/MambuCards/Views/Home/Index.cshtml"
                Write(ViewBag.object_id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';
            $('#myTable').DataTable({
                ""processing"": false, // for show progress bar
                ""serverSide"": true, // for process server side
                ""filter"": true, // this is for disab({e filter (search box)
                ""orderMulti"": false, // for disable multiple column at once
                ""pageLength"": 5,


                ""ajax"": {
                    ""url"": ""/Home/LoadData?encodekey="" + encodekey,
                    ""type"": ""POST"",
                    ""datatype"": 'json'
                },



                ""columns"": [
                    { ""data"": ""cardToken"", ""autoWidth"": true },
                    { ""data"": ""externalReferenceId"", ""autoWidth"": true },
                    { ""data"": ""advice"", ""autoWidth"": true },
                    { ""data"": ""amount"", ""autoWidth"": true },
                    { ""data"": ""status"", ""autoWidth"": true },
                    { ""data"": ""creditDebitIndicator"", ""autoWidth"": true },
                    { ""data"": ""encodedKey"", ""autoWidth""");
            WriteLiteral(@": true },
                    {
                        ""render"": function (data, type, full)
                        {
                            if (full.status == ""PENDING"") {
                                return '<a class=""btn btn-info"" href=""/Home/Revert?cardToken=' + full.cardToken + '&externalReferenceId=' + full.externalReferenceId + '"">Reverse</a>';
                            }
                            else {
                                return '<a class=""btn btn-info disabled"" href=""#"">Reverse</a>';
                            }

                        }
                    },
                    {
                        ""render"": function (data, type, full) {
                            if (full.status == ""PENDING"") {

                                return '<a class=""btn btn-info"" href=""/Home/Approve?cardToken=' + full.cardToken + '&externalReferenceId=' + full.externalReferenceId + '"">Approve</a>';
                            }
                            else {

                     ");
            WriteLiteral("           return \'<a class=\"btn btn-info disabled\" href=\"#\">Approve</a>\';\n                            }\n                        }\n                    },\n                ]\n\n            });\n\n\n\n\n\n\n\n\n \n\n\n        });</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
