#pragma checksum "C:\Users\Sasho\Desktop\MVC\MyBlog\MyBlog\MyBlog\Views\Post\storyDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df41a457a0a0d1507532a4d1f72333471a1701d5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Post_storyDetails), @"mvc.1.0.view", @"/Views/Post/storyDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Post/storyDetails.cshtml", typeof(AspNetCore.Views_Post_storyDetails))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df41a457a0a0d1507532a4d1f72333471a1701d5", @"/Views/Post/storyDetails.cshtml")]
    public class Views_Post_storyDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyBlog.ViewModels.PostModels.PostDetailsModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "HomePage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Sasho\Desktop\MVC\MyBlog\MyBlog\MyBlog\Views\Post\storyDetails.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(140, 91, true);
            WriteLiteral("\r\n<div class=\"container\" style=\"text-align: center; width: 50%;\">\r\n    <h3 id=\"modelTitle\">");
            EndContext();
            BeginContext(232, 11, false);
#line 8 "C:\Users\Sasho\Desktop\MVC\MyBlog\MyBlog\MyBlog\Views\Post\storyDetails.cshtml"
                   Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(243, 32, true);
            WriteLiteral("</h3>\r\n    <img class=\"homeImgs\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 275, "\"", 296, 1);
#line 9 "C:\Users\Sasho\Desktop\MVC\MyBlog\MyBlog\MyBlog\Views\Post\storyDetails.cshtml"
WriteAttributeValue("", 281, Model.ImageUrl, 281, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(297, 31, true);
            WriteLiteral(" />\r\n    <div id=\"description\">");
            EndContext();
            BeginContext(329, 17, false);
#line 10 "C:\Users\Sasho\Desktop\MVC\MyBlog\MyBlog\MyBlog\Views\Post\storyDetails.cshtml"
                     Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(346, 44, true);
            WriteLiteral("</div>\r\n    <iframe width=\"420\" height=\"315\"");
            EndContext();
            BeginWriteAttribute("src", "\r\n            src=\"", 390, "\"", 454, 2);
            WriteAttributeValue("", 409, "https://www.youtube.com/embed/", 409, 30, true);
#line 12 "C:\Users\Sasho\Desktop\MVC\MyBlog\MyBlog\MyBlog\Views\Post\storyDetails.cshtml"
WriteAttributeValue("", 439, Model.VideoUrl, 439, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(455, 51, true);
            WriteLiteral(">\r\n    </iframe>\r\n    <div>\r\n        <span>Posted: ");
            EndContext();
            BeginContext(507, 16, false);
#line 15 "C:\Users\Sasho\Desktop\MVC\MyBlog\MyBlog\MyBlog\Views\Post\storyDetails.cshtml"
                 Write(Model.DatePosted);

#line default
#line hidden
            EndContext();
            BeginContext(523, 25, true);
            WriteLiteral("</span>\r\n    </div>\r\n    ");
            EndContext();
            BeginContext(548, 248, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "db88700edb7e49b8b20e25b41a57696f", async() => {
                BeginContext(598, 32, true);
                WriteLiteral("\r\n        <input name=\"category\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 630, "\"", 653, 1);
#line 18 "C:\Users\Sasho\Desktop\MVC\MyBlog\MyBlog\MyBlog\Views\Post\storyDetails.cshtml"
WriteAttributeValue("", 638, Model.Category, 638, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(654, 135, true);
                WriteLiteral(" style=\"display: none\"/>\r\n        <input type=\"submit\" value=\"Go back\" class=\"btn btn-dark text-light\" style=\"margin-top: 20px\"/>\r\n    ");
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
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(796, 8, true);
            WriteLiteral("\r\n</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyBlog.ViewModels.PostModels.PostDetailsModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
