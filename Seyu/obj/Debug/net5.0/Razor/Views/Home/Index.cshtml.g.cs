#pragma checksum "C:\Users\Yonis\source\repos\Seyu\Seyu\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec325fac77406c4049080d498c3ced525336de44"
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
#nullable restore
#line 1 "C:\Users\Yonis\source\repos\Seyu\Seyu\Views\Home\Index.cshtml"
using PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Yonis\source\repos\Seyu\Seyu\Views\Home\Index.cshtml"
using PagedList.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Yonis\source\repos\Seyu\Seyu\Views\Home\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec325fac77406c4049080d498c3ced525336de44", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3b982110f2fc16963c2ae8240e8852c72afd105", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PagedList.IPagedList<Laptop>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-flex position-absolute top-50 start-50 translate-middle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\Yonis\source\repos\Seyu\Seyu\Views\Home\Index.cshtml"
 using (Html.BeginForm("Index", "Home", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <html lang=\"en\" xmlns=\"http://www.w3.org/1999/xhtml\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ec325fac77406c4049080d498c3ced525336de447659", async() => {
                WriteLiteral("\r\n        <meta charset=\"utf-8\" />\r\n        <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\r\n        <title>");
#nullable restore
#line 12 "C:\Users\Yonis\source\repos\Seyu\Seyu\Views\Home\Index.cshtml"
          Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" - SeYu</title>\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ec325fac77406c4049080d498c3ced525336de448300", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ec325fac77406c4049080d498c3ced525336de449482", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
        <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.2.2/dist/css/bootstrap.min.css"" rel=""stylesheet"" integrity=""sha384-Zenh87qX5JnK2Jl0vWa8Ck2rdkQ2Bzep5IDxbcnCeuOxjzrPF/et3URy9Bv1WTRi"" crossorigin=""anonymous"">
        <style>
            .flexbox-container {
                display: flex;
                /*align-items:center;*/
                align-items: stretch;
            }

            .box-1 {
                width: 280px;
            }

            .box-2 {
                width: max-content;
                flex-grow: 1;
            }
        </style>



    ");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ec325fac77406c4049080d498c3ced525336de4411978", async() => {
                WriteLiteral(@"

        <nav class=""navbar navbar-expand-lg bg-light"">
            <div class=""container-fluid"">
                <a class=""navbar-brand"" href=""#"">Seyu</a>
                <button class=""navbar-toggler"" type=""button"" data-bs-toggle=""collapse"" data-bs-target=""#navbarSupportedContent"" aria-controls=""navbarSupportedContent"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                    <span class=""navbar-toggler-icon""></span>
                </button>
                <div class=""collapse navbar-collapse"" id=""navbarSupportedContent"">
                    <ul class=""navbar-nav me-auto mb-2 mb-lg-0"">
                        <li class=""nav-item"">
                            <a class=""nav-link active"" aria-current=""page"" href=""#"">Çok Satan</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""#"">En Düşük Fiyat</a>
                        </li>
                        <li class=""nav-item "">
                    ");
                WriteLiteral(@"        <a class=""nav-link "" href=""#"">En yüksek Fiyat </a>

                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link "" href=""#"">En Yüksek Puan</a>
                        </li>
                    </ul>
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ec325fac77406c4049080d498c3ced525336de4413646", async() => {
                    WriteLiteral(@"
                        <input class=""form-control me-2"" name=""search"" type=""search"" placeholder=""Search"" aria-label=""Search"">
                        <button class=""btn btn-outline-success"" type=""submit"" name=""submitButton"" value=""Search"">Search</button>
                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ec325fac77406c4049080d498c3ced525336de4415639", async() => {
                    WriteLiteral("Admin");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </nav>\r\n\r\n        <div class=\"flexbox-container\">\r\n            <div class=\"flexbox-item box-1 d-flex flex-column flex-shrink-0 p-3 bg-light\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ec325fac77406c4049080d498c3ced525336de4417386", async() => {
                    WriteLiteral(@"
                    <ul class=""nav nav-pills flex-column mb-auto"">
                        <h5 class=""text-center"">Marka</h5>
                        <hr>
                        <li class=""nav-item text-center"">
                            <input class=""form-check-input"" type=""checkbox"" value=""Asus"" name=""Asus"">
                            <label class=""form-check-label "" for=""flexCheckDefault"">
                                Asus
                            </label>
                        </li>

                        <li class=""nav-item text-center"">
                            <input class=""form-check-input"" type=""checkbox"" value=""Lenovo"" name=""Lenovo"">
                            <label class=""form-check-label"" for=""flexCheckDefault"">
                                Lenovo
                            </label>
                        </li>

                        <li class=""nav-item text-center"">
                            <input class=""form-check-input"" type=""checkbox"" value=""Mon");
                    WriteLiteral(@"ster"" name=""Monster"">
                            <label class=""form-check-label"" for=""flexCheckDefault"">
                                Monster
                            </label>
                        </li>

                        <li class=""nav-item text-center"">
                            <input class=""form-check-input"" type=""checkbox"" value=""Msi"" name=""Msi"">
                            <label class=""form-check-label"" for=""flexCheckDefault"">
                                Msi
                            </label>
                        </li>

                        <li class=""nav-item text-center"">
                            <input class=""form-check-input"" type=""checkbox"" value=""Apple"" name=""Apple"">
                            <label class=""form-check-label"" for=""flexCheckDefault"">
                                Apple
                            </label>
                        </li>

                        <li class=""nav-item text-center"">
                            <inpu");
                    WriteLiteral(@"t class=""form-check-input"" type=""checkbox"" value=""Hp"" name=""Hp"">
                            <label class=""form-check-label"" for=""flexCheckDefault"">
                                Hp
                            </label>
                        </li>
                        <br />
                        <h5 class=""text-center"">Fiyat</h5>
                        <hr>
                        <li class=""nav-item text-center"">
                            <input class=""form-check-input"" type=""checkbox"" value=""0-5.000"" name=""Price1"">
                            <label class=""form-check-label "" for=""flexCheckDefault"">
                                0-5.000 TL
                            </label>
                        </li>

                        <li class=""nav-item text-center"">
                            <input class=""form-check-input"" type=""checkbox"" value=""5.000-10.000"" name=""Price2"">
                            <label class=""form-check-label "" for=""flexCheckDefault"">
                    ");
                    WriteLiteral(@"            5.000-10.000 TL
                            </label>
                        </li>

                        <li class=""nav-item text-center"">
                            <input class=""form-check-input"" type=""checkbox"" value=""10.000-20.000"" name=""Price3"">
                            <label class=""form-check-label "" for=""flexCheckDefault"">
                                10.000-20.000 TL
                            </label>
                        </li>
                        <br />
                        <h5 class=""text-center"">Ram</h5>
                        <hr>
                        <li class=""nav-item text-center"">
                            <input class=""form-check-input"" type=""checkbox"" value=""4 GB"" name=""Ram4"">
                            <label class=""form-check-label "" for=""flexCheckDefault"">
                                4 GB
                            </label>
                        </li>

                        <li class=""nav-item text-center"">
          ");
                    WriteLiteral(@"                  <input class=""form-check-input"" type=""checkbox"" value=""8 GB"" name=""Ram8"">
                            <label class=""form-check-label "" for=""flexCheckDefault"">
                                8 GB
                            </label>
                        </li>

                        <li class=""nav-item text-center"">
                            <input class=""form-check-input"" type=""checkbox"" value=""16 GB"" name=""Ram16"">
                            <label class=""form-check-label "" for=""flexCheckDefault"">
                                16 GB
                            </label>
                        </li>
                        <br />
                        <h5 class=""text-center"">İşlemci</h5>
                        <hr>
                        <li class=""nav-item text-center"">
                            <input class=""form-check-input"" type=""checkbox"" value=""Amd"" name=""Amd"">
                            <label class=""form-check-label "" for=""flexCheckDefault"">
        ");
                    WriteLiteral(@"                        AMD
                            </label>
                        </li>

                        <li class=""nav-item text-center"">
                            <input class=""form-check-input"" type=""checkbox"" value=""Intel"" name=""Intel"">
                            <label class=""form-check-label "" for=""flexCheckDefault"">
                                Intel
                            </label>
                        </li>
                        <br />
                        <h5 class=""text-center"">İşlemci Markası</h5>
                        <hr>
                        <li class=""nav-item text-center"">
                            <input class=""form-check-input"" type=""checkbox"" value=""AMD Ryzen 3"" name=""Amd3"">
                            <label class=""form-check-label "" for=""flexCheckDefault"">
                                AMD Ryzen 3
                            </label>
                        </li>
                        <li class=""nav-item text-center"">
      ");
                    WriteLiteral(@"                      <input class=""form-check-input"" type=""checkbox"" value=""AMD Ryzen 5"" name=""Amd5"">
                            <label class=""form-check-label "" for=""flexCheckDefault"">
                                AMD Ryzen 5
                            </label>
                        </li>

                        <li class=""nav-item text-center"">
                            <input class=""form-check-input"" type=""checkbox"" value=""AMD Ryzen 7"" name=""Amd7"">
                            <label class=""form-check-label "" for=""flexCheckDefault"">
                                AMD Ryzen 7
                            </label>
                        </li>
                        <li class=""nav-item text-center"">
                            <input class=""form-check-input"" type=""checkbox"" value=""Intel Celeron"" name=""IntelC"">
                            <label class=""form-check-label "" for=""flexCheckDefault"">
                                Intel Celeron
                            </label>
     ");
                    WriteLiteral(@"                   </li>
                        <li class=""nav-item text-center"">
                            <input class=""form-check-input"" type=""checkbox"" value=""Intel Core İ3"" name=""Intel3"">
                            <label class=""form-check-label "" for=""flexCheckDefault"">
                                Intel Core İ3
                            </label>
                        </li>
                        <li class=""nav-item text-center"">
                            <input class=""form-check-input"" type=""checkbox"" value=""Intel Core İ5"" name=""Intel5"">
                            <label class=""form-check-label "" for=""flexCheckDefault"">
                                Intel Core İ5
                            </label>
                        </li>
                        <li class=""nav-item text-center"">
                            <input class=""form-check-input"" type=""checkbox"" value=""Intel Core İ7"" name=""Intel7"">
                            <label class=""form-check-label "" for=""flexCheck");
                    WriteLiteral(@"Default"">
                                Intel Core İ7
                            </label>
                        </li>
                        <li class=""nav-item text-center"">
                            <input class=""form-check-input"" type=""checkbox"" value=""Intel Core İ9"" name=""Intel9"">
                            <label class=""form-check-label "" for=""flexCheckDefault"">
                                Intel Core İ9
                            </label>
                        </li>
                        <h5 class=""text-center"">Disk Kapasitesi</h5>
                        <hr>
                        <li class=""nav-item text-center"">
                            <input class=""form-check-input"" type=""checkbox"" value=""128-256"" name=""Disk0"">
                            <label class=""form-check-label "" for=""flexCheckDefault"">
                                128-256 GB
                            </label>
                        </li>
                        <li class=""nav-item text-center"">");
                    WriteLiteral(@"
                            <input class=""form-check-input"" type=""checkbox"" value=""256-512"" name=""Disk1"">
                            <label class=""form-check-label "" for=""flexCheckDefault"">
                                256-512 GB
                            </label>
                        </li>
                        <li class=""nav-item text-center"">
                            <input class=""form-check-input"" type=""checkbox"" value=""512-1024"" name=""Disk2"">
                            <label class=""form-check-label "" for=""flexCheckDefault"">
                                512-1024 GB
                            </label>
                        </li>
                        <h5 class=""text-center"">Ekran Boyutu</h5>
                        <hr>
                        <li class=""nav-item text-center"">
                            <input class=""form-check-input"" type=""checkbox"" value=""13.6-15.6"" name=""E13"">
                            <label class=""form-check-label "" for=""flexCheckDefault"">
");
                    WriteLiteral(@"                                13.6-15.6 inç
                            </label>
                        </li>
                        <li class=""nav-item text-center"">
                            <input class=""form-check-input"" type=""checkbox"" value=""15.6-17.3"" name=""E15"">
                            <label class=""form-check-label "" for=""flexCheckDefault"">
                                15.6-17.3 inç
                            </label>
                        </li>
                        <li class=""nav-item text-center"">
                            <input class=""form-check-input"" type=""checkbox"" value=""17.3"" name=""E17"">
                            <label class=""form-check-label "" for=""flexCheckDefault"">
                                17.3 inç
                            </label>
                        </li>
                        <h5 class=""text-center"">Ekran Kartı</h5>
                        <hr>
                        <li class=""nav-item text-center"">
                           ");
                    WriteLiteral(@" <input class=""form-check-input"" type=""checkbox"" value=""Amd"" name=""AmdS"">
                            <label class=""form-check-label "" for=""flexCheckDefault"">
                                AMD
                            </label>
                        </li>
                        <li class=""nav-item text-center"">
                            <input class=""form-check-input"" type=""checkbox"" value=""Intel"" name=""IntelS"">
                            <label class=""form-check-label "" for=""flexCheckDefault"">
                                Intel
                            </label>
                        </li>
                        <li class=""nav-item text-center"">
                            <input class=""form-check-input"" type=""checkbox"" value=""Nvidia"" name=""NvidiaS"">
                            <label class=""form-check-label "" for=""flexCheckDefault"">
                                Nvidia
                            </label>
                        </li>
                        <br />
    ");
                    WriteLiteral(@"                    <li class=""text-center"">
                            <button class=""btn btn-outline-success"" type=""submit"" name=""submitButton"" value=""Submit"">Submit</button>

                        </li>

                    </ul>
                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </div>\r\n            <div class=\"flexbox-item box-2\" style=\"width:1500px;\">\r\n                <ul class=\"nav nav-pills flex-column mb-auto\">\r\n");
#nullable restore
#line 301 "C:\Users\Yonis\source\repos\Seyu\Seyu\Views\Home\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <li>\r\n                            <div class=\"card mb-3\">\r\n                                <div class=\"row g-0\">\r\n                                    <div class=\"col-md-4\">\r\n\r\n\r\n                                        <img");
                BeginWriteAttribute("src", " src=\"", 16231, "\"", 16248, 1);
#nullable restore
#line 309 "C:\Users\Yonis\source\repos\Seyu\Seyu\Views\Home\Index.cshtml"
WriteAttributeValue("", 16237, item.Resim, 16237, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""img-fluid rounded-start"" alt=""..."">
                                    </div>
                                    <div class=""col-md-8"">
                                        <div class=""card-body"">
                                            <h2>");
#nullable restore
#line 313 "C:\Users\Yonis\source\repos\Seyu\Seyu\Views\Home\Index.cshtml"
                                           Write(item.Marka);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n                                            <a class=\"card-title\"");
                BeginWriteAttribute("href", " href=\'", 16594, "\'", 16661, 1);
#nullable restore
#line 314 "C:\Users\Yonis\source\repos\Seyu\Seyu\Views\Home\Index.cshtml"
WriteAttributeValue("", 16601, Url.Action("Index", "Detail", new { baslik = item.Baslik }), 16601, 60, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 314 "C:\Users\Yonis\source\repos\Seyu\Seyu\Views\Home\Index.cshtml"
                                                                                                                                 Write(item.Baslik);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </a>\r\n                                            <!-- CSS only   <a class=\"card-title\" asp-area=\"\" asp-controller=\"Detail\" asp-action=\"Index\">");
#nullable restore
#line 315 "C:\Users\Yonis\source\repos\Seyu\Seyu\Views\Home\Index.cshtml"
                                                                                                                                    Write(item.Baslik);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>-->\r\n                                            <p class=\"card-text\" style=\"color:limegreen\" :\">");
#nullable restore
#line 316 "C:\Users\Yonis\source\repos\Seyu\Seyu\Views\Home\Index.cshtml"
                                                                                       Write(item.Fiyat);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" TL</p>

                                            <div class=""btn-toolbar"" role=""toolbar"" aria-label=""Toolbar with button groups"">
                                                <div class=""btn-group me-2"" role=""group"" aria-label=""First group"">
                                                    <button type=""button"" class=""btn active"" style=""color:orange"">Trendyol</button>

                                                </div>
                                                <div class=""btn-group me-2"" role=""group"" aria-label=""Second group"">
                                                    <button type=""button"" class=""btn active"" style=""color:red"">n11</button>

                                                </div>
                                                <div class=""btn-group"" role=""group"" aria-label=""Third group"">
                                                    <button type=""button"" class=""btn active"" style=""color:blue"">Vatan</button>
                                         ");
                WriteLiteral(@"       </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </li>
");
#nullable restore
#line 336 "C:\Users\Yonis\source\repos\Seyu\Seyu\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n            </div>\r\n        </div>\r\n    ");
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
            WriteLiteral("\r\n\r\n    </html>\r\n");
#nullable restore
#line 344 "C:\Users\Yonis\source\repos\Seyu\Seyu\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 345 "C:\Users\Yonis\source\repos\Seyu\Seyu\Views\Home\Index.cshtml"
Write(Html);

#line default
#line hidden
#nullable disable
            WriteLiteral("..PagedListPager((IPagedList)Model, p => Url.Action(\"Index1\",new { p })) \r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PagedList.IPagedList<Laptop>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591