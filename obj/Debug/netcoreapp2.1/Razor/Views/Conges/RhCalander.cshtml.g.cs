#pragma checksum "D:\App_PFE\EmployeeApplication\Views\Conges\RhCalander.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e17f1df7ac753556b11085f0ce47a2a0562e6a9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Conges_RhCalander), @"mvc.1.0.view", @"/Views/Conges/RhCalander.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Conges/RhCalander.cshtml", typeof(AspNetCore.Views_Conges_RhCalander))]
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
#line 1 "D:\App_PFE\EmployeeApplication\Views\_ViewImports.cshtml"
using EmployeeApplication;

#line default
#line hidden
#line 2 "D:\App_PFE\EmployeeApplication\Views\_ViewImports.cshtml"
using EmployeeApplication.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e17f1df7ac753556b11085f0ce47a2a0562e6a9", @"/Views/Conges/RhCalander.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2165c8d65abd77cd3c444fd0a9d96fe9df05df9a", @"/Views/_ViewImports.cshtml")]
    public class Views_Conges_RhCalander : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("type"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col-12 form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col-md-12 form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\App_PFE\EmployeeApplication\Views\Conges\RhCalander.cshtml"
  
    ViewBag.Title = "Index";

#line default
#line hidden
            BeginContext(37, 18, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n");
            EndContext();
#line 6 "D:\App_PFE\EmployeeApplication\Views\Conges\RhCalander.cshtml"
 if (@ViewBag.Error != null)
{

#line default
#line hidden
            BeginContext(88, 59, true);
            WriteLiteral("    <div class=\"alert alert-danger\" role=\"alert\">\r\n        ");
            EndContext();
            BeginContext(148, 13, false);
#line 9 "D:\App_PFE\EmployeeApplication\Views\Conges\RhCalander.cshtml"
   Write(ViewBag.Error);

#line default
#line hidden
            EndContext();
            BeginContext(161, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 11 "D:\App_PFE\EmployeeApplication\Views\Conges\RhCalander.cshtml"
}

#line default
#line hidden
            BeginContext(178, 1495, true);
            WriteLiteral(@"<div id=""calender"" style=""margin-top: 10%""></div>

<div id=""myModal"" class=""modal fade"" role=""dialog"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
                <h4 class=""modal-title""><span id=""eventTitle""></span></h4>
            </div>
            <div class=""modal-body"">
                <button id=""btnDelete"" class=""btn btn-default btn-sm pull-right"">
                    <span class=""glyphicon glyphicon-remove""></span> Supprimer
                </button>
                <button id=""btnEdit"" class=""btn btn-default btn-sm pull-right"" style=""margin-right:5px;"">
                    <span class=""glyphicon glyphicon-pencil""></span> Modifier
                </button>
                <p id=""pDetails""></p>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-default"" data-dismiss=""modal""");
            WriteLiteral(@">Fermer</button>
            </div>
        </div>
    </div>
</div>

<div id=""myModalSave"" class=""modal fade"" role=""dialog"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
                <h4 class=""modal-title""> Demande de cong??</h4>
            </div>
            <div class=""modal-body"">
                ");
            EndContext();
            BeginContext(1673, 1748, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4e17f1df7ac753556b11085f0ce47a2a0562e6a97601", async() => {
                BeginContext(1713, 1160, true);
                WriteLiteral(@"
                    <input type=""hidden"" id=""hdEventID"" value=""0"" />


                    <label>Date de D??but</label>
                    <div class=""input-group date"" id=""dtp1"">
                        <input type=""text"" id=""txtStart"" class=""form-control"" />
                        <span class=""input-group-addon"">
                            <span class=""glyphicon glyphicon-calendar""></span>
                        </span>
                    </div>



                    <label> Date de Fin</label>
                    <div class=""input-group date"" id=""dtp2"">
                        <input type=""text"" id=""txtEnd"" class=""form-control"" />
                        <span class=""input-group-addon"">
                            <span class=""glyphicon glyphicon-calendar""></span>
                        </span>
                    </div>
                    <div class=""form-group"">
                        <label>Justification</label>
                        <textarea id=""txtDescription"" rows=");
                WriteLiteral("\"3\" class=\"form-control\"></textarea>\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        ");
                EndContext();
                BeginContext(2873, 180, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4e17f1df7ac753556b11085f0ce47a2a0562e6a99230", async() => {
                    BeginContext(2945, 32, true);
                    WriteLiteral("\r\n\r\n                            ");
                    EndContext();
                    BeginContext(2977, 41, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4e17f1df7ac753556b11085f0ce47a2a0562e6a99668", async() => {
                        BeginContext(2994, 15, true);
                        WriteLiteral("Choisir un type");
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(3018, 26, true);
                    WriteLiteral("\r\n                        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#line 71 "D:\App_PFE\EmployeeApplication\Views\Conges\RhCalander.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewBag.Types;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3053, 361, true);
                WriteLiteral(@"
                    </div>

                    <button type=""button"" id=""btnSave"" class=""btn btn-success"">Accepter</button>
                    <button type=""button"" id=""btnSave2"" class=""btn btn-danger"">R??fuser</button>
                    <button type=""button"" id=""btnClose"" class=""btn btn-default"" data-dismiss=""modal"">Fermer</button>
                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3421, 62, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(3500, 7445, true);
                WriteLiteral(@"
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/moment.js/2.18.1/moment.min.js""></script>
    <script src=""//cdnjs.cloudflare.com/ajax/libs/fullcalendar/3.4.0/fullcalendar.min.js""></script>
    <script>
        $(document).ready(function () {
            var events = [];
            var selectedEvent = null;
            FetchEventAndRenderCalendar();
            function FetchEventAndRenderCalendar() {
                events = [];
                $.ajax({
                    type: ""GET"",
                    url: ""/Conges/GetEvents"",
                    success: function (data) {
                        $.each(data.data, function (i, v) {

                            events.push({
                                eventID: v.id,
                                title: v.employee.nom,
                                description: v.employeeID,
                                start: moment(v.du),
                                end: v.au != null ? moment(v.au) : null,
                 ");
                WriteLiteral(@"               color: v.status == -1 ? ""blue"" : (v.status == 1 ? ""green"" : ""red""),
                                extendedProps: {
                                    type: v.typeCongeID,
                                    note:v.note
                                }

                            });
                        })

                        GenerateCalender(events);
                    },
                    error: function (error) {
                        alert('failed');
                    }
                })
            }

            function GenerateCalender(events) {
                $('#calender').fullCalendar('destroy');
                $('#calender').fullCalendar({

                    defaultDate: new Date(),
                    timeFormat: 'h(:mm)a',
                    hiddenDays: [6, 0],
                    header: {
                        left: 'prev,next today',
                        center: 'title',
                        right: 'month,agendaDay'
");
                WriteLiteral(@"                    },
                    eventColor: '#378006',
                    events: events,
                    eventResize: function (info) {
                        alert(info.event.title + "" end is now "" + info.event.end.toISOString());

                        if (!confirm(""is this okay?"")) {
                            info.revert();
                        }
                    },
                    dragScroll: true,
                    eventDurationEditable: true,
                    selectable: true,
                    eventResizableFromStart: true,
                    eventClick: function (calEvent, jsEvent, view) {
                        selectedEvent = calEvent;
                     
                        openAddEditForm();
                    },
                    selectable: true,
                 
                    editable: true,
                    eventDrop: function (event) {
                        var data = {
                            ID: event.");
                WriteLiteral(@"eventID,
                            Subject: event.title,
                            DU: event.start.format('DD/MM/YYYY HH:mm A'),
                            AU: event.end != null ? event.end.format('DD/MM/YYYY HH:mm A') : null,
                            Notes: event.extendedProps.note,
                            typeCongeID: event.extendedProps.type
                        };



                        UpdateEvent(data);
                    }
                })
                $('#calender').fullCalendar('option', 'locale', 'fr');
            }

            $('#btnEdit').click(function () {
                //Open modal dialog for edit event
                openAddEditForm();
            })
            $('#btnDelete').click(function () {
                if (selectedEvent != null && confirm('Are you sure?')) {
                    $.ajax({
                        type: ""POST"",
                        url: '/home/DeleteEvent',
                        data: { 'eventID': selectedEven");
                WriteLiteral(@"t.eventID },
                        success: function (data) {

                            $('#myModal').modal('hide');
                            //Refresh the calender
                            FetchEventAndRenderCalendar();


                        },
                        error: function () {
                            alert('Failed');
                        }
                    })
                }
            })

            $('#dtp1,#dtp2').datetimepicker({
                format: 'DD/MM/YYYY HH:mm:ss'
            });

            $('#chkIsFullDay').change(function () {
                if ($(this).is(':checked')) {
                    $('#divEndDate').hide();
                }
                else {
                    $('#divEndDate').show();
                }
            });

            function openAddEditForm() {
                if (selectedEvent != null) {
                    $('#hdEventID').val(selectedEvent.eventID);
                    $('#txtSubject'");
                WriteLiteral(@").val(selectedEvent.title);
                    $('#txtStart').val(selectedEvent.start.format('DD/MM/YYYY HH:mm:ss'));
                    //$('#txtStart').datetimepicker({
                    //    // dateFormat: 'dd-mm-yy',
                    //    format: 'DD/MM/YYYY HH:mm:ss',
                    //    minDate: selectedEvent.start
                    //});
                    $('#chkIsFullDay').prop(""checked"", selectedEvent.allDay || false);
                    $('#chkIsFullDay').change();
                    $('#txtEnd').val(selectedEvent.end != null ? selectedEvent.end.add(-1, 'm').format('DD/MM/YYYY HH:mm A') : '');
                    $('#txtDescription').val(selectedEvent.description);
                    $('#ddThemeColor').val(selectedEvent.color);
                }
                $('#myModal').modal('hide');
                $('#myModalSave').modal('show');
            }

            $('#btnSave').click(function () {
                //Validation/

                
            ");
                WriteLiteral(@"    var data = {
                    id: selectedEvent.eventID
                    
                    
                };
                SaveEvent(data,1)
                // call function for submit data to the server
            })
            $('#btnSave2').click(function () {
                //Validation/


                var data = {
                    id: selectedEvent.eventID


                };
                SaveEvent(data,0);
                // call function for submit data to the server
            })
            $('#btnClose').click(function () {
                $('#myModalSave').modal('hide');

            })
            function SaveEvent(data, etat) {
                data.status = etat;
                $.ajax({
                    type: ""Post"",
                    url: '/conges/ChangeStatus',
                    data:data,
                    success: function (data) {

                        //Refresh the calender
                        FetchEventAndRen");
                WriteLiteral(@"derCalendar();
                        $('#myModalSave').modal('hide');

                    },
                    error: function () {
                        alert('Failed');
                    }
                })
            }
    

        })
    </script>
");
                EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
