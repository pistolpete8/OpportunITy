#pragma checksum "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\Firm\SeePublishedAds.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "519e7abfc7635d8fc1f228b17040b306d472cff4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Firm_SeePublishedAds), @"mvc.1.0.view", @"/Views/Firm/SeePublishedAds.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"519e7abfc7635d8fc1f228b17040b306d472cff4", @"/Views/Firm/SeePublishedAds.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2742b0b44006567c734fc1a19e7cf221a78b9696", @"/Views/_ViewImports.cshtml")]
    public class Views_Firm_SeePublishedAds : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IOrderedEnumerable<Ads_by_firm>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\Firm\SeePublishedAds.cshtml"
  

    Layout = "~/Views/Shared/_Layout2Firm.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<table class=""table"">

    <thead>
        <tr>
            <th style=""width:15%;"">Time you published ad</th>
            <th style=""width:20%;"">Type of job</th>
            <th style=""width:20%;"">Ad profile</th>
            <th style=""width:20%;"">Edit data about ad</th>
            <th style=""width:20%;"">Delete ad</th>



        </tr>
    </thead>

");
#nullable restore
#line 22 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\Firm\SeePublishedAds.cshtml"
      
        if (Model.Count() == 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h4> You dont have any uploaded Ads</h4>\r\n            <h5> Add some ads:</h5>\r\n");
#nullable restore
#line 27 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\Firm\SeePublishedAds.cshtml"
          Write(Html.ActionLink("Add ad", "AddAd", "Firm", new { }, new { @class = " btn btn-secondary " }));

#line default
#line hidden
#nullable disable
            WriteLiteral("            <hr />\r\n");
#nullable restore
#line 29 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\Firm\SeePublishedAds.cshtml"
        }
        else
        {
            var i = 0;
            foreach (var item in Model)
            {



#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 38 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\Firm\SeePublishedAds.cshtml"
                   Write(item.time.Day);

#line default
#line hidden
#nullable disable
            WriteLiteral("-");
#nullable restore
#line 38 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\Firm\SeePublishedAds.cshtml"
                                  Write(item.time.Month);

#line default
#line hidden
#nullable disable
            WriteLiteral("-");
#nullable restore
#line 38 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\Firm\SeePublishedAds.cshtml"
                                                   Write(item.time.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 38 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\Firm\SeePublishedAds.cshtml"
                                                                   Write(item.time.Hour);

#line default
#line hidden
#nullable disable
            WriteLiteral(":");
#nullable restore
#line 38 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\Firm\SeePublishedAds.cshtml"
                                                                                   Write(item.time.Minute);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 39 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\Firm\SeePublishedAds.cshtml"
                   Write(item.typeofjob);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 40 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\Firm\SeePublishedAds.cshtml"
                   Write(Html.ActionLink("Ad profile", "AdProfile", "Firm", new { idAd = item.idad, typeofJob = item.typeofjob, email = ViewBag.Email }, new { @class = "btn btn-primary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                    <td>");
#nullable restore
#line 41 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\Firm\SeePublishedAds.cshtml"
                   Write(Html.ActionLink("Edit ad ", "EditAd", "Firm", new { idAd = item.idad, typeofJob = item.typeofjob, email = ViewBag.Email, time = item.time }, new { @class = "btn btn-primary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n\r\n                    <td> <button type=\"button\" class=\"btn btn-primary\" data-toggle=\"modal\" data-target=\"#s");
#nullable restore
#line 43 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\Firm\SeePublishedAds.cshtml"
                                                                                                      Write(i + 1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"> Delete Ad </button> </td>\r\n\r\n                </tr>\r\n");
#nullable restore
#line 46 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\Firm\SeePublishedAds.cshtml"


                i++;
            }
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
#nullable restore
#line 53 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\Firm\SeePublishedAds.cshtml"
  
    var j = 0;
    foreach (var item in Model)
    {



#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"modal fade\"");
            BeginWriteAttribute("id", " id=\"", 1784, "\"", 1798, 2);
            WriteAttributeValue("", 1789, "s", 1789, 1, true);
#nullable restore
#line 59 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\Firm\SeePublishedAds.cshtml"
WriteAttributeValue("", 1790, j + 1, 1790, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
            <div class=""modal-dialog"" role=""document"">
                <div class=""modal-content"">
                    <div class=""modal-header"">
                        <h5 class=""modal-title"" id=""exampleModalLabel"">Delete this ");
#nullable restore
#line 63 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\Firm\SeePublishedAds.cshtml"
                                                                              Write(item.typeofjob);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" ad</h5>
                        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                            <span aria-hidden=""true"">&times;</span>
                        </button>
                    </div>
                    <div class=""modal-body"">
                        Are you sure you want to delete this ad?
                    </div>
                    <div class=""modal-footer"">
                        <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>

                        ");
#nullable restore
#line 74 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\Firm\SeePublishedAds.cshtml"
                   Write(Html.ActionLink("Delete ad", "DeleteAd", "Firm", new { idAd = item.idad, typeofJob = item.typeofjob, email = ViewBag.Email, time = item.time }, new { @class = "btn btn-primary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 79 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\Firm\SeePublishedAds.cshtml"

        j++;
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- Modal -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IOrderedEnumerable<Ads_by_firm>> Html { get; private set; }
    }
}
#pragma warning restore 1591
