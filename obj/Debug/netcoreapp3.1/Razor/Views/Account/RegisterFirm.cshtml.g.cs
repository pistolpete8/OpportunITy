#pragma checksum "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\Account\RegisterFirm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "264d5619dc18270752b49bb82bdfa92172747366"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_RegisterFirm), @"mvc.1.0.view", @"/Views/Account/RegisterFirm.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"264d5619dc18270752b49bb82bdfa92172747366", @"/Views/Account/RegisterFirm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2742b0b44006567c734fc1a19e7cf221a78b9696", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_RegisterFirm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Firm>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RegisterFirm", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\Account\RegisterFirm.cshtml"
  
    ViewData["Title"] = "Register";
    Layout = "~/Views/Shared/_Layout_Register_Login.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container-fluid"">
    <div class=""row no-gutter"">
        <div class=""d-none d-md-flex col-md-4 col-lg-6 bg-image""></div>
        <div class=""col-md-8 col-lg-6"">
            <div class=""login d-flex align-items-center py-5"">
                <div class=""container"">
                    <div class=""row"">
                        <div class=""col-md-9 col-lg-8 mx-auto"">
                            <h3 class=""login-heading mb-4"">Register firm account</h3>
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "264d5619dc18270752b49bb82bdfa921727473665016", async() => {
                WriteLiteral("\r\n                                \r\n                                <div class=\"form-label-group\">\r\n\r\n                                    ");
#nullable restore
#line 20 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\Account\RegisterFirm.cshtml"
                               Write(Html.TextBoxFor(m => m.Email, new { placeholder = "Email", @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    ");
#nullable restore
#line 21 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\Account\RegisterFirm.cshtml"
                               Write(Html.ValidationMessageFor(m => m.Email, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                                </div>\r\n                                \r\n                                <div class=\"form-label-group\">\r\n\r\n                                    ");
#nullable restore
#line 27 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\Account\RegisterFirm.cshtml"
                               Write(Html.PasswordFor(m => m.Password, new { placeholder = "Password", @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    ");
#nullable restore
#line 28 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\Account\RegisterFirm.cshtml"
                               Write(Html.ValidationMessageFor(m => m.Password, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                                </div>\r\n                                \r\n                                <div class=\"form-label-group\">\r\n\r\n                                    ");
#nullable restore
#line 34 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\Account\RegisterFirm.cshtml"
                               Write(Html.PasswordFor(m => m.ConfirmPassword, new { placeholder = " Confirm Password", @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    ");
#nullable restore
#line 35 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\Account\RegisterFirm.cshtml"
                               Write(Html.ValidationMessageFor(m => m.ConfirmPassword, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

                                </div>

                                <div class=""custom-control custom-checkbox mb-3"">
                                    <input type=""checkbox"" class=""custom-control-input"" id=""customCheck1"">
                                    <label class=""custom-control-label"" for=""customCheck1"">Remember password</label>
                                </div>
                                <button class=""btn btn-lg btn-primary btn-block btn-login text-uppercase font-weight-bold mb-2"" type=""submit"">Register</button>

                                <div class=""text-center"">
                                    <a class=""small"" href=""#"">Forgot password?</a>
                                </div>
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

   

</div>

<style>
    :root {
  --input-padding-x: 1.5rem;
  --input-padding-y: 0.75rem;
}

.login,
.image {
  min-height: 100vh;
}

.bg-image { background-image: url('https://cdn1.photostockeditor.com/c/1512/building-blue-and-white-building-office%20building-office%20building-image.jpg'); background-size: cover; background-position: center; }

.login-heading {
  font-weight: 300;
}

.btn-login {
  font-size: 0.9rem;
  letter-spacing: 0.05rem;
  padding: 0.75rem 1rem;
  border-radius: 2rem;
}

.form-label-group {
  position: relative;
  margin-bottom: 1rem;
}



.form-label-group>label {
  position: absolute;
  top: 0;
  left: 0;
  display: block;
  width: 100%;
  margin-bottom: 0;
  /* Override default `<label>` margin */
  line-height: 1.5;
  color: #495057;
  cursor: text;
  /* Match the input under the label */
  border: 1");
            WriteLiteral("px solid transparent;\r\n  border-radius: .25rem;\r\n  transition: all .1s ease-in-out;\r\n}\r\n\r\n\r\n\r\n\r\n</style>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Firm> Html { get; private set; }
    }
}
#pragma warning restore 1591
