#pragma checksum "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\Firm\AdProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "35e8be7220516011ba04497f11752d98153ceb86"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Firm_AdProfile), @"mvc.1.0.view", @"/Views/Firm/AdProfile.cshtml")]
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
#line 1 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\_ViewImports.cshtml"
using OpportunITyy;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\_ViewImports.cshtml"
using OpportunITyy.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35e8be7220516011ba04497f11752d98153ceb86", @"/Views/Firm/AdProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2742b0b44006567c734fc1a19e7cf221a78b9696", @"/Views/_ViewImports.cshtml")]
    public class Views_Firm_AdProfile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Ad>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\Firm\AdProfile.cshtml"
  


    Layout = "~/Views/Shared/_Layout2Firm.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<meta name=\"author\"");
            BeginWriteAttribute("content", " content=\"", 93, "\"", 103, 0);
            EndWriteAttribute();
            WriteLiteral(@">
<link rel=""icon"" href=""/docs/4.0/assets/img/favicons/favicon.ico"">

<link rel=""canonical"" href=""https://getbootstrap.com/docs/4.0/examples/cover/"">
<link href=""../../dist/css/bootstrap.min.css"" rel=""stylesheet"">
<link href=""cover.css"" rel=""stylesheet"">
 

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "35e8be7220516011ba04497f11752d98153ceb864160", async() => {
                WriteLiteral(@"

    <div class=""cover-container d-flex h-100 p-3 mx-auto flex-column"">
        <header class=""masthead mb-auto"">
            <div class=""inner"">
                <h3 class=""masthead-brand"">Skills required</h3>
                <div class=""span_box justify-content-center"">

");
#nullable restore
#line 23 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\Firm\AdProfile.cshtml"
                     foreach (var skill in Model.Technologies)
                    {

                        var random = new Random();
                        var color = String.Format("#{0:X6}", random.Next(0x1000000));


#line default
#line hidden
#nullable disable
                WriteLiteral("                        <span class=\"badge rounded-pill span_element\"");
                BeginWriteAttribute("style", " style=\"", 977, "\"", 1056, 6);
                WriteAttributeValue("", 985, "background-color:", 985, 17, true);
#nullable restore
#line 29 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\Firm\AdProfile.cshtml"
WriteAttributeValue(" ", 1002, color, 1003, 6, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1009, ";", 1009, 1, true);
                WriteAttributeValue(" ", 1010, "width:120px;", 1011, 13, true);
                WriteAttributeValue(" ", 1023, "padding-left:10px;", 1024, 19, true);
                WriteAttributeValue("  ", 1042, "color:white;", 1044, 14, true);
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 29 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\Firm\AdProfile.cshtml"
                                                                                                                                                 Write(skill);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n");
#nullable restore
#line 30 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\Firm\AdProfile.cshtml"

                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </div>\r\n\r\n                <nav class=\"nav nav-masthead justify-content-center\">\r\n\r\n                    <a class=\"nav-link\"> <strong>Added by: </strong></a>\r\n                    <a class=\"nav-link active\" href=\"#\"> ");
#nullable restore
#line 37 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\Firm\AdProfile.cshtml"
                                                    Write(Model.EmailFirm);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n                    <a class=\"nav-link\"> <strong> Dated added:</strong> ");
#nullable restore
#line 38 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\Firm\AdProfile.cshtml"
                                                                   Write(Model.AdSetted);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n                </nav>\r\n            </div>\r\n        </header>\r\n\r\n        <main role=\"main\" class=\"inner cover\">\r\n\r\n");
#nullable restore
#line 45 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\Firm\AdProfile.cshtml"
             if (Model.TypeOfJob == "Programming")
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("<h1 class=\"cover-heading text-danger\">");
#nullable restore
#line 46 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\Firm\AdProfile.cshtml"
                                              Write(Model.TypeOfJob);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1> ");
#nullable restore
#line 46 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\Firm\AdProfile.cshtml"
                                                                         }
        else if (Model.TypeOfJob == "Practise")
        {

#line default
#line hidden
#nullable disable
                WriteLiteral(" <h1 class=\"cover-heading text-success\">");
#nullable restore
#line 48 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\Firm\AdProfile.cshtml"
                                            Write(Model.TypeOfJob);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>");
#nullable restore
#line 48 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\Firm\AdProfile.cshtml"
                                                                      }
    else if (Model.TypeOfJob == "Menagment")
    {

#line default
#line hidden
#nullable disable
                WriteLiteral(" <h1 class=\"cover-heading text-primary\">");
#nullable restore
#line 50 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\Firm\AdProfile.cshtml"
                                        Write(Model.TypeOfJob);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>");
#nullable restore
#line 50 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\Firm\AdProfile.cshtml"
                                                                  }
else if (Model.TypeOfJob == "UX designer")
{

#line default
#line hidden
#nullable disable
                WriteLiteral(" <h1 class=\"cover-heading text-info\">");
#nullable restore
#line 52 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\Firm\AdProfile.cshtml"
                                 Write(Model.TypeOfJob);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>");
#nullable restore
#line 52 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\Firm\AdProfile.cshtml"
                                                           }
else if (Model.TypeOfJob == "Support")
{

#line default
#line hidden
#nullable disable
                WriteLiteral(" <h1 class=\"cover-heading text-warning\">");
#nullable restore
#line 54 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\Firm\AdProfile.cshtml"
                                    Write(Model.TypeOfJob);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>");
#nullable restore
#line 54 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\Firm\AdProfile.cshtml"
                                                              }
else
{

#line default
#line hidden
#nullable disable
                WriteLiteral("<h1 class=\"cover-heading text-secondary\">");
#nullable restore
#line 56 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\Firm\AdProfile.cshtml"
                                     Write(Model.TypeOfJob);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>");
#nullable restore
#line 56 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\Firm\AdProfile.cshtml"
                                                               }

#line default
#line hidden
#nullable disable
                WriteLiteral("            <hr />\r\n            <h5 class=\"cover-heading\">");
#nullable restore
#line 58 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\Firm\AdProfile.cshtml"
                                 Write(Model.TypeOfWork);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </h5>\r\n\r\n\r\n");
#nullable restore
#line 61 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\Firm\AdProfile.cshtml"
             if (Model.Description == "")
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("<p class=\"lead\">Firm posted ad for position: ");
#nullable restore
#line 62 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\Firm\AdProfile.cshtml"
                                                     Write(Model.TypeOfJob);

#line default
#line hidden
#nullable disable
                WriteLiteral(" with seniority: ");
#nullable restore
#line 62 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\Firm\AdProfile.cshtml"
                                                                                      Write(Model.Seniority);

#line default
#line hidden
#nullable disable
                WriteLiteral(" working: ");
#nullable restore
#line 62 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\Firm\AdProfile.cshtml"
                                                                                                                Write(Model.TypeOfWork);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>");
#nullable restore
#line 62 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\Firm\AdProfile.cshtml"
                                                                                                                                          }
        else
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("<p class=\"lead\"> ");
#nullable restore
#line 64 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\Firm\AdProfile.cshtml"
                     Write(Model.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>");
#nullable restore
#line 64 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\Firm\AdProfile.cshtml"
                                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            <p class=\"lead\"> <strong>Firm location </strong>: ");
#nullable restore
#line 65 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\Firm\AdProfile.cshtml"
                                                         Write(Model.City);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </p>\r\n");
#nullable restore
#line 66 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\Firm\AdProfile.cshtml"
             if (Model.OnlineInterView == true)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("<p class=\"lead\"> Interview is online! </p>");
#nullable restore
#line 67 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\Firm\AdProfile.cshtml"
                                                       }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n        </main>\r\n\r\n\r\n\r\n");
#nullable restore
#line 74 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\Firm\AdProfile.cshtml"
         if (Model.AppliedUsers.Count() == 0)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <h3> No one applied to this ad</h3>\r\n            <hr />\r\n");
#nullable restore
#line 78 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\Firm\AdProfile.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"    <table class=""table"">

        <thead>
            <tr>
                <th style=""width:15%;"">First name</th>
                <th style=""width:20%;"">Last name</th>
                <th style=""width:20%;"">Email </th>
                <th style=""width:20%;"">Date applied</th>
                <th style=""width:20%;"">User profile</th>
                <th style=""width:20%;""> CV</th>




            </tr>
        </thead>




");
#nullable restore
#line 101 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\Firm\AdProfile.cshtml"
         foreach (var item in Model.AppliedUsers)
        {



#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr>\r\n\r\n                <td>");
#nullable restore
#line 107 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\Firm\AdProfile.cshtml"
               Write(item.Fname);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 108 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\Firm\AdProfile.cshtml"
               Write(item.Lname);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 109 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\Firm\AdProfile.cshtml"
               Write(item.Email);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 110 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\Firm\AdProfile.cshtml"
               Write(item.Time.Day);

#line default
#line hidden
#nullable disable
                WriteLiteral("-");
#nullable restore
#line 110 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\Firm\AdProfile.cshtml"
                              Write(item.Time.Month);

#line default
#line hidden
#nullable disable
                WriteLiteral("-");
#nullable restore
#line 110 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\Firm\AdProfile.cshtml"
                                               Write(item.Time.Year);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 110 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\Firm\AdProfile.cshtml"
                                                               Write(item.Time.Hour);

#line default
#line hidden
#nullable disable
                WriteLiteral(":");
#nullable restore
#line 110 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\Firm\AdProfile.cshtml"
                                                                               Write(item.Time.Minute);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 111 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\Firm\AdProfile.cshtml"
               Write(Html.ActionLink("User Profile", "UserProfile", "Firm", new { email = item.Email }, new { @class = "btn btn-primary" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(" </td>\r\n                <td>");
#nullable restore
#line 112 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\Firm\AdProfile.cshtml"
               Write(Html.ActionLink("CV", "ViewCv", "Firm", new { cvpath = item.CvPath }, new { @class = "btn btn-primary" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(" </td>\r\n\r\n\r\n\r\n\r\n            </tr>\r\n");
#nullable restore
#line 118 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\Firm\AdProfile.cshtml"

            

        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </table>\r\n");
#nullable restore
#line 123 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\Firm\AdProfile.cshtml"
    
        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

    


    </div>


    <!-- Bootstrap core JavaScript
    ================================================== -->
    <!-- Placed at the end of the document so the pages load faster -->
    <script src=""https://code.jquery.com/jquery-3.2.1.slim.min.js"" integrity=""sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN"" crossorigin=""anonymous""></script>
    <script>window.jQuery || document.write('<script src=""../../assets/js/vendor/jquery-slim.min.js""><\/script>')</script>
    <script src=""../../assets/js/vendor/popper.min.js""></script>
    <script src=""../../dist/js/bootstrap.min.js""></script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<style>
    .button_ad {
        width: fit-content;
    }

    .span_box {
        display: flex;
        flex-direction: row;
    }

    .span_element {
        width: 50px;
        margin-left: 10px;
        max-width: 80px;
        max-height: 35px;
        font-size: 16px;
        box-sizing:border-box;
    }

    .btn_typeJob {
        margin-left: 10px;
        margin-bottom: 20px;
    }

    .ad_new {
        width: 100%;
        border-radius: 3rem;
        margin-bottom: 20px;
    }
</style>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Ad> Html { get; private set; }
    }
}
#pragma warning restore 1591