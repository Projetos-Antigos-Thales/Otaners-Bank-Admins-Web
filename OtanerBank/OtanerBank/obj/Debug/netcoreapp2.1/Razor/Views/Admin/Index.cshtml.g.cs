#pragma checksum "C:\projects\OtanersBank\admins.web\OtanerBank\OtanerBank\Views\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb3be8acc3f4b1cc8d0a4ddef495209b5c1a0526"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Index), @"mvc.1.0.view", @"/Views/Admin/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/Index.cshtml", typeof(AspNetCore.Views_Admin_Index))]
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
#line 1 "C:\projects\OtanersBank\admins.web\OtanerBank\OtanerBank\Views\_ViewImports.cshtml"
using OtanerBank;

#line default
#line hidden
#line 2 "C:\projects\OtanersBank\admins.web\OtanerBank\OtanerBank\Views\_ViewImports.cshtml"
using OtanerBank.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb3be8acc3f4b1cc8d0a4ddef495209b5c1a0526", @"/Views/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac29637e3f573f215dc10dc5796fed518f2e9702", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<OtanerBank.Models.Client>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(39, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\projects\OtanersBank\admins.web\OtanerBank\OtanerBank\Views\Admin\Index.cshtml"
  
    ViewData["Title"] = "Dashboard";

#line default
#line hidden
            BeginContext(86, 255, true);
            WriteLiteral("\r\n<br />\r\n\r\n<style>\r\n    .MinimizeButton {\r\n        margin-top: 0;\r\n        font-weight: bold;\r\n        font-size: large;\r\n        cursor: pointer;\r\n    }\r\n\r\n    a {\r\n        cursor: pointer;\r\n        text-decoration: none !important;\r\n    }\r\n</style>\r\n\r\n");
            EndContext();
#line 23 "C:\projects\OtanersBank\admins.web\OtanerBank\OtanerBank\Views\Admin\Index.cshtml"
 if (Model != null)
{


#line default
#line hidden
            BeginContext(367, 351, true);
            WriteLiteral(@"    <div class=""container"">

        <!--DASH-->
        <div class=""row"">

            <div class=""col-md-2""></div>

            <div id=""DivClients0"" class=""col-md-2 alert alert-info"" role=""alert"">
                <div class=""row"">

                    <div id=""Clients0"" class=""col-md-10"">
                        <h4 id=""txtQte"">Total: ");
            EndContext();
            BeginContext(719, 11, false);
#line 37 "C:\projects\OtanersBank\admins.web\OtanerBank\OtanerBank\Views\Admin\Index.cshtml"
                                          Write(Model.Count);

#line default
#line hidden
            EndContext();
            BeginContext(730, 2499, true);
            WriteLiteral(@"</h4>
                    </div>

                    <div style=""float: right;"" class=""col-md-2"">
                        <h5 id=""Minimize0"" onclick=""MinimizeClient('0');"" class=""MinimizeButton"">&times;</h5>
                    </div>

                    <div id=""LinkClients0"" class=""col-md-12"">
                        <a class=""alert-link"">show all</a>
                    </div>

                </div>
            </div>

            <div class=""col-md-1""></div>

            <div id=""DivClients1"" class=""col-md-2 alert alert-danger"" role=""alert"">
                <div class=""row"">

                    <div id=""Clients1"" class=""col-md-10"">
                        <h4 id=""txtQteInactives""></h4>
                    </div>

                    <div style=""float: right;"" class=""col-md-2"">
                        <h5 id=""Minimize1"" onclick=""MinimizeClient('1');"" class=""MinimizeButton"">&times;</h5>
                    </div>

                    <div id=""LinkClients1"" class=""col-md-12"">
");
            WriteLiteral(@"                        <a class=""alert-link"">show only inactive</a>
                    </div>

                </div>
            </div>

            <div class=""col-md-1""></div>

            <div id=""DivClients2"" class=""col-md-2 alert alert-success"">
                <div class=""row"">


                    <div id=""Clients2"" class=""col-md-10"">
                        <h4 id=""txtQteActives""></h4>
                    </div>

                    <div style=""float: right;"" class=""col-md-2"">
                        <h5 id=""Minimize2"" onclick=""MinimizeClient('2');"" class=""MinimizeButton"">&times;</h5>
                    </div>

                    <div id=""LinkClients2"" class=""col-md-12"">
                        <a class=""alert-link"">show only active</a>
                    </div>

                </div>
            </div>

            <div class=""col-md-2""></div>

        </div>

        <br />

        <!--SEARCH BAR-->
        <div class=""row"">
            <div class=""col-md-");
            WriteLiteral(@"4""></div>
            <div class=""col-md-4"" style=""text-align: center;"">
                <input type=""search"" name=""search"" id=""search_Pergunta"" oninput=""search()"" placeholder=""Search Client"" style=""width:100%; padding:5px; border:solid; border-color: #eee;
        border-width: 1px;""> <br><br>
            </div>
            <div class=""col-md-4""></div>
        </div>

        <br />

        <!--CLIENTS-->
        <div class=""row"">

");
            EndContext();
#line 113 "C:\projects\OtanersBank\admins.web\OtanerBank\OtanerBank\Views\Admin\Index.cshtml"
             foreach (var item in Model)
            {


#line default
#line hidden
            BeginContext(3288, 235, true);
            WriteLiteral("                <div class=\"col-md-4\" style=\"margin-bottom:3%;\">\r\n                    <div class=\"list-group-item list-group-item-action flex-column align-items-center\">\r\n\r\n                        <h5>\r\n                            ID: ");
            EndContext();
            BeginContext(3524, 37, false);
#line 120 "C:\projects\OtanersBank\admins.web\OtanerBank\OtanerBank\Views\Admin\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.id));

#line default
#line hidden
            EndContext();
            BeginContext(3561, 102, true);
            WriteLiteral("\r\n                        </h5>\r\n\r\n                        <h5>\r\n                            Account: ");
            EndContext();
            BeginContext(3664, 42, false);
#line 124 "C:\projects\OtanersBank\admins.web\OtanerBank\OtanerBank\Views\Admin\Index.cshtml"
                                Write(Html.DisplayFor(modelItem => item.ACCOUNT));

#line default
#line hidden
            EndContext();
            BeginContext(3706, 98, true);
            WriteLiteral("\r\n                        </h5>\r\n\r\n                        <h5>\r\n                            CPF: ");
            EndContext();
            BeginContext(3805, 38, false);
#line 128 "C:\projects\OtanersBank\admins.web\OtanerBank\OtanerBank\Views\Admin\Index.cshtml"
                            Write(Html.DisplayFor(modelItem => item.CPF));

#line default
#line hidden
            EndContext();
            BeginContext(3843, 99, true);
            WriteLiteral("\r\n                        </h5>\r\n\r\n                        <h5>\r\n                            Name: ");
            EndContext();
            BeginContext(3943, 39, false);
#line 132 "C:\projects\OtanersBank\admins.web\OtanerBank\OtanerBank\Views\Admin\Index.cshtml"
                             Write(Html.DisplayFor(modelItem => item.NAME));

#line default
#line hidden
            EndContext();
            BeginContext(3982, 102, true);
            WriteLiteral("\r\n                        </h5>\r\n\r\n                        <h5>\r\n                            Balance: ");
            EndContext();
            BeginContext(4085, 42, false);
#line 136 "C:\projects\OtanersBank\admins.web\OtanerBank\OtanerBank\Views\Admin\Index.cshtml"
                                Write(Html.DisplayFor(modelItem => item.BALANCE));

#line default
#line hidden
            EndContext();
            BeginContext(4127, 150, true);
            WriteLiteral("\r\n                        </h5>\r\n\r\n\r\n\r\n\r\n                        <p style=\"float:right;\">\r\n                            |\r\n                            ");
            EndContext();
            BeginContext(4278, 55, false);
#line 144 "C:\projects\OtanersBank\admins.web\OtanerBank\OtanerBank\Views\Admin\Index.cshtml"
                       Write(Html.ActionLink("Edit", "Edit", new { CPF = item.CPF }));

#line default
#line hidden
            EndContext();
            BeginContext(4333, 32, true);
            WriteLiteral(" |\r\n                            ");
            EndContext();
            BeginContext(4366, 61, false);
#line 145 "C:\projects\OtanersBank\admins.web\OtanerBank\OtanerBank\Views\Admin\Index.cshtml"
                       Write(Html.ActionLink("Details", "Details", new { CPF = item.CPF }));

#line default
#line hidden
            EndContext();
            BeginContext(4427, 8, true);
            WriteLiteral(" |\r\n\r\n\r\n");
            EndContext();
#line 148 "C:\projects\OtanersBank\admins.web\OtanerBank\OtanerBank\Views\Admin\Index.cshtml"
                             if (item.STATUS == "1")
                            {
                                

#line default
#line hidden
            BeginContext(4553, 63, false);
#line 150 "C:\projects\OtanersBank\admins.web\OtanerBank\OtanerBank\Views\Admin\Index.cshtml"
                           Write(Html.ActionLink("Inactive", "Inactive", new { CPF = item.CPF }));

#line default
#line hidden
            EndContext();
#line 150 "C:\projects\OtanersBank\admins.web\OtanerBank\OtanerBank\Views\Admin\Index.cshtml"
                                                                                                
                            }
                            else
                            {
                                

#line default
#line hidden
            BeginContext(4747, 59, false);
#line 154 "C:\projects\OtanersBank\admins.web\OtanerBank\OtanerBank\Views\Admin\Index.cshtml"
                           Write(Html.ActionLink("Active", "Active", new { CPF = item.CPF }));

#line default
#line hidden
            EndContext();
#line 154 "C:\projects\OtanersBank\admins.web\OtanerBank\OtanerBank\Views\Admin\Index.cshtml"
                                                                                            
                            }

#line default
#line hidden
            BeginContext(4839, 63, true);
            WriteLiteral("                            |\r\n                        </p>\r\n\r\n");
            EndContext();
#line 159 "C:\projects\OtanersBank\admins.web\OtanerBank\OtanerBank\Views\Admin\Index.cshtml"
                         if (item.STATUS == "1")
                        {

#line default
#line hidden
            BeginContext(4979, 65, true);
            WriteLiteral("                            <p style=\"color:green;\">Actived</p>\r\n");
            EndContext();
#line 162 "C:\projects\OtanersBank\admins.web\OtanerBank\OtanerBank\Views\Admin\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(5128, 65, true);
            WriteLiteral("                            <p style=\"color:red;\">Inactived</p>\r\n");
            EndContext();
#line 166 "C:\projects\OtanersBank\admins.web\OtanerBank\OtanerBank\Views\Admin\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(5220, 54, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n");
            EndContext();
#line 170 "C:\projects\OtanersBank\admins.web\OtanerBank\OtanerBank\Views\Admin\Index.cshtml"

            }

#line default
#line hidden
            BeginContext(5291, 34, true);
            WriteLiteral("\r\n\r\n        </div>\r\n\r\n    </div>\r\n");
            EndContext();
#line 177 "C:\projects\OtanersBank\admins.web\OtanerBank\OtanerBank\Views\Admin\Index.cshtml"

}
else
{

}

#line default
#line hidden
            BeginContext(5344, 1726, true);
            WriteLiteral(@"
<script src=""https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js""></script>

<script type=""text/javascript"">

    $(document).ready(function () {


        $.ajax({
            type: ""GET"",
            url: 'https://localhost:44397/Admin/CountActives',
            dataType: ""json"",
            success: (function (msg) {
                document.getElementById('txtQteActives').textContent = 'Actives: ' + msg;
            }),
            error: (function (msg) {

            })
        });

        $.ajax({
            type: ""GET"",
            url: 'https://localhost:44397/Admin/CountInactives',
            dataType: ""json"",
            success: (function (msg) {
                document.getElementById('txtQteInactives').textContent = 'Inactives: ' + msg;
            }),
            error: (function (msg) {

            })
        });

    });

    function Search() {

        console.log('pesquisa');

    }

    function MinimizeClient() {

        //ale");
            WriteLiteral(@"rt(document.getElementById('Clients' + arguments[0]).hidden);

        if (document.getElementById('Clients' + arguments[0]).hidden == false) {

            document.getElementById('Minimize' + arguments[0]).textContent = '+';

            document.getElementById('Clients' + arguments[0]).hidden = true;
            document.getElementById('LinkClients' + arguments[0]).hidden = true;

        } else {

            document.getElementById('Minimize' + arguments[0]).innerHTML = '&times;';

            document.getElementById('Clients' + arguments[0]).hidden = false;
            document.getElementById('LinkClients' + arguments[0]).hidden = false;

        }

    }

</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<OtanerBank.Models.Client>> Html { get; private set; }
    }
}
#pragma warning restore 1591
