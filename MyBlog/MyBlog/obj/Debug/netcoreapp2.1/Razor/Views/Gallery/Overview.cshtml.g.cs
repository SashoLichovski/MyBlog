#pragma checksum "C:\Users\Sasho\Desktop\MVC\MyBlog\MyBlog\MyBlog\Views\Gallery\Overview.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b892e7d93e3217e3101dd68a19e425d4edc4214"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b892e7d93e3217e3101dd68a19e425d4edc4214", @"/Views/Gallery/Overview.cshtml")]
    public class Views_Gallery_Overview : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<MyBlog.Models.GalleryImage>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Sasho\Desktop\MVC\MyBlog\MyBlog\MyBlog\Views\Gallery\Overview.cshtml"
   
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(74, 35, true);
            WriteLiteral("\r\n    <div id=\"galleryContainer\">\r\n");
            EndContext();
#line 7 "C:\Users\Sasho\Desktop\MVC\MyBlog\MyBlog\MyBlog\Views\Gallery\Overview.cshtml"
         for (int i = 0; i < Model.Count; i++)
        {

#line default
#line hidden
            BeginContext(168, 66, true);
            WriteLiteral("            <img data-toggle=\"modal\" data-target=\"#staticBackdrop-");
            EndContext();
            BeginContext(235, 1, false);
#line 9 "C:\Users\Sasho\Desktop\MVC\MyBlog\MyBlog\MyBlog\Views\Gallery\Overview.cshtml"
                                                             Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(236, 37, true);
            WriteLiteral("\" class=\"galleryImgs hvr-grow-shadow\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 273, "\"", 297, 1);
#line 9 "C:\Users\Sasho\Desktop\MVC\MyBlog\MyBlog\MyBlog\Views\Gallery\Overview.cshtml"
WriteAttributeValue("", 279, Model[i].ImageUrl, 279, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(298, 73, true);
            WriteLiteral(" alt=\"Alternate Text\" width=\"300\" />\r\n            <div class=\"modal fade\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 371, "\"", 393, 2);
            WriteAttributeValue("", 376, "staticBackdrop-", 376, 15, true);
#line 10 "C:\Users\Sasho\Desktop\MVC\MyBlog\MyBlog\MyBlog\Views\Gallery\Overview.cshtml"
WriteAttributeValue("", 391, i, 391, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(394, 698, true);
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
            BeginWriteAttribute("src", " src=\"", 1092, "\"", 1116, 1);
#line 20 "C:\Users\Sasho\Desktop\MVC\MyBlog\MyBlog\MyBlog\Views\Gallery\Overview.cshtml"
WriteAttributeValue("", 1098, Model[i].ImageUrl, 1098, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1117, 306, true);
            WriteLiteral(@" />
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
            BeginContext(1434, 8, true);
            WriteLiteral("        ");
            EndContext();
#line 29 "C:\Users\Sasho\Desktop\MVC\MyBlog\MyBlog\MyBlog\Views\Gallery\Overview.cshtml"
         foreach (var image in Model)
        {
        }

#line default
#line hidden
            BeginContext(1495, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<MyBlog.Models.GalleryImage>> Html { get; private set; }
    }
}
#pragma warning restore 1591
