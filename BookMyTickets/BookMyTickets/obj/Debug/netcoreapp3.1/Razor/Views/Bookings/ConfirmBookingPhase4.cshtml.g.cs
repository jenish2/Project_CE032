#pragma checksum "E:\wddnProj\New folder\BookMyTickets\BookMyTickets\Views\Bookings\ConfirmBookingPhase4.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0df71d99e44c4da8e52a4db4b72b46d056f1f91b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Bookings_ConfirmBookingPhase4), @"mvc.1.0.view", @"/Views/Bookings/ConfirmBookingPhase4.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0df71d99e44c4da8e52a4db4b72b46d056f1f91b", @"/Views/Bookings/ConfirmBookingPhase4.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"270fea9b205752f6f2052668a274f363ab2994be", @"/Views/_ViewImports.cshtml")]
    public class Views_Bookings_ConfirmBookingPhase4 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Booking>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<h2>Tickets are Successfully Booked</h2>

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
            BeginWriteAttribute("src", " src=\"", 632, "\"", 650, 1);
#nullable restore
#line 29 "E:\wddnProj\New folder\BookMyTickets\BookMyTickets\Views\Bookings\ConfirmBookingPhase4.cshtml"
WriteAttributeValue("", 638, ViewBag.Url, 638, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top\">\r\n                    </div>\r\n                </div>\r\n                <div class=\"column\">\r\n                    <h2> Movie Name:- ");
#nullable restore
#line 33 "E:\wddnProj\New folder\BookMyTickets\BookMyTickets\Views\Bookings\ConfirmBookingPhase4.cshtml"
                                 Write(ViewBag.MovieName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                    <b>Movie Language:-</b>\r\n                    <p>");
#nullable restore
#line 35 "E:\wddnProj\New folder\BookMyTickets\BookMyTickets\Views\Bookings\ConfirmBookingPhase4.cshtml"
                  Write(ViewBag.Language);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <b>Movie Genre:-</b>\r\n                    <p>");
#nullable restore
#line 37 "E:\wddnProj\New folder\BookMyTickets\BookMyTickets\Views\Bookings\ConfirmBookingPhase4.cshtml"
                  Write(ViewBag.Genre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <b>Movie Director:-</b>\r\n                    <p>");
#nullable restore
#line 39 "E:\wddnProj\New folder\BookMyTickets\BookMyTickets\Views\Bookings\ConfirmBookingPhase4.cshtml"
                  Write(ViewBag.Director);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <b>Movie duration:-</b>\r\n                    <p>");
#nullable restore
#line 41 "E:\wddnProj\New folder\BookMyTickets\BookMyTickets\Views\Bookings\ConfirmBookingPhase4.cshtml"
                  Write(ViewBag.Duretion);

#line default
#line hidden
#nullable disable
            WriteLiteral(" min.</p>\r\n                    <b>Movie releaseDate:-</b>\r\n                    <p>");
#nullable restore
#line 43 "E:\wddnProj\New folder\BookMyTickets\BookMyTickets\Views\Bookings\ConfirmBookingPhase4.cshtml"
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
#line 53 "E:\wddnProj\New folder\BookMyTickets\BookMyTickets\Views\Bookings\ConfirmBookingPhase4.cshtml"
                       Write(Model.ShowId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    </tr>\r\n                    <tr>\r\n                        <td><b>Theater Name:-</b></td>\r\n                        <td>");
#nullable restore
#line 58 "E:\wddnProj\New folder\BookMyTickets\BookMyTickets\Views\Bookings\ConfirmBookingPhase4.cshtml"
                       Write(Model.TheaterName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    </tr>\r\n                    <tr>\r\n                        <td><b>Screen No:-</b></td>\r\n                        <td>");
#nullable restore
#line 63 "E:\wddnProj\New folder\BookMyTickets\BookMyTickets\Views\Bookings\ConfirmBookingPhase4.cshtml"
                       Write(Model.ScreenNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    </tr>\r\n                    <tr>\r\n                        <td><b>Show Starting Time:-</b></td>\r\n                        <td>");
#nullable restore
#line 68 "E:\wddnProj\New folder\BookMyTickets\BookMyTickets\Views\Bookings\ConfirmBookingPhase4.cshtml"
                       Write(ViewBag.StartTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    </tr>\r\n                    <tr>\r\n                        <td><b>Show Date:-</b></td>\r\n                        <td>");
#nullable restore
#line 73 "E:\wddnProj\New folder\BookMyTickets\BookMyTickets\Views\Bookings\ConfirmBookingPhase4.cshtml"
                       Write(Model.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    </tr>\r\n                    <tr>\r\n                        <td><b>Price per seat:-</b></td>\r\n                        <td>");
#nullable restore
#line 78 "E:\wddnProj\New folder\BookMyTickets\BookMyTickets\Views\Bookings\ConfirmBookingPhase4.cshtml"
                       Write(ViewBag.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Rs.</td>\r\n\r\n                    </tr>\r\n                    <tr>\r\n                        <td><b>User Name:-</b></td>\r\n                        <td>");
#nullable restore
#line 83 "E:\wddnProj\New folder\BookMyTickets\BookMyTickets\Views\Bookings\ConfirmBookingPhase4.cshtml"
                       Write(Model.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    </tr>\r\n                    <tr>\r\n                        <td><b>Screen Number:-</b></td>\r\n                        <td>");
#nullable restore
#line 88 "E:\wddnProj\New folder\BookMyTickets\BookMyTickets\Views\Bookings\ConfirmBookingPhase4.cshtml"
                       Write(Model.ScreenNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    </tr>\r\n                    <tr>\r\n                        <td><b>Total Ticket(Seat) Booked:-</b></td>\r\n                        <td>");
#nullable restore
#line 93 "E:\wddnProj\New folder\BookMyTickets\BookMyTickets\Views\Bookings\ConfirmBookingPhase4.cshtml"
                       Write(Model.TotalTickets);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    </tr>\r\n                    <tr>\r\n                        <td><b>Seat Number:-</b></td>\r\n                        <td>");
#nullable restore
#line 98 "E:\wddnProj\New folder\BookMyTickets\BookMyTickets\Views\Bookings\ConfirmBookingPhase4.cshtml"
                       Write(Model.SeatNo1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    </tr>\r\n                    <tr>\r\n                        <td><b>Seat Number:-</b></td>\r\n                        <td>");
#nullable restore
#line 103 "E:\wddnProj\New folder\BookMyTickets\BookMyTickets\Views\Bookings\ConfirmBookingPhase4.cshtml"
                       Write(Model.SeatNo2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    </tr>\r\n                    <tr>\r\n                        <td><b>Seat Number:-</b></td>\r\n                        <td>");
#nullable restore
#line 108 "E:\wddnProj\New folder\BookMyTickets\BookMyTickets\Views\Bookings\ConfirmBookingPhase4.cshtml"
                       Write(Model.SeatNo3);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    </tr>\r\n                    <tr>\r\n                        <td><b>Total Cost(14% Gst & 4%other charges are included):-</b></td>\r\n                        <td>");
#nullable restore
#line 113 "E:\wddnProj\New folder\BookMyTickets\BookMyTickets\Views\Bookings\ConfirmBookingPhase4.cshtml"
                       Write(Model.TotalCost);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    </tr>\r\n                    <tr>\r\n                        <td><b>City:-</b></td>\r\n                        <td>");
#nullable restore
#line 118 "E:\wddnProj\New folder\BookMyTickets\BookMyTickets\Views\Bookings\ConfirmBookingPhase4.cshtml"
                       Write(Model.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <hr />\r\n    <div></div>\r\n    <hr />\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Booking> Html { get; private set; }
    }
}
#pragma warning restore 1591
