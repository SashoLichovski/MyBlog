#pragma checksum "C:\Users\Sasho\Desktop\MVC\MyBlog\MyBlog\MyBlog\Views\Post\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "201d07a5e8ca4829437a6a5903517ce0cdb0a4a9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Post_Index), @"mvc.1.0.view", @"/Views/Post/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Post/Index.cshtml", typeof(AspNetCore.Views_Post_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"201d07a5e8ca4829437a6a5903517ce0cdb0a4a9", @"/Views/Post/Index.cshtml")]
    public class Views_Post_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("chooseSportContainer"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "storyDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Sasho\Desktop\MVC\MyBlog\MyBlog\MyBlog\Views\Post\Index.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(86, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(92, 477, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "934918ade5f04f4ab2b5b6d546e829fa", async() => {
                BeginContext(165, 397, true);
                WriteLiteral(@"
        <input type=""submit"" value=""Skate"" name=""category"" class=""sportLink btn btn-dark text-light hvr-bubble-float-left"" />
        <input type=""submit"" value=""Snowboard"" name=""category"" class=""sportLink btn btn-dark text-light hvr-bubble-float-left"" />
        <input type=""submit"" value=""Rollerblade"" name=""category"" class=""sportLink btn btn-dark text-light hvr-bubble-float-left"" />
    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(569, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 12 "C:\Users\Sasho\Desktop\MVC\MyBlog\MyBlog\MyBlog\Views\Post\Index.cshtml"
 for (int i = 0; i < Model.Count; i++)
{
    if (i % 2 == 0)
    {

#line default
#line hidden
            BeginContext(644, 139, true);
            WriteLiteral("        <div class=\"contentContainer hvr-grow-shadow\">\r\n            <div class=\"infoContainer\">\r\n                <h3 class=\"homePostTitle\">");
            EndContext();
            BeginContext(784, 14, false);
#line 18 "C:\Users\Sasho\Desktop\MVC\MyBlog\MyBlog\MyBlog\Views\Post\Index.cshtml"
                                     Write(Model[i].Title);

#line default
#line hidden
            EndContext();
            BeginContext(798, 54, true);
            WriteLiteral("</h3>\r\n                <p class=\"homePostDescription\">");
            EndContext();
            BeginContext(853, 20, false);
#line 19 "C:\Users\Sasho\Desktop\MVC\MyBlog\MyBlog\MyBlog\Views\Post\Index.cshtml"
                                          Write(Model[i].Description);

#line default
#line hidden
            EndContext();
            BeginContext(873, 22, true);
            WriteLiteral("</p>\r\n                ");
            EndContext();
            BeginContext(895, 117, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2133680cc13c4e8eb4ba4bd04f0a6751", async() => {
                BeginContext(998, 10, true);
                WriteLiteral("Read story");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 20 "C:\Users\Sasho\Desktop\MVC\MyBlog\MyBlog\MyBlog\Views\Post\Index.cshtml"
                                                                     WriteLiteral(Model[i].Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1012, 82, true);
            WriteLiteral("\r\n                <br />\r\n                <br />\r\n                <div>Posted on: ");
            EndContext();
            BeginContext(1095, 19, false);
#line 23 "C:\Users\Sasho\Desktop\MVC\MyBlog\MyBlog\MyBlog\Views\Post\Index.cshtml"
                           Write(Model[i].DatePosted);

#line default
#line hidden
            EndContext();
            BeginContext(1114, 61, true);
            WriteLiteral("</div>\r\n            </div>\r\n            <img class=\"homeImgs\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1175, "\"", 1199, 1);
#line 25 "C:\Users\Sasho\Desktop\MVC\MyBlog\MyBlog\MyBlog\Views\Post\Index.cshtml"
WriteAttributeValue("", 1181, Model[i].ImageUrl, 1181, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1200, 21, true);
            WriteLiteral(" />\r\n        </div>\r\n");
            EndContext();
#line 27 "C:\Users\Sasho\Desktop\MVC\MyBlog\MyBlog\MyBlog\Views\Post\Index.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(1245, 90, true);
            WriteLiteral("        <div class=\"contentContainer  hvr-grow-shadow\">\r\n            <img class=\"homeImgs\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1335, "\"", 1359, 1);
#line 31 "C:\Users\Sasho\Desktop\MVC\MyBlog\MyBlog\MyBlog\Views\Post\Index.cshtml"
WriteAttributeValue("", 1341, Model[i].ImageUrl, 1341, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1360, 89, true);
            WriteLiteral(" />\r\n            <div class=\"infoContainer2\">\r\n                <h3 class=\"homePostTitle\">");
            EndContext();
            BeginContext(1450, 14, false);
#line 33 "C:\Users\Sasho\Desktop\MVC\MyBlog\MyBlog\MyBlog\Views\Post\Index.cshtml"
                                     Write(Model[i].Title);

#line default
#line hidden
            EndContext();
            BeginContext(1464, 54, true);
            WriteLiteral("</h3>\r\n                <p class=\"homePostDescription\">");
            EndContext();
            BeginContext(1519, 20, false);
#line 34 "C:\Users\Sasho\Desktop\MVC\MyBlog\MyBlog\MyBlog\Views\Post\Index.cshtml"
                                          Write(Model[i].Description);

#line default
#line hidden
            EndContext();
            BeginContext(1539, 22, true);
            WriteLiteral("</p>\r\n                ");
            EndContext();
            BeginContext(1561, 117, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fd5cc8379a1a478b9cfe4a48cb407d09", async() => {
                BeginContext(1664, 10, true);
                WriteLiteral("Read story");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 35 "C:\Users\Sasho\Desktop\MVC\MyBlog\MyBlog\MyBlog\Views\Post\Index.cshtml"
                                                                     WriteLiteral(Model[i].Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1678, 82, true);
            WriteLiteral("\r\n                <br />\r\n                <br />\r\n                <div>Posted on: ");
            EndContext();
            BeginContext(1761, 19, false);
#line 38 "C:\Users\Sasho\Desktop\MVC\MyBlog\MyBlog\MyBlog\Views\Post\Index.cshtml"
                           Write(Model[i].DatePosted);

#line default
#line hidden
            EndContext();
            BeginContext(1780, 44, true);
            WriteLiteral("</div>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 41 "C:\Users\Sasho\Desktop\MVC\MyBlog\MyBlog\MyBlog\Views\Post\Index.cshtml"
    }
}

#line default
#line hidden
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
