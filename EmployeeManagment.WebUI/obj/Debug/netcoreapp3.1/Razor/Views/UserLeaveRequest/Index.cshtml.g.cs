#pragma checksum "C:\Users\malik\source\repos\EmployeeManagment\EmployeeManagment.WebUI\Views\UserLeaveRequest\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7366e5d807ea2953c1a2e3bc4a290760a5ded9ec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserLeaveRequest_Index), @"mvc.1.0.view", @"/Views/UserLeaveRequest/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\malik\source\repos\EmployeeManagment\EmployeeManagment.WebUI\Views\UserLeaveRequest\Index.cshtml"
using EmployeeManagment.Entities.Enums;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7366e5d807ea2953c1a2e3bc4a290760a5ded9ec", @"/Views/UserLeaveRequest/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07f2e802aa8da926b2eedef5ebb50fe47c85cedd", @"/Views/_ViewImports.cshtml")]
    public class Views_UserLeaveRequest_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<UserLeaveRequestDto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "UserLeaveRequest", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-next"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-bottom: 10px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-xs btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\malik\source\repos\EmployeeManagment\EmployeeManagment.WebUI\Views\UserLeaveRequest\Index.cshtml"
  
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
            İzin Taleplerim
        </small>
    </h1>
</div>

<div style=""margin-top: 20px"">

    <div class=""col-xs-12"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7366e5d807ea2953c1a2e3bc4a290760a5ded9ec5974", async() => {
                WriteLiteral("Ekle");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

        <table id=""user-request-table"" class=""table  table-bordered table-hover"">
            <thead>
                <tr>
                    <th>Talep Oluşturan</th>
                    <th>Oluşturulma Tarih</th>
                    <th>İzin Tipi</th>
                    <th>Başlangıç Tarihi</th>
                    <th>Bitiş Tarihi</th>
                    <th>Note</th>
                    <th>Durum</th>
                    <th></th>
                </tr>
            </thead>

            <tbody>
");
#nullable restore
#line 38 "C:\Users\malik\source\repos\EmployeeManagment\EmployeeManagment.WebUI\Views\UserLeaveRequest\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr");
            BeginWriteAttribute("name", " name=\"", 1161, "\"", 1176, 1);
#nullable restore
#line 40 "C:\Users\malik\source\repos\EmployeeManagment\EmployeeManagment.WebUI\Views\UserLeaveRequest\Index.cshtml"
WriteAttributeValue("", 1168, item.Id, 1168, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <td>\r\n                            ");
#nullable restore
#line 42 "C:\Users\malik\source\repos\EmployeeManagment\EmployeeManagment.WebUI\Views\UserLeaveRequest\Index.cshtml"
                       Write(item.RequestUser.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 42 "C:\Users\malik\source\repos\EmployeeManagment\EmployeeManagment.WebUI\Views\UserLeaveRequest\Index.cshtml"
                                                   Write(item.RequestUser.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 45 "C:\Users\malik\source\repos\EmployeeManagment\EmployeeManagment.WebUI\Views\UserLeaveRequest\Index.cshtml"
                       Write(item.RequestDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 48 "C:\Users\malik\source\repos\EmployeeManagment\EmployeeManagment.WebUI\Views\UserLeaveRequest\Index.cshtml"
                       Write(item.UserLeaveType.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 51 "C:\Users\malik\source\repos\EmployeeManagment\EmployeeManagment.WebUI\Views\UserLeaveRequest\Index.cshtml"
                       Write(item.StartDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 54 "C:\Users\malik\source\repos\EmployeeManagment\EmployeeManagment.WebUI\Views\UserLeaveRequest\Index.cshtml"
                       Write(item.EndDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>");
#nullable restore
#line 56 "C:\Users\malik\source\repos\EmployeeManagment\EmployeeManagment.WebUI\Views\UserLeaveRequest\Index.cshtml"
                       Write(item.Note);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                        <td>\r\n");
#nullable restore
#line 59 "C:\Users\malik\source\repos\EmployeeManagment\EmployeeManagment.WebUI\Views\UserLeaveRequest\Index.cshtml"
                             if (item.Status == UserLeaveReqeustEnum.Approved)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span style=\"color: green\">");
#nullable restore
#line 61 "C:\Users\malik\source\repos\EmployeeManagment\EmployeeManagment.WebUI\Views\UserLeaveRequest\Index.cshtml"
                                                      Write(item.StatusText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 62 "C:\Users\malik\source\repos\EmployeeManagment\EmployeeManagment.WebUI\Views\UserLeaveRequest\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "C:\Users\malik\source\repos\EmployeeManagment\EmployeeManagment.WebUI\Views\UserLeaveRequest\Index.cshtml"
                             if (item.Status == UserLeaveReqeustEnum.Rejected)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span style=\"color: red\">");
#nullable restore
#line 65 "C:\Users\malik\source\repos\EmployeeManagment\EmployeeManagment.WebUI\Views\UserLeaveRequest\Index.cshtml"
                                                    Write(item.StatusText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 66 "C:\Users\malik\source\repos\EmployeeManagment\EmployeeManagment.WebUI\Views\UserLeaveRequest\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 67 "C:\Users\malik\source\repos\EmployeeManagment\EmployeeManagment.WebUI\Views\UserLeaveRequest\Index.cshtml"
                             if (item.Status == UserLeaveReqeustEnum.Waiting)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span style=\"color: orange\">");
#nullable restore
#line 69 "C:\Users\malik\source\repos\EmployeeManagment\EmployeeManagment.WebUI\Views\UserLeaveRequest\Index.cshtml"
                                                       Write(item.StatusText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 70 "C:\Users\malik\source\repos\EmployeeManagment\EmployeeManagment.WebUI\Views\UserLeaveRequest\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\r\n                        <td>\r\n");
#nullable restore
#line 73 "C:\Users\malik\source\repos\EmployeeManagment\EmployeeManagment.WebUI\Views\UserLeaveRequest\Index.cshtml"
                             if (item.Status != UserLeaveReqeustEnum.Approved)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"hidden-sm hidden-xs btn-group\">\r\n");
#nullable restore
#line 76 "C:\Users\malik\source\repos\EmployeeManagment\EmployeeManagment.WebUI\Views\UserLeaveRequest\Index.cshtml"
                                     if ((bool)ViewBag.ShowEdit)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7366e5d807ea2953c1a2e3bc4a290760a5ded9ec14862", async() => {
                WriteLiteral("\r\n                                            <i class=\"ace-icon fa fa-pencil bigger-120\"></i>\r\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 78 "C:\Users\malik\source\repos\EmployeeManagment\EmployeeManagment.WebUI\Views\UserLeaveRequest\Index.cshtml"
                                                                                                 WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        <button class=\"btn btn-xs btn-success btn-approve\" data-id=\"");
#nullable restore
#line 81 "C:\Users\malik\source\repos\EmployeeManagment\EmployeeManagment.WebUI\Views\UserLeaveRequest\Index.cshtml"
                                                                                               Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                                           Onayla\r\n                                        </button>\r\n                                        <button class=\"btn btn-xs btn-warning btn-cancel\" data-id=\"");
#nullable restore
#line 84 "C:\Users\malik\source\repos\EmployeeManagment\EmployeeManagment.WebUI\Views\UserLeaveRequest\Index.cshtml"
                                                                                              Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                                            Reddet\r\n                                        </button>\r\n");
#nullable restore
#line 87 "C:\Users\malik\source\repos\EmployeeManagment\EmployeeManagment.WebUI\Views\UserLeaveRequest\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    <button class=\"btn btn-xs btn-danger btn-remove\" data-id=\"");
#nullable restore
#line 89 "C:\Users\malik\source\repos\EmployeeManagment\EmployeeManagment.WebUI\Views\UserLeaveRequest\Index.cshtml"
                                                                                         Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                                        <i class=\"ace-icon fa fa-trash-o bigger-120\"></i>\r\n                                    </button>\r\n\r\n                                </div>\r\n");
#nullable restore
#line 94 "C:\Users\malik\source\repos\EmployeeManagment\EmployeeManagment.WebUI\Views\UserLeaveRequest\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 98 "C:\Users\malik\source\repos\EmployeeManagment\EmployeeManagment.WebUI\Views\UserLeaveRequest\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </tbody>\r\n        </table>\r\n    </div><!-- /.span -->\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script type=""text/javascript"">
        $(document).ready(function() {
            var dataTable = $('#user-request-table').DataTable({
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
                        ""sN");
                WriteLiteral(@"ext"": ""Sonraki"",
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

            $("".btn-remove"").click(function() {
                var id = $(this).attr(""data-id"");
                swal({
                        title: ""Silmek İstediğine Emin Misiniz ?"",
                        text: ""Silinen Veri geri getirilemez !"",
                        icon: ""warning"",
                        buttons: true,
                        dangerMode: true,

                    })
                WriteLiteral("\n                    .then((willDelete) => {\r\n                        if (willDelete) {\r\n                            $.ajax({\r\n                                type: \"POST\",\r\n                                url: \'");
#nullable restore
#line 156 "C:\Users\malik\source\repos\EmployeeManagment\EmployeeManagment.WebUI\Views\UserLeaveRequest\Index.cshtml"
                                 Write(Url.Action("Remove", "UserLeaveRequest"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                                dataType: ""json"",
                                data: { id: id },
                                success: function(data) {
                                    if (data.success) {
                                        var tableRow = $(`[name=${id}]`);
                                        dataTable.row(tableRow).remove().draw();
                                        toastr.success(""İşlem Başarılı Bir Şekilde Gerçekleşti"");
                                    } else {
                                        toastr.error(""Bir Hata Oluştu"");

                                    }
                                },
                                error: function() {
                                    toastr.error(""Bir Hata Oluştu"");
                                }
                            });


                        }
                    });
            });


            $("".btn-cancel"").click(function() {
                var id = $(this)");
                WriteLiteral(@".attr(""data-id"");
                swal({
                        title: ""Talebi Reddetmek İstediğinize Emin Misniz?"",
                        icon: ""error"",
                        buttons: true
                    })
                    .then((willDelete) => {
                        if (willDelete) {
                            $.ajax({
                                type: ""POST"",
                                url: '");
#nullable restore
#line 191 "C:\Users\malik\source\repos\EmployeeManagment\EmployeeManagment.WebUI\Views\UserLeaveRequest\Index.cshtml"
                                 Write(Url.Action("Cancel", "UserLeaveRequest"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                                dataType: ""json"",
                                data: { id: id },
                                success: function(data) {
                                    if (data.success) {
                                        var tableRow = $(`[name=${id}]`);
                                        toastr.success(""İşlem Başarılı Bir Şekilde Gerçekleşti"");
                                        window.reload();
                                    } else {
                                        toastr.error(""Bir Hata Oluştu"");

                                    }
                                },
                                error: function() {
                                    toastr.error(""Bir Hata Oluştu"");
                                }
                            });


                        }
                    });
            });

            $("".btn-approve"").click(function() {
                var id = $(this).attr(""data-id"");
      ");
                WriteLiteral(@"          swal({
                        title: ""Talebi Onaylamak İstediğinize Emin Misniz?"",
                        icon: ""success"",
                        buttons: true
                    })
                    .then((willDelete) => {
                        if (willDelete) {
                            $.ajax({
                                type: ""POST"",
                                url: '");
#nullable restore
#line 225 "C:\Users\malik\source\repos\EmployeeManagment\EmployeeManagment.WebUI\Views\UserLeaveRequest\Index.cshtml"
                                 Write(Url.Action("Approve", "UserLeaveRequest"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                                dataType: ""json"",
                                data: { id: id },
                                success: function(data) {
                                    if (data.success) {
                                        var tableRow = $(`[name=${id}]`);
                                        toastr.success(""İşlem Başarılı Bir Şekilde Gerçekleşti"");
                                        window.reload();
                                    } else {
                                        toastr.error(""Bir Hata Oluştu"");

                                    }
                                },
                                error: function() {
                                    toastr.error(""Bir Hata Oluştu"");
                                }
                            });


                        }
                    });
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<UserLeaveRequestDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591