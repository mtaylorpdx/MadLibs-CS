#pragma checksum "/Users/Guest/Desktop/MadLibs.Solutions/MadLib/Views/Home/Zoo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc0f71e11ae34b2f653ce311ff1e770f90d45f92"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Zoo), @"mvc.1.0.view", @"/Views/Home/Zoo.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Zoo.cshtml", typeof(AspNetCore.Views_Home_Zoo))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc0f71e11ae34b2f653ce311ff1e770f90d45f92", @"/Views/Home/Zoo.cshtml")]
    public class Views_Home_Zoo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 26, true);
            WriteLiteral("<!DOCTYPE html> \n<html>\n  ");
            EndContext();
            BeginContext(26, 151, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc0f71e11ae34b2f653ce311ff1e770f90d45f922819", async() => {
                BeginContext(32, 138, true);
                WriteLiteral("\n    <title>Zoo Madlib</title>\n    <link rel=\'stylesheet\' href=\'https://maxcdn.bootstrapcdn.com/bootstrap/3.2.0/css/bootstrap.min.css\'>\n  ");
                EndContext();
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
            EndContext();
            BeginContext(177, 3, true);
            WriteLiteral("\n  ");
            EndContext();
            BeginContext(180, 732, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc0f71e11ae34b2f653ce311ff1e770f90d45f924122", async() => {
                BeginContext(186, 122, true);
                WriteLiteral("\n    <div class=\"container\">\n      <h3><center>Zoo Lib</center></h3>\n      <p>Today I went to the zoo. I saw a(n)\n        ");
                EndContext();
                BeginContext(309, 15, false);
#line 11 "/Users/Guest/Desktop/MadLibs.Solutions/MadLib/Views/Home/Zoo.cshtml"
   Write(Model.Adjective);

#line default
#line hidden
                EndContext();
                BeginContext(324, 9, true);
                WriteLiteral("\n        ");
                EndContext();
                BeginContext(334, 10, false);
#line 12 "/Users/Guest/Desktop/MadLibs.Solutions/MadLib/Views/Home/Zoo.cshtml"
   Write(Model.Noun);

#line default
#line hidden
                EndContext();
                BeginContext(344, 45, true);
                WriteLiteral(" jumping up and down in its tree.\n        He ");
                EndContext();
                BeginContext(390, 10, false);
#line 13 "/Users/Guest/Desktop/MadLibs.Solutions/MadLib/Views/Home/Zoo.cshtml"
      Write(Model.Verb);

#line default
#line hidden
                EndContext();
                BeginContext(400, 51, true);
                WriteLiteral(" \n        through the large tunnel that led to its ");
                EndContext();
                BeginContext(452, 15, false);
#line 14 "/Users/Guest/Desktop/MadLibs.Solutions/MadLib/Views/Home/Zoo.cshtml"
                                            Write(Model.Adjective);

#line default
#line hidden
                EndContext();
                BeginContext(467, 9, true);
                WriteLiteral("\n        ");
                EndContext();
                BeginContext(477, 10, false);
#line 15 "/Users/Guest/Desktop/MadLibs.Solutions/MadLib/Views/Home/Zoo.cshtml"
   Write(Model.Noun);

#line default
#line hidden
                EndContext();
                BeginContext(487, 82, true);
                WriteLiteral(" . I got some peanuts and passed\n        them through the cage to a gigantic gray ");
                EndContext();
                BeginContext(570, 10, false);
#line 16 "/Users/Guest/Desktop/MadLibs.Solutions/MadLib/Views/Home/Zoo.cshtml"
                                            Write(Model.Noun);

#line default
#line hidden
                EndContext();
                BeginContext(580, 93, true);
                WriteLiteral("\n        towering above my head. Feeding that animal made\n        me hungry. I went to get a ");
                EndContext();
                BeginContext(674, 15, false);
#line 18 "/Users/Guest/Desktop/MadLibs.Solutions/MadLib/Views/Home/Zoo.cshtml"
                              Write(Model.Adjective);

#line default
#line hidden
                EndContext();
                BeginContext(689, 79, true);
                WriteLiteral(" scoop\n        of ice cream. It filled my stomach. Afterwards I had to\n        ");
                EndContext();
                BeginContext(769, 10, false);
#line 20 "/Users/Guest/Desktop/MadLibs.Solutions/MadLib/Views/Home/Zoo.cshtml"
   Write(Model.Verb);

#line default
#line hidden
                EndContext();
                BeginContext(779, 45, true);
                WriteLiteral(" to catch our bus.\n        When I got home I ");
                EndContext();
                BeginContext(825, 10, false);
#line 21 "/Users/Guest/Desktop/MadLibs.Solutions/MadLib/Views/Home/Zoo.cshtml"
                     Write(Model.Verb);

#line default
#line hidden
                EndContext();
                BeginContext(835, 19, true);
                WriteLiteral("\n        mom for a ");
                EndContext();
                BeginContext(855, 15, false);
#line 22 "/Users/Guest/Desktop/MadLibs.Solutions/MadLib/Views/Home/Zoo.cshtml"
             Write(Model.Adjective);

#line default
#line hidden
                EndContext();
                BeginContext(870, 35, true);
                WriteLiteral(" day at the zoo. </p>\n    </div>\n  ");
                EndContext();
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
            EndContext();
            BeginContext(912, 8, true);
            WriteLiteral("\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
