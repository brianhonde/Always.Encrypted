#pragma checksum "C:\Users\khaled.elsheikh\source\repos\Always.Encrypted\Always.Encrypted.Web\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "035c9877da06bfa10ec12a4be7996c21d19b3e73"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\khaled.elsheikh\source\repos\Always.Encrypted\Always.Encrypted.Web\Views\_ViewImports.cshtml"
using Always.Encrypted.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\khaled.elsheikh\source\repos\Always.Encrypted\Always.Encrypted.Web\Views\_ViewImports.cshtml"
using Always.Encrypted.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"035c9877da06bfa10ec12a4be7996c21d19b3e73", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06732ecfd8465f4677bcbeeb832d7d229e15617c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ClientInfo>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\khaled.elsheikh\source\repos\Always.Encrypted\Always.Encrypted.Web\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""text-center"">
    <h6 style=""margin-bottom:100px;margin-top:50px"">Welcome to Always Encrypted Application</h6>
</div>
<div class=""row"">
    <div class=""col-md-2"">
        <p>Client Name:</p>
    </div>
    <div class=""col-md-3"">
        <input type=""text"" id=""clientName"" maxlength=""50"" />
    </div>
    <div class=""col-md-2"">
        <p>Visa No:</p>
    </div>
    <div class=""col-md-3"">
        <input type=""text"" id=""visaNo"" maxlength=""16"" />
    </div>
    <div class=""col-md-2"">
        <input type=""button"" id=""btnAddNewClient"" value=""Add!"" onclick=""addNewClient()"" />
    </div>
</div>
<div id=""clientInfo"">
    ");
#nullable restore
#line 26 "C:\Users\khaled.elsheikh\source\repos\Always.Encrypted\Always.Encrypted.Web\Views\Home\Index.cshtml"
Write(await Html.PartialAsync("~/Views/Home/_PartialViewClientData.cshtml", Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script type=""text/javascript"">
        function addNewClient() {
            var clientName = $(""#clientName"").val();
            var visaNo = $(""#visaNo"").val();
            if (clientName.length < 1 || visaNo.length < 1) {
                alert('incomplete data!');
                return;
            }

            var newClientObj = {
                ClientName: clientName,
                VisaNo: visaNo
            };

            $.ajax({
                //base address/controller/Action
                url: '");
#nullable restore
#line 46 "C:\Users\khaled.elsheikh\source\repos\Always.Encrypted\Always.Encrypted.Web\Views\Home\Index.cshtml"
                 Write(Url.Action("AddClientData", "Home"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                dataType: ""json"",
                type: 'POST',
                data: newClientObj,
                success: function (returnedValue) {
                    //write something as it went wrong
                    getClientData();
                },
                error: function (ex) {
                    console.log(ex);
                    alert(ex);
                    alert(""Error Occured"");
                }
            });
        }

       function getClientData() {
            $.ajax({
                //base address/controller/Action
                url: '");
#nullable restore
#line 65 "C:\Users\khaled.elsheikh\source\repos\Always.Encrypted\Always.Encrypted.Web\Views\Home\Index.cshtml"
                 Write(Url.Action("_PartialViewClientData", "Home"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                type: 'GET',
                success: function (html) {
                    //write something as it went wrong
                    $('#clientInfo').html(html);
                },
                error: function (ex) {
                    console.log(ex);
                    alert(ex);
                    alert(""Error Occured"");
                }
            });
        }

    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ClientInfo>> Html { get; private set; }
    }
}
#pragma warning restore 1591
