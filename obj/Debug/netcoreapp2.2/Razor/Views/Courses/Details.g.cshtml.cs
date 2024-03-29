#pragma checksum "/Users/Guest/Desktop/UniversityRegistrar/Views/Courses/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "81c4f6df01783de37cace15ae18d457dab2685c4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Courses_Details), @"mvc.1.0.view", @"/Views/Courses/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Courses/Details.cshtml", typeof(AspNetCore.Views_Courses_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81c4f6df01783de37cace15ae18d457dab2685c4", @"/Views/Courses/Details.cshtml")]
    public class Views_Courses_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Registrar.Models.Course>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/Guest/Desktop/UniversityRegistrar/Views/Courses/Details.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(60, 36, true);
            WriteLiteral("\n<h2>Course Details</h2>\n<hr />\n<h3>");
            EndContext();
            BeginContext(97, 40, false);
#line 9 "/Users/Guest/Desktop/UniversityRegistrar/Views/Courses/Details.cshtml"
Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(137, 2, true);
            WriteLiteral(": ");
            EndContext();
            BeginContext(140, 36, false);
#line 9 "/Users/Guest/Desktop/UniversityRegistrar/Views/Courses/Details.cshtml"
                                          Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(176, 7, true);
            WriteLiteral("</h3>\n\n");
            EndContext();
#line 11 "/Users/Guest/Desktop/UniversityRegistrar/Views/Courses/Details.cshtml"
 if(@Model.Students.Count == 0)
{

#line default
#line hidden
            BeginContext(217, 51, true);
            WriteLiteral("  <p>This course does not contain any students</p>\n");
            EndContext();
#line 14 "/Users/Guest/Desktop/UniversityRegistrar/Views/Courses/Details.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(277, 48, true);
            WriteLiteral("  <h4>Students the course contains:</h4>\n  <ul>\n");
            EndContext();
#line 19 "/Users/Guest/Desktop/UniversityRegistrar/Views/Courses/Details.cshtml"
   foreach(var join in Model.Students)
  {

#line default
#line hidden
            BeginContext(368, 8, true);
            WriteLiteral("    <li>");
            EndContext();
            BeginContext(377, 17, false);
#line 21 "/Users/Guest/Desktop/UniversityRegistrar/Views/Courses/Details.cshtml"
   Write(join.Student.Name);

#line default
#line hidden
            EndContext();
            BeginContext(394, 6, true);
            WriteLiteral("</li>\n");
            EndContext();
#line 22 "/Users/Guest/Desktop/UniversityRegistrar/Views/Courses/Details.cshtml"
  }

#line default
#line hidden
            BeginContext(404, 8, true);
            WriteLiteral("  </ul>\n");
            EndContext();
#line 24 "/Users/Guest/Desktop/UniversityRegistrar/Views/Courses/Details.cshtml"
}

#line default
#line hidden
            BeginContext(414, 4, true);
            WriteLiteral("\n<p>");
            EndContext();
            BeginContext(419, 43, false);
#line 26 "/Users/Guest/Desktop/UniversityRegistrar/Views/Courses/Details.cshtml"
Write(Html.ActionLink("Back to courses", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(462, 8, true);
            WriteLiteral("</p>\n<p>");
            EndContext();
            BeginContext(471, 67, false);
#line 27 "/Users/Guest/Desktop/UniversityRegistrar/Views/Courses/Details.cshtml"
Write(Html.ActionLink("Edit Course", "Edit", new { id = Model.CourseId }));

#line default
#line hidden
            EndContext();
            BeginContext(538, 8, true);
            WriteLiteral("</p>\n<p>");
            EndContext();
            BeginContext(547, 71, false);
#line 28 "/Users/Guest/Desktop/UniversityRegistrar/Views/Courses/Details.cshtml"
Write(Html.ActionLink("Delete Course", "Delete", new { id = Model.CourseId }));

#line default
#line hidden
            EndContext();
            BeginContext(618, 4, true);
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Registrar.Models.Course> Html { get; private set; }
    }
}
#pragma warning restore 1591
