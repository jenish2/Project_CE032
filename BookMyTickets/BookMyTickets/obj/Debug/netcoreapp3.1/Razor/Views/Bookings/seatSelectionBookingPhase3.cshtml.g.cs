#pragma checksum "E:\wddnProj\New folder\BookMyTickets\BookMyTickets\Views\Bookings\seatSelectionBookingPhase3.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d455ac1a6f85d4c488ef1c1fc8123d34c823b4f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Bookings_seatSelectionBookingPhase3), @"mvc.1.0.view", @"/Views/Bookings/seatSelectionBookingPhase3.cshtml")]
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
#line 1 "E:\wddnProj\New folder\BookMyTickets\BookMyTickets\Views\_ViewImports.cshtml"
using BookMyTickets;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\wddnProj\New folder\BookMyTickets\BookMyTickets\Views\_ViewImports.cshtml"
using BookMyTickets.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d455ac1a6f85d4c488ef1c1fc8123d34c823b4f", @"/Views/Bookings/seatSelectionBookingPhase3.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"270fea9b205752f6f2052668a274f363ab2994be", @"/Views/_ViewImports.cshtml")]
    public class Views_Bookings_seatSelectionBookingPhase3 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\wddnProj\New folder\BookMyTickets\BookMyTickets\Views\Bookings\seatSelectionBookingPhase3.cshtml"
  
    ViewData["Title"] = "SeatSelectionBookingPhase3";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    .page-wrapper,
    .content-wrapper {
        background: #f2f2f2;
        margin: 0;
        padding: 0;
    }

    .content-wrapper {
        margin-top: 1vh;
        margin-bottom: 0vh;
        margin-left: 4vw;
        margin-right: 4vw;
        padding: 2vh 2vw;
    }
</style>


<div class=""page-wrapper"">
    <div class=""content-wrapper"">
        <div class=""container"">
            <div class=""row"">
                <div class=""column"">
                    <div class=""card"" style=""width: 18rem;"">
                        <img");
            BeginWriteAttribute("src", " src=\"", 634, "\"", 652, 1);
#nullable restore
#line 29 "E:\wddnProj\New folder\BookMyTickets\BookMyTickets\Views\Bookings\seatSelectionBookingPhase3.cshtml"
WriteAttributeValue("", 640, ViewBag.Url, 640, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top\">\r\n                    </div>\r\n                </div>\r\n                <div class=\"column\">\r\n                    <h2> Movie Name:- ");
#nullable restore
#line 33 "E:\wddnProj\New folder\BookMyTickets\BookMyTickets\Views\Bookings\seatSelectionBookingPhase3.cshtml"
                                 Write(ViewBag.MovieName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                    <b>Movie Language:-</b>\r\n                    <p>");
#nullable restore
#line 35 "E:\wddnProj\New folder\BookMyTickets\BookMyTickets\Views\Bookings\seatSelectionBookingPhase3.cshtml"
                  Write(ViewBag.Language);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <b>Movie Genre:-</b>\r\n                    <p>");
#nullable restore
#line 37 "E:\wddnProj\New folder\BookMyTickets\BookMyTickets\Views\Bookings\seatSelectionBookingPhase3.cshtml"
                  Write(ViewBag.Genre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <b>Movie Director:-</b>\r\n                    <p>");
#nullable restore
#line 39 "E:\wddnProj\New folder\BookMyTickets\BookMyTickets\Views\Bookings\seatSelectionBookingPhase3.cshtml"
                  Write(ViewBag.Director);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <b>Movie duration:-</b>\r\n                    <p>");
#nullable restore
#line 41 "E:\wddnProj\New folder\BookMyTickets\BookMyTickets\Views\Bookings\seatSelectionBookingPhase3.cshtml"
                  Write(ViewBag.Duretion);

#line default
#line hidden
#nullable disable
            WriteLiteral(" min.</p>\r\n                    <b>Movie releaseDate:-</b>\r\n                    <p>");
#nullable restore
#line 43 "E:\wddnProj\New folder\BookMyTickets\BookMyTickets\Views\Bookings\seatSelectionBookingPhase3.cshtml"
                  Write(ViewBag.ReleaseDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                </div>
            </div>
        </div>
        <hr />
        <div class=""container"" style=""margin:2rem;"">
           
                    <div class=""row"">
                        <table>
                            <tr>
                                <td><b>Show Id:-</b></td>
                                <td>");
#nullable restore
#line 54 "E:\wddnProj\New folder\BookMyTickets\BookMyTickets\Views\Bookings\seatSelectionBookingPhase3.cshtml"
                               Write(ViewBag.ShowId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                            </tr>\r\n                            <tr>\r\n                                <td><b>Theater Name:-</b></td>\r\n                                <td>");
#nullable restore
#line 59 "E:\wddnProj\New folder\BookMyTickets\BookMyTickets\Views\Bookings\seatSelectionBookingPhase3.cshtml"
                               Write(ViewBag.TheaterName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                            </tr>\r\n                            <tr>\r\n                                <td><b>Screen No:-</b></td>\r\n                                <td>");
#nullable restore
#line 64 "E:\wddnProj\New folder\BookMyTickets\BookMyTickets\Views\Bookings\seatSelectionBookingPhase3.cshtml"
                               Write(ViewBag.ScreenNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                            </tr>\r\n                            <tr>\r\n                                <td><b>Show Starting Time:-</b></td>\r\n                                <td>");
#nullable restore
#line 69 "E:\wddnProj\New folder\BookMyTickets\BookMyTickets\Views\Bookings\seatSelectionBookingPhase3.cshtml"
                               Write(ViewBag.StartTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                            </tr>\r\n                            <tr>\r\n                                <td><b>Show Date:-</b></td>\r\n                                <td>");
#nullable restore
#line 74 "E:\wddnProj\New folder\BookMyTickets\BookMyTickets\Views\Bookings\seatSelectionBookingPhase3.cshtml"
                               Write(ViewBag.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                            </tr>\r\n                            <tr>\r\n                                <td><b>Price per seat:-</b></td>\r\n                                <td>");
#nullable restore
#line 79 "E:\wddnProj\New folder\BookMyTickets\BookMyTickets\Views\Bookings\seatSelectionBookingPhase3.cshtml"
                               Write(ViewBag.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Rs.</td>\r\n\r\n                            </tr>\r\n                        </table>\r\n                    </div>\r\n                \r\n        </div>\r\n        <div class=\"container\" style=\"margin:2rem;\">\r\n");
#nullable restore
#line 87 "E:\wddnProj\New folder\BookMyTickets\BookMyTickets\Views\Bookings\seatSelectionBookingPhase3.cshtml"
             using (Html.BeginForm("ConfirmBookingPhase4", "Bookings", FormMethod.Post))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p>Enter ShowId:- </p>\r\n");
#nullable restore
#line 90 "E:\wddnProj\New folder\BookMyTickets\BookMyTickets\Views\Bookings\seatSelectionBookingPhase3.cshtml"
           Write(Html.TextBox("ShowId"));

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p>Enter Total No Of Ticket:- </p>\r\n");
#nullable restore
#line 92 "E:\wddnProj\New folder\BookMyTickets\BookMyTickets\Views\Bookings\seatSelectionBookingPhase3.cshtml"
           Write(Html.TextBox("TotalTickets"));

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p>Enter Seat Numer:- </p>\r\n");
#nullable restore
#line 94 "E:\wddnProj\New folder\BookMyTickets\BookMyTickets\Views\Bookings\seatSelectionBookingPhase3.cshtml"
           Write(Html.TextBox("Seat1"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 94 "E:\wddnProj\New folder\BookMyTickets\BookMyTickets\Views\Bookings\seatSelectionBookingPhase3.cshtml"
                                      ;

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p>Enter Seat Numer:-</p>\r\n");
#nullable restore
#line 96 "E:\wddnProj\New folder\BookMyTickets\BookMyTickets\Views\Bookings\seatSelectionBookingPhase3.cshtml"
           Write(Html.TextBox("Seat2"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 96 "E:\wddnProj\New folder\BookMyTickets\BookMyTickets\Views\Bookings\seatSelectionBookingPhase3.cshtml"
                                      ;

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p>Enter Seat Numer:-</p>\r\n");
#nullable restore
#line 98 "E:\wddnProj\New folder\BookMyTickets\BookMyTickets\Views\Bookings\seatSelectionBookingPhase3.cshtml"
           Write(Html.TextBox("Seat3"));

#line default
#line hidden
#nullable disable
            WriteLiteral("                <input type=\"submit\" class=\"btn btn-primary\" value=\"Book Tickets & Payment will be charged On the Spot of the Theater\">\r\n");
#nullable restore
#line 100 "E:\wddnProj\New folder\BookMyTickets\BookMyTickets\Views\Bookings\seatSelectionBookingPhase3.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n    <hr />\r\n    <div></div>\r\n    <hr />");
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
