#pragma checksum "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Sale\ReturnLoss.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2bac9a6f10cc73f0f29f8ef84e4049b2d084ccad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FytSoa.Web.Pages.FytAdmin.Sale.Pages_FytAdmin_Sale_ReturnLoss), @"mvc.1.0.razor-page", @"/Pages/FytAdmin/Sale/ReturnLoss.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/FytAdmin/Sale/ReturnLoss.cshtml", typeof(FytSoa.Web.Pages.FytAdmin.Sale.Pages_FytAdmin_Sale_ReturnLoss), null)]
namespace FytSoa.Web.Pages.FytAdmin.Sale
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\_ViewImports.cshtml"
using FytSoa.Web;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2bac9a6f10cc73f0f29f8ef84e4049b2d084ccad", @"/Pages/FytAdmin/Sale/ReturnLoss.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21c44af9864cf57cf01e8fd1fe389a8e352e148c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_FytAdmin_Sale_ReturnLoss : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Sale\ReturnLoss.cshtml"
  
    ViewData["Title"] = "返货报损记录";
    Layout = AdminLayout.Pjax(HttpContext);

#line default
#line hidden
            BeginContext(149, 5365, true);
            WriteLiteral(@"<div id=""container"">
    <div class=""list-wall"">
        <div class=""layui-form list-search"">
            <div class=""layui-inline"">
                <input class=""layui-input"" id=""key"" autocomplete=""off"" placeholder=""请输入关键字查询"">
            </div>
            <button type=""button"" class=""layui-btn layui-btn-sm"" data-type=""toolSearch""><i class=""layui-icon layui-icon-search""></i> 搜索</button>
        </div>
        <table class=""layui-hide"" id=""tablist"" lay-filter=""tool""></table>
    </div>
    <script type=""text/html"" id=""toolbar"">
        <div class=""layui-btn-container"">
            <button type=""button"" class=""layui-btn layui-btn-sm"" lay-event=""toolAdd""><i class=""layui-icon""></i> 新增</button>
            <button type=""button"" class=""layui-btn layui-btn-sm"" lay-event=""toolDel""><i class=""layui-icon""></i> 删除</button>
        </div>
    </script>
    <script>
        layui.config({
            base: '/themes/js/modules/'
        }).use(['table', 'layer', 'jquery', 'common', 'form'],
         ");
            WriteLiteral(@"   function () {
                var table = layui.table,
                    layer = layui.layer,
                    $ = layui.jquery,
                    os = layui.common,
                    form = layui.form;
                form.render('select');
                table.render({
                    toolbar: '#toolbar',
                    elem: '#tablist',
                    url: '/api/stock/returnlosslist',
                    cols: [
                        [
                            { type: 'checkbox', fixed: 'left' },
                            { field: 'codeName', width: 220, title: '名称',  fixed: 'left' },
                            { field: 'count', width: 100, title: '数量' },
                            { field: 'summary', title: '描述' },
                            { field: 'addDate', width: 240, title: '添加时间' },
                            { width: 100, title: '操作', templet: '#tool' }
                        ]
                    ],
                    page: { limits: [1");
            WriteLiteral(@"0, 20, 50, 100, 500, 1000, 5000, 10000], groups: 8 },
                    id: 'tables'
                });

                var guid = '', active = {
                    reload: function () {
                        table.reload('tables',
                            {
                                page: {
                                    curr: 1
                                },
                                where: {
                                    key: $(""#key"").val(),
                                }
                            });
                    },
                    toolSearch: function () {
                        active.reload();
                    },
                    toolAdd: function () {
                        os.Open('添加返货报损', '/fytadmin/sale/returnlossmodify', '750px', '400px', function () {
                            active.reload();
                        });
                    },
                    toolDel: function () {
                      ");
            WriteLiteral(@"  var checkStatus = table.checkStatus('tables')
                            , data = checkStatus.data;
                        if (data.length === 0) {
                            os.error(""请选择要删除的项目~"");
                            return;
                        }
                        var str = '';
                        $.each(data, function (i, item) {
                            str += item.guid + "","";
                        });
                        layer.confirm('确定要执行批量删除吗？', function (index) {
                            layer.close(index);
                            var loadindex = layer.load(1, {
                                shade: [0.1, '#000']
                            });
                            os.ajax('api/stock/delreturnloss/', { parm: str }, function (res) {
                                layer.close(loadindex);
                                if (res.statusCode === 200) {
                                    active.reload();
                               ");
            WriteLiteral(@"     os.success('删除成功！');
                                } else {
                                    os.error(res.message);
                                }
                            });
                        });

                    }
                };
                table.on('toolbar(tool)', function (obj) {
                    active[obj.event] ? active[obj.event].call(this) : '';
                });
                $('.list-search .layui-btn').on('click', function () {
                    var type = $(this).data('type');
                    active[type] ? active[type].call(this) : '';
                });
                //监听工具条
                table.on('tool(tool)', function (obj) {
                    var data = obj.data;
                    if (obj.event === 'edit') {
                        os.Open('编辑条形码', '/fytadmin/sale/returnlossmodify/?guid=' + data.guid, '750px', '400px', function () {
                            active.reload();
                        })
        ");
            WriteLiteral("            }\r\n                });\r\n            });\r\n    </script>\r\n    <script type=\"text/html\" id=\"tool\">\r\n        <a class=\"layui-btn layui-btn-primary layui-btn-xs\" lay-event=\"edit\"><i class=\"layui-icon\"></i> 修改</a>\r\n    </script>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FytSoa.Web.Pages.FytAdmin.Sale.ReturnLossModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FytSoa.Web.Pages.FytAdmin.Sale.ReturnLossModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FytSoa.Web.Pages.FytAdmin.Sale.ReturnLossModel>)PageContext?.ViewData;
        public FytSoa.Web.Pages.FytAdmin.Sale.ReturnLossModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
