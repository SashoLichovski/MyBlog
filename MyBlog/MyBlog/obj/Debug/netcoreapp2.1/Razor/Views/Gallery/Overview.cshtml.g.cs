#pragma checksum "C:\Users\Sasho\Desktop\MVC\MyBlog\MyBlog\MyBlog\Views\Gallery\Overview.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d05293d2083f58cb7d3e0f1be9044860e14ec46a"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d05293d2083f58cb7d3e0f1be9044860e14ec46a", @"/Views/Gallery/Overview.cshtml")]
    public class Views_Gallery_Overview : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<MyBlog.Data.GalleryImage>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Sasho\Desktop\MVC\MyBlog\MyBlog\MyBlog\Views\Gallery\Overview.cshtml"
   
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(72, 35, true);
            WriteLiteral("\r\n    <div id=\"galleryContainer\">\r\n");
            EndContext();
#line 7 "C:\Users\Sasho\Desktop\MVC\MyBlog\MyBlog\MyBlog\Views\Gallery\Overview.cshtml"
         for (int i = 0; i < Model.Count; i++)
        {

#line default
#line hidden
            BeginContext(166, 66, true);
            WriteLiteral("            <img data-toggle=\"modal\" data-target=\"#staticBackdrop-");
            EndContext();
            BeginContext(233, 1, false);
#line 9 "C:\Users\Sasho\Desktop\MVC\MyBlog\MyBlog\MyBlog\Views\Gallery\Overview.cshtml"
                                                             Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(234, 37, true);
            WriteLiteral("\" class=\"galleryImgs hvr-grow-shadow\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 271, "\"", 295, 1);
#line 9 "C:\Users\Sasho\Desktop\MVC\MyBlog\MyBlog\MyBlog\Views\Gallery\Overview.cshtml"
WriteAttributeValue("", 277, Model[i].ImageUrl, 277, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(296, 73, true);
            WriteLiteral(" alt=\"Alternate Text\" width=\"300\" />\r\n            <div class=\"modal fade\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 369, "\"", 391, 2);
            WriteAttributeValue("", 374, "staticBackdrop-", 374, 15, true);
#line 10 "C:\Users\Sasho\Desktop\MVC\MyBlog\MyBlog\MyBlog\Views\Gallery\Overview.cshtml"
WriteAttributeValue("", 389, i, 389, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(392, 698, true);
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
            BeginWriteAttribute("src", " src=\"", 1090, "\"", 1114, 1);
#line 20 "C:\Users\Sasho\Desktop\MVC\MyBlog\MyBlog\MyBlog\Views\Gallery\Overview.cshtml"
WriteAttributeValue("", 1096, Model[i].ImageUrl, 1096, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1115, 323, true);
            WriteLiteral(@" class=""fullImage""/>
                        </div>
                        <div class=""modal-footer"">
                            <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                        </div>
                    </div>
                </div>
            </div>
");
            EndContext();
#line 28 "C:\Users\Sasho\Desktop\MVC\MyBlog\MyBlog\MyBlog\Views\Gallery\Overview.cshtml"
        }

#line default
#line hidden
            BeginContext(1449, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<MyBlog.Data.GalleryImage>> Html { get; private set; }
    }
}
#pragma warning restore 1591
