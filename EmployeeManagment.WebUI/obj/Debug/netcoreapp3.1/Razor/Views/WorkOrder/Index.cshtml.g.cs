#pragma checksum "C:\Users\malik\source\repos\EmployeeManagment\EmployeeManagment.WebUI\Views\WorkOrder\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9be97f6b758497528aa059bc6c336b54fc90bc0c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_WorkOrder_Index), @"mvc.1.0.view", @"/Views/WorkOrder/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9be97f6b758497528aa059bc6c336b54fc90bc0c", @"/Views/WorkOrder/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07f2e802aa8da926b2eedef5ebb50fe47c85cedd", @"/Views/_ViewImports.cshtml")]
    public class Views_WorkOrder_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<WorkOrderDto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "WorkOrder", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-next"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-bottom: 10px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-rounded"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("60"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("60"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("-"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-xs btn-info btn-edit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\malik\source\repos\EmployeeManagment\EmployeeManagment.WebUI\Views\WorkOrder\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div id=""modalPlaceHolder"" aria-hidden=""true""></div>


<div class=""page-header"">
    <h1>
        <small>
            <i class=""ace-icon fa fa-angle-double-right""></i>
            Çalışan İzin Tipi Listesi
        </small>
    </h1>
</div>

<div style=""margin-top: 20px"">

    <div class=""col-xs-12"">

");
#nullable restore
#line 23 "C:\Users\malik\source\repos\EmployeeManagment\EmployeeManagment.WebUI\Views\WorkOrder\Index.cshtml"
         if ((bool)ViewBag.AllowCreate)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9be97f6b758497528aa059bc6c336b54fc90bc0c7572", async() => {
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
            WriteLiteral("\r\n");
#nullable restore
#line 26 "C:\Users\malik\source\repos\EmployeeManagment\EmployeeManagment.WebUI\Views\WorkOrder\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        <table id=""work-order-table"" class=""table  table-bordered table-hover"">
            <thead>
                <tr>
                    <th>Resim</th>
                    <th>İş Emri No</th>
                    <th>Oluşturulma Tarihi</th>
                    <th>Durum</th>
                    <th>Sorumlu Kullanıcı</th>
                    <th></th>
                </tr>
            </thead>

            <tbody>
");
#nullable restore
#line 41 "C:\Users\malik\source\repos\EmployeeManagment\EmployeeManagment.WebUI\Views\WorkOrder\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr");
            BeginWriteAttribute("name", " name=\"", 1154, "\"", 1169, 1);
#nullable restore
#line 43 "C:\Users\malik\source\repos\EmployeeManagment\EmployeeManagment.WebUI\Views\WorkOrder\Index.cshtml"
WriteAttributeValue("", 1161, item.Id, 1161, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <td>\r\n");
#nullable restore
#line 45 "C:\Users\malik\source\repos\EmployeeManagment\EmployeeManagment.WebUI\Views\WorkOrder\Index.cshtml"
                             if (item.ImageUrl != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9be97f6b758497528aa059bc6c336b54fc90bc0c10803", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1376, "~/images/", 1376, 9, true);
#nullable restore
#line 47 "C:\Users\malik\source\repos\EmployeeManagment\EmployeeManagment.WebUI\Views\WorkOrder\Index.cshtml"
AddHtmlAttributeValue("", 1385, item.ImageUrl, 1385, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 48 "C:\Users\malik\source\repos\EmployeeManagment\EmployeeManagment.WebUI\Views\WorkOrder\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 51 "C:\Users\malik\source\repos\EmployeeManagment\EmployeeManagment.WebUI\Views\WorkOrder\Index.cshtml"
                       Write(item.WorkOrderNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 54 "C:\Users\malik\source\repos\EmployeeManagment\EmployeeManagment.WebUI\Views\WorkOrder\Index.cshtml"
                       Write(item.CreatedDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 57 "C:\Users\malik\source\repos\EmployeeManagment\EmployeeManagment.WebUI\Views\WorkOrder\Index.cshtml"
                       Write(item.StatusText);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n");
#nullable restore
#line 60 "C:\Users\malik\source\repos\EmployeeManagment\EmployeeManagment.WebUI\Views\WorkOrder\Index.cshtml"
                             if (item.AssignUser != null)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "C:\Users\malik\source\repos\EmployeeManagment\EmployeeManagment.WebUI\Views\WorkOrder\Index.cshtml"
                           Write(item.AssignUser.FirstName);

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "C:\Users\malik\source\repos\EmployeeManagment\EmployeeManagment.WebUI\Views\WorkOrder\Index.cshtml"
                                                      Write(item.AssignUser.LastName);

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "C:\Users\malik\source\repos\EmployeeManagment\EmployeeManagment.WebUI\Views\WorkOrder\Index.cshtml"
                                                                                     
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\r\n                        <td>\r\n");
#nullable restore
#line 66 "C:\Users\malik\source\repos\EmployeeManagment\EmployeeManagment.WebUI\Views\WorkOrder\Index.cshtml"
                             if ((bool) ViewBag.AllowCreate)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"hidden-sm hidden-xs btn-group\">\r\n\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9be97f6b758497528aa059bc6c336b54fc90bc0c15671", async() => {
                WriteLiteral("\r\n                                        <i class=\"ace-icon fa fa-pencil bigger-120\"></i>\r\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 70 "C:\Users\malik\source\repos\EmployeeManagment\EmployeeManagment.WebUI\Views\WorkOrder\Index.cshtml"
                                                                                      WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                                    <button class=\"btn btn-xs btn-danger btn-remove\" data-id=\"");
#nullable restore
#line 74 "C:\Users\malik\source\repos\EmployeeManagment\EmployeeManagment.WebUI\Views\WorkOrder\Index.cshtml"
                                                                                         Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                                        <i class=\"ace-icon fa fa-trash-o bigger-120\"></i>\r\n                                    </button>\r\n                                </div>\r\n");
#nullable restore
#line 78 "C:\Users\malik\source\repos\EmployeeManagment\EmployeeManagment.WebUI\Views\WorkOrder\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                              \r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 82 "C:\Users\malik\source\repos\EmployeeManagment\EmployeeManagment.WebUI\Views\WorkOrder\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </tbody>\r\n        </table>\r\n    </div><!-- /.span -->\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script type=""text/javascript"">
        $(document).ready(function() {
            var dataTable = $('#work-order-table').DataTable({
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
                        ""sNex");
                WriteLiteral(@"t"": ""Sonraki"",
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
 ");
                WriteLiteral("                   .then((willDelete) => {\r\n                        if (willDelete) {\r\n                            $.ajax({\r\n                                type: \"POST\",\r\n                                url: \'");
#nullable restore
#line 140 "C:\Users\malik\source\repos\EmployeeManagment\EmployeeManagment.WebUI\Views\WorkOrder\Index.cshtml"
                                 Write(Url.Action("Remove", "WorkOrder"));

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<WorkOrderDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
