#pragma checksum "D:\Code PJ\VisualStudioProjects\TruyenChuWebAppMVC\Views\Home\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c82a985e99b8cb94cc7cf4019d7f4b873cd9301f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Search), @"mvc.1.0.view", @"/Views/Home/Search.cshtml")]
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
#line 1 "D:\Code PJ\VisualStudioProjects\TruyenChuWebAppMVC\Views\_ViewImports.cshtml"
using TruyenChuWebAppMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Code PJ\VisualStudioProjects\TruyenChuWebAppMVC\Views\_ViewImports.cshtml"
using TruyenChuWebAppMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c82a985e99b8cb94cc7cf4019d7f4b873cd9301f", @"/Views/Home/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4cbb75a122bbe91668bb0456367c5a437a3369e0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TruyenChuWebAppMVC.Models.NovelRepository>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("h5 card-title"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color: black"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-toggle", new global::Microsoft.AspNetCore.Html.HtmlString("tooltip"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-placement", new global::Microsoft.AspNetCore.Html.HtmlString("top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Novel", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Chapter", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-text text-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h2 class=\"p-2\">Tìm truyện</h2>\r\n\r\n<div class=\"row p-2\" id=\"novel_container\">\r\n");
#nullable restore
#line 6 "D:\Code PJ\VisualStudioProjects\TruyenChuWebAppMVC\Views\Home\Search.cshtml"
     foreach (var item in Model.novels)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card m-2 p-1\" style=\"width:200px\">\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 251, "\"", 312, 3);
            WriteAttributeValue("", 257, "http://localhost/api/truyenchu/images/", 257, 38, true);
#nullable restore
#line 9 "D:\Code PJ\VisualStudioProjects\TruyenChuWebAppMVC\Views\Home\Search.cshtml"
WriteAttributeValue("", 295, item.cover, 295, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 308, ".jpg", 308, 4, true);
            EndWriteAttribute();
            WriteLiteral("\r\n                 class=\"card-img-top\"");
            BeginWriteAttribute("alt", " alt=\"", 352, "\"", 358, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"height:250px\">\r\n\r\n            <div class=\"card-body p-2 pt-3\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c82a985e99b8cb94cc7cf4019d7f4b873cd9301f6983", async() => {
                WriteLiteral("\r\n                    ");
#nullable restore
#line 16 "D:\Code PJ\VisualStudioProjects\TruyenChuWebAppMVC\Views\Home\Search.cshtml"
               Write(item.title);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "title", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 14 "D:\Code PJ\VisualStudioProjects\TruyenChuWebAppMVC\Views\Home\Search.cshtml"
AddHtmlAttributeValue("", 563, item.description, 563, 17, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-novelId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 15 "D:\Code PJ\VisualStudioProjects\TruyenChuWebAppMVC\Views\Home\Search.cshtml"
                                                                    WriteLiteral(item.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["novelId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-novelId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["novelId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                <div class=\"mt-2\">\r\n");
#nullable restore
#line 19 "D:\Code PJ\VisualStudioProjects\TruyenChuWebAppMVC\Views\Home\Search.cshtml"
                     if (item.chapters != null)
                    {
                        for (int i = item.chapters.Count - 1; i >= 0; i--)
                        {
                            int index = i + 1;
                            var chapter = item.chapters[i];
                            TimeSpan time = DateTime.Now - DateTime.Parse(item.chapters[i].date_post);

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c82a985e99b8cb94cc7cf4019d7f4b873cd9301f11125", async() => {
                WriteLiteral("\r\n                                    Chương ");
#nullable restore
#line 30 "D:\Code PJ\VisualStudioProjects\TruyenChuWebAppMVC\Views\Home\Search.cshtml"
                                       Write(i+1);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-chapterId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 28 "D:\Code PJ\VisualStudioProjects\TruyenChuWebAppMVC\Views\Home\Search.cshtml"
                                            WriteLiteral(chapter.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["chapterId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-chapterId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["chapterId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 28 "D:\Code PJ\VisualStudioProjects\TruyenChuWebAppMVC\Views\Home\Search.cshtml"
                                                                           WriteLiteral(index);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["viewId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-viewId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["viewId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute(";", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 32 "D:\Code PJ\VisualStudioProjects\TruyenChuWebAppMVC\Views\Home\Search.cshtml"
                                 if (time.TotalDays >= 1)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span class=\"text-black-50 mt-1\" style=\"font-size: 12px; float:right\">\r\n                                        ");
#nullable restore
#line 35 "D:\Code PJ\VisualStudioProjects\TruyenChuWebAppMVC\Views\Home\Search.cshtml"
                                    Write((int)time.TotalDays);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ngày trước\r\n                                    </span>\r\n");
#nullable restore
#line 37 "D:\Code PJ\VisualStudioProjects\TruyenChuWebAppMVC\Views\Home\Search.cshtml"
                                }
                                else if (time.TotalHours >= 1)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span class=\"text-black-50 mt-1\" style=\"font-size: 12px; float:right\">\r\n                                        ");
#nullable restore
#line 41 "D:\Code PJ\VisualStudioProjects\TruyenChuWebAppMVC\Views\Home\Search.cshtml"
                                    Write((int)time.TotalHours);

#line default
#line hidden
#nullable disable
            WriteLiteral(" giờ trước\r\n                                    </span>\r\n");
#nullable restore
#line 43 "D:\Code PJ\VisualStudioProjects\TruyenChuWebAppMVC\Views\Home\Search.cshtml"
                                }
                                else if (time.TotalMinutes >= 1)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span class=\"text-black-50 mt-1\" style=\"font-size: 12px; float:right\">\r\n                                        ");
#nullable restore
#line 47 "D:\Code PJ\VisualStudioProjects\TruyenChuWebAppMVC\Views\Home\Search.cshtml"
                                   Write(time.TotalMinutes);

#line default
#line hidden
#nullable disable
            WriteLiteral(" phút trước\r\n                                    </span>\r\n");
#nullable restore
#line 49 "D:\Code PJ\VisualStudioProjects\TruyenChuWebAppMVC\Views\Home\Search.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span class=\"text-black-50 mt-1\" style=\"font-size: 12px; float:right\">\r\n                                        vừa xong\r\n                                    </span>\r\n");
#nullable restore
#line 55 "D:\Code PJ\VisualStudioProjects\TruyenChuWebAppMVC\Views\Home\Search.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </div>\r\n");
#nullable restore
#line 57 "D:\Code PJ\VisualStudioProjects\TruyenChuWebAppMVC\Views\Home\Search.cshtml"
                        }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 62 "D:\Code PJ\VisualStudioProjects\TruyenChuWebAppMVC\Views\Home\Search.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TruyenChuWebAppMVC.Models.NovelRepository> Html { get; private set; }
    }
}
#pragma warning restore 1591
