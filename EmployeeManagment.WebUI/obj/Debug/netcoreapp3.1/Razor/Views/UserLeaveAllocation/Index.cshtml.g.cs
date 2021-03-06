#pragma checksum "C:\Users\malik\source\repos\EmployeeManagment\EmployeeManagment.WebUI\Views\UserLeaveAllocation\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a9704c351b9d4396b36d38d67755a9b0f254b042"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserLeaveAllocation_Index), @"mvc.1.0.view", @"/Views/UserLeaveAllocation/Index.cshtml")]
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
#line 1 "C:\Users\malik\source\repos\EmployeeManagment\EmployeeManagment.WebUI\Views\_ViewImports.cshtml"
using EmployeeManagment.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\malik\source\repos\EmployeeManagment\EmployeeManagment.WebUI\Views\_ViewImports.cshtml"
using EmployeeManagment.Entities.Dtos;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9704c351b9d4396b36d38d67755a9b0f254b042", @"/Views/UserLeaveAllocation/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07f2e802aa8da926b2eedef5ebb50fe47c85cedd", @"/Views/_ViewImports.cshtml")]
    public class Views_UserLeaveAllocation_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<UserLeaveAllocationDto>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\malik\source\repos\EmployeeManagment\EmployeeManagment.WebUI\Views\UserLeaveAllocation\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""page-header"">
    <h1>
        <small>
            <i class=""ace-icon fa fa-angle-double-right""></i>
            Kullanıcı İzni Tahsisi Listesi
        </small>
    </h1>
</div>

<div style=""margin-top: 20px"">

    <div class=""col-xs-12"">
        <table id=""user-leave-alloaction-table"" class=""table  table-bordered table-hover"">
            <thead>
                <tr>
                    <th>Kullanıcı Adı</th>
                    <th>İzin Tipi</th>
                    <th>Gün Sayısı</th>
                </tr>
            </thead>

            <tbody>
");
#nullable restore
#line 29 "C:\Users\malik\source\repos\EmployeeManagment\EmployeeManagment.WebUI\Views\UserLeaveAllocation\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr");
            BeginWriteAttribute("name", " name=\"", 806, "\"", 821, 1);
#nullable restore
#line 31 "C:\Users\malik\source\repos\EmployeeManagment\EmployeeManagment.WebUI\Views\UserLeaveAllocation\Index.cshtml"
WriteAttributeValue("", 813, item.Id, 813, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <td>\r\n                            ");
#nullable restore
#line 33 "C:\Users\malik\source\repos\EmployeeManagment\EmployeeManagment.WebUI\Views\UserLeaveAllocation\Index.cshtml"
                       Write(item.User.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 33 "C:\Users\malik\source\repos\EmployeeManagment\EmployeeManagment.WebUI\Views\UserLeaveAllocation\Index.cshtml"
                                            Write(item.User.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 36 "C:\Users\malik\source\repos\EmployeeManagment\EmployeeManagment.WebUI\Views\UserLeaveAllocation\Index.cshtml"
                       Write(item.UserLeaveType.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 39 "C:\Users\malik\source\repos\EmployeeManagment\EmployeeManagment.WebUI\Views\UserLeaveAllocation\Index.cshtml"
                       Write(item.NumberOfDays);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 42 "C:\Users\malik\source\repos\EmployeeManagment\EmployeeManagment.WebUI\Views\UserLeaveAllocation\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </tbody>\r\n        </table>\r\n    </div><!-- /.span -->\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script type=""text/javascript"">
        $(document).ready(function () {
            var dataTable = $('#user-leave-alloaction-table').DataTable({
                language: {
                    ""sDecimal"": "","",
                    ""sEmptyTable"": ""Tabloda herhangi bir veri mevcut değil"",
                    ""sInfo"": ""_TOTAL_ kayıttan _START_ - _END_ arasındaki kayıtlar gösteriliyor"",
                    ""sInfoEmpty"": ""Kayıt yok"",
                    ""sInfoFiltered"": ""(_MAX_ kayıt içerisinden bulunan)"",
                    ""sInfoPostFix"": """",
                    ""sInfoThousands"": ""."",
                    ""sLengthMenu"": ""Sayfada _MENU_ kayıt göster"",
                    ""sLoadingRecords"": ""Yükleniyor..."",
                    ""sProcessing"": ""İşleniyor..."",
                    ""sSearch"": ""Ara:"",
                    ""sZeroRecords"": ""Eşleşen kayıt bulunamadı"",
                    ""oPaginate"": {
                        ""sFirst"": ""İlk"",
                        ""sLast"": ""Son"",
                 ");
                WriteLiteral(@"       ""sNext"": ""Sonraki"",
                        ""sPrevious"": ""Önceki""
                    },
                    ""oAria"": {
                        ""sSortAscending"": "": artan sütun sıralamasını aktifleştir"",
                        ""sSortDescending"": "": azalan sütun sıralamasını aktifleştir""
                    },
                    ""select"": {
                        ""rows"": {
                            ""_"": ""%d kayıt seçildi"",
                            ""0"": """",
                            ""1"": ""1 kayıt seçildi""
                        }
                    }
                }
            });
        });
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<UserLeaveAllocationDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
