#pragma checksum "C:\Users\Sasho\Desktop\MVC\MyBlog\MyBlog\MyBlog\Views\Gallery\Overview.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "279ce2405bc13409488ac7dafa3895efc89f5c66"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Gallery_Overview), @"mvc.1.0.view", @"/Views/Gallery/Overview.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Gallery/Overview.cshtml", typeof(AspNetCore.Views_Gallery_Overview))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"279ce2405bc13409488ac7dafa3895efc89f5c66", @"/Views/Gallery/Overview.cshtml")]
    public class Views_Gallery_Overview : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<MyBlog.ViewModels.GalleryModels.OverviewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Sasho\Desktop\MVC\MyBlog\MyBlog\MyBlog\Views\Gallery\Overview.cshtml"
   
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(93, 35, true);
            WriteLiteral("\r\n    <div id=\"galleryContainer\">\r\n");
            EndContext();
#line 7 "C:\Users\Sasho\Desktop\MVC\MyBlog\MyBlog\MyBlog\Views\Gallery\Overview.cshtml"
         for (int i = 0; i < Model.Count; i++)
        {

#line default
#line hidden
            BeginContext(187, 66, true);
            WriteLiteral("            <img data-toggle=\"modal\" data-target=\"#staticBackdrop-");
            EndContext();
            BeginContext(254, 1, false);
#line 9 "C:\Users\Sasho\Desktop\MVC\MyBlog\MyBlog\MyBlog\Views\Gallery\Overview.cshtml"
                                                             Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(255, 37, true);
            WriteLiteral("\" class=\"galleryImgs hvr-grow-shadow\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 292, "\"", 316, 1);
#line 9 "C:\Users\Sasho\Desktop\MVC\MyBlog\MyBlog\MyBlog\Views\Gallery\Overview.cshtml"
WriteAttributeValue("", 298, Model[i].ImageUrl, 298, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(317, 73, true);
            WriteLiteral(" alt=\"Alternate Text\" width=\"300\" />\r\n            <div class=\"modal fade\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 390, "\"", 412, 2);
            WriteAttributeValue("", 395, "staticBackdrop-", 395, 15, true);
#line 10 "C:\Users\Sasho\Desktop\MVC\MyBlog\MyBlog\MyBlog\Views\Gallery\Overview.cshtml"
WriteAttributeValue("", 410, i, 410, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(413, 698, true);
            WriteLiteral(@" data-backdrop=""static"" tabindex=""-1"" role=""dialog"" aria-labelledby=""staticBackdropLabel"" aria-hidden=""true"">
                <div class=""modal-dialog"" role=""document"">
                    <div class=""modal-content"">
                        <div class=""modal-header"">
                            <h5 class=""modal-title"" id=""staticBackdropLabel"">Full image</h5>
                            <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                                <span aria-hidden=""true"">&times;</span>
                            </button>
                        </div>
                        <div class=""modal-body"">
                            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1111, "\"", 1135, 1);
#line 20 "C:\Users\Sasho\Desktop\MVC\MyBlog\MyBlog\MyBlog\Views\Gallery\Overview.cshtml"
WriteAttributeValue("", 1117, Model[i].ImageUrl, 1117, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1136, 18, true);
            WriteLiteral(" class=\"fullImage\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1154, "\"", 1167, 2);
            WriteAttributeValue("", 1159, "image-", 1159, 6, true);
#line 20 "C:\Users\Sasho\Desktop\MVC\MyBlog\MyBlog\MyBlog\Views\Gallery\Overview.cshtml"
WriteAttributeValue("", 1165, i, 1165, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1168, 195, true);
            WriteLiteral("/>\r\n                        </div>\r\n                        <div class=\"modal-footer\">\r\n                            <button type=\"button\" class=\"btn btn-primary\" onclick=\"ChangeImage(event, \'-\')\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1363, "\"", 1370, 1);
#line 23 "C:\Users\Sasho\Desktop\MVC\MyBlog\MyBlog\MyBlog\Views\Gallery\Overview.cshtml"
WriteAttributeValue("", 1368, i, 1368, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1371, 127, true);
            WriteLiteral(">Prevoius</button>\r\n                            <button type=\"button\" class=\"btn btn-primary\" onclick=\"ChangeImage(event, \'+\')\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1498, "\"", 1505, 1);
#line 24 "C:\Users\Sasho\Desktop\MVC\MyBlog\MyBlog\MyBlog\Views\Gallery\Overview.cshtml"
WriteAttributeValue("", 1503, i, 1503, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1506, 228, true);
            WriteLiteral(">Next</button>\r\n                            <button type=\"button\" class=\"btn btn-dark\" data-dismiss=\"modal\">Close</button>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
            EndContext();
#line 30 "C:\Users\Sasho\Desktop\MVC\MyBlog\MyBlog\MyBlog\Views\Gallery\Overview.cshtml"
        }

#line default
#line hidden
            BeginContext(1745, 10, true);
            WriteLiteral("    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<MyBlog.ViewModels.GalleryModels.OverviewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
