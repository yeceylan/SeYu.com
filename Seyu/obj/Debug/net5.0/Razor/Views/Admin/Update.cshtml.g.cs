#pragma checksum "C:\Users\Yonis\source\repos\Seyu\Seyu\Views\Admin\Update.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ca40433359e5deafcb6853e41dc8662c1f9c7f48"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Update), @"mvc.1.0.view", @"/Views/Admin/Update.cshtml")]
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
#line 1 "C:\Users\Yonis\source\repos\Seyu\Seyu\Views\_ViewImports.cshtml"
using Seyu;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Yonis\source\repos\Seyu\Seyu\Views\_ViewImports.cshtml"
using Seyu.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca40433359e5deafcb6853e41dc8662c1f9c7f48", @"/Views/Admin/Update.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3b982110f2fc16963c2ae8240e8852c72afd105", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_Update : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Laptop>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Yonis\source\repos\Seyu\Seyu\Views\Admin\Update.cshtml"
 using (Html.BeginForm("Update", "Admin", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <html lang=\"en\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ca40433359e5deafcb6853e41dc8662c1f9c7f484366", async() => {
                WriteLiteral("\r\n        <!-- CSS only -->\r\n        <link href=\"https://cdn.jsdelivr.net/npm/bootstrap@5.2.2/dist/css/bootstrap.min.css\" rel=\"stylesheet\" integrity=\"sha384-Zenh87qX5JnK2Jl0vWa8Ck2rdkQ2Bzep5IDxbcnCeuOxjzrPF/et3URy9Bv1WTRi\" crossorigin=\"anonymous\">\r\n\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ca40433359e5deafcb6853e41dc8662c1f9c7f485603", async() => {
                WriteLiteral("\r\n        <div>\r\n            <!-- Left section of signup form -->\r\n            <dive>\r\n                <h1 class=\"text-center\">Update Laptop</h1>\r\n                <br />\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ca40433359e5deafcb6853e41dc8662c1f9c7f486058", async() => {
                    WriteLiteral("\r\n                    <div class=\"mb-4\">\r\n                        <p>\r\n                            <label for=\"Marka\" class=\"form-label\">Marka</label>\r\n                            <input type=\"text\" class=\"form-control\" name=\"marka\" id=\"Marka\"");
                    BeginWriteAttribute("value", " value=", 855, "", 874, 1);
#nullable restore
#line 20 "C:\Users\Yonis\source\repos\Seyu\Seyu\Views\Admin\Update.cshtml"
WriteAttributeValue("", 862, Model.Marka, 862, 12, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(@">
                    </div>
                    <div>
                        <p>
                            <label for=""Model"" class=""form-label"">Model</label>
                            <input type=""text"" class=""form-control"" name=""model"" id=""Model"">
                    </div>
                    <div>
                        <p>
                            <label for=""Fiyat"" class=""form-label"">Fiyat</label>
                            <input type=""text"" class=""form-control"" name=""fiyat"" id=""username""");
                    BeginWriteAttribute("value", " value=", 1395, "", 1414, 1);
#nullable restore
#line 30 "C:\Users\Yonis\source\repos\Seyu\Seyu\Views\Admin\Update.cshtml"
WriteAttributeValue("", 1402, Model.Fiyat, 1402, 12, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(@">
                    </div>
                    <div>
                        <p>
                            <label for=""Baslik"" class=""form-label"">Baslik</label>
                            <input type=""text"" class=""form-control"" name=""baslik"" id=""Baslik""");
                    BeginWriteAttribute("value", " value=", 1677, "", 1697, 1);
#nullable restore
#line 35 "C:\Users\Yonis\source\repos\Seyu\Seyu\Views\Admin\Update.cshtml"
WriteAttributeValue("", 1684, Model.Baslik, 1684, 13, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(">\r\n                    </div>\r\n                    <div>\r\n                        <p>\r\n                            <label for=\"Url\" class=\"form-label\"> URL </label>\r\n                            <input type=\"text\" class=\"form-control\" name=\"url\" id=\"Url\"");
                    BeginWriteAttribute("value", " value=", 1950, "", 1967, 1);
#nullable restore
#line 40 "C:\Users\Yonis\source\repos\Seyu\Seyu\Views\Admin\Update.cshtml"
WriteAttributeValue("", 1957, Model.Url, 1957, 10, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(@">
                    </div>
                    <div>
                        <p>
                            <label for=""IslemciMarkasi"" class=""form-label"">İşlemci Markasi</label>
                            <input type=""text"" class=""form-control"" name=""islemciMarkasi"" id=""IMArka""");
                    BeginWriteAttribute("value", " value=", 2255, "", 2283, 1);
#nullable restore
#line 45 "C:\Users\Yonis\source\repos\Seyu\Seyu\Views\Admin\Update.cshtml"
WriteAttributeValue("", 2262, Model.islemciMarkası, 2262, 21, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(@">
                    </div>
                    <div>
                        <p>
                            <label for=""IslemciNesli"" class=""form-label"">İşlemci Nesli</label>
                            <input type=""text"" class=""form-control"" name=""islemciNesli"" id=""INesil""");
                    BeginWriteAttribute("value", " value=", 2565, "", 2591, 1);
#nullable restore
#line 50 "C:\Users\Yonis\source\repos\Seyu\Seyu\Views\Admin\Update.cshtml"
WriteAttributeValue("", 2572, Model.islemciNesli, 2572, 19, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(@">
                    </div>
                    <div>
                        <p>
                            <label for=""IslemciTeknolojisi"" class=""form-label"">İşlemci Teknolojisi</label>
                            <input type=""text"" class=""form-control"" name=""islemciTeknolojisi"" id=""Iteknoloji""");
                    BeginWriteAttribute("value", " value=", 2895, "", 2927, 1);
#nullable restore
#line 55 "C:\Users\Yonis\source\repos\Seyu\Seyu\Views\Admin\Update.cshtml"
WriteAttributeValue("", 2902, Model.islemciTeknolojisi, 2902, 25, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(">\r\n                    </div>\r\n                    <div>\r\n                        <p>\r\n                            <label for=\"Ram\" class=\"form-label\">Ram</label>\r\n                            <input type=\"text\" class=\"form-control\" name=\"ram\" id=\"Ram\"");
                    BeginWriteAttribute("value", " value=", 3178, "", 3195, 1);
#nullable restore
#line 60 "C:\Users\Yonis\source\repos\Seyu\Seyu\Views\Admin\Update.cshtml"
WriteAttributeValue("", 3185, Model.ram, 3185, 10, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(@">
                    </div>
                    <div>
                        <p>
                            <label for=""EkranBoyutu"" class=""form-label"">Ekran Boyutu</label>
                            <input type=""text"" class=""form-control"" name=""ekranBoyutu"" id=""Eboyutu""");
                    BeginWriteAttribute("value", " value=", 3475, "", 3500, 1);
#nullable restore
#line 65 "C:\Users\Yonis\source\repos\Seyu\Seyu\Views\Admin\Update.cshtml"
WriteAttributeValue("", 3482, Model.ekranBoyutu, 3482, 18, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(@">
                    </div>
                    <div>
                        <p>
                            <label for=""EkranKartı"" class=""form-label"">Ekran Kartı</label>
                            <input type=""text"" class=""form-control"" name=""ekranKartı"" id=""Ekartı""");
                    BeginWriteAttribute("value", " value=", 3776, "", 3800, 1);
#nullable restore
#line 70 "C:\Users\Yonis\source\repos\Seyu\Seyu\Views\Admin\Update.cshtml"
WriteAttributeValue("", 3783, Model.ekranKartı, 3783, 17, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(@">
                    </div>
                    <div>
                        <p>
                            <label for=""Disk"" class=""form-label"">Disk Kapasitesi</label>
                            <input type=""text"" class=""form-control"" name=""diskKapasitesi"" id=""Disk""");
                    BeginWriteAttribute("value", " value=", 4076, "", 4104, 1);
#nullable restore
#line 75 "C:\Users\Yonis\source\repos\Seyu\Seyu\Views\Admin\Update.cshtml"
WriteAttributeValue("", 4083, Model.diskKapasitesi, 4083, 21, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(">\r\n                    </div>\r\n\r\n                    <a>\r\n                        <button class=\"btn btn active\" type=\"button\" id=\"btn\">Update</button>\r\n                    </a>\r\n                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n        </div>\r\n\r\n\r\n\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </html>\r\n");
#nullable restore
#line 89 "C:\Users\Yonis\source\repos\Seyu\Seyu\Views\Admin\Update.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Laptop> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
