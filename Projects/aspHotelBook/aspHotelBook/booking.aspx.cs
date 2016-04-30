using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html.simpleparser;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace aspHotelBook
{
    public partial class booking : Page
    {
        //querystrings
        private string _checkInDate;
        private string _checkOutDate;
        private string _roomId;

        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            FixNavbarLoginView();

            //if user is logged in, enable right login view.
            if (User.Identity.IsAuthenticated)
            {
                EnableCorrectLoginView();
            }
            //else redirect to login page.
            else
            {
                Response.Redirect("account/login.aspx");
            }
            

            _checkInDate = Request.QueryString["checkIn"];
            _checkOutDate = Request.QueryString["checkOut"];
            _roomId = Request.QueryString["room"];

            //if some information is missing then redirect to main page.
            if (_checkInDate == null || _checkOutDate == null || _roomId == null)
            {
                Response.Redirect("default.aspx");
            }
        }

        /// <summary>
        /// Enables the correct login view.
        /// </summary>
        private void EnableCorrectLoginView()
        {
            //initate user manager 
            var userManager = new UserManager<IdentityUser>(new UserStore<IdentityUser>());

            //find the user
            IdentityUser user = userManager.FindById(User.Identity.GetUserId());

            //check which role user is, and enable login view.
            if (userManager.IsInRole(user.Id, "Admin") || userManager.IsInRole(user.Id, "Employee"))
            {
                lvManage.Visible = true;
                lvCustomer.Visible = false;
            }
            else
            {
                lvManage.Visible = false;
                lvCustomer.Visible = true;
            }
        }

        /// <summary>
        ///     Fixes the navbar login view.
        /// </summary>
        private void FixNavbarLoginView()
        {
            //Usermanager
            var userManager = new UserManager<IdentityUser>(new UserStore<IdentityUser>());

            //find controls from master page
            var adminView = (LoginView)Master.FindControl("lvAdminContent");
            var employeeView = (LoginView)Master.FindControl("lvEmployeeContent");
            var userStatus = (LoginView)Master.FindControl("lvUserStatus");

            //find user from list
            //IdentityUser user = userManager.FindByName(listBoxAllUsers.SelectedValue);
            if (User.Identity.IsAuthenticated)
            {
                IdentityUser user = userManager.FindByName(User.Identity.Name);

                if (userManager.IsInRole(user.Id, "Admin"))
                {
                    adminView.Visible = true;
                    employeeView.Visible = false;
                    userStatus.Visible = false;
                }
                else if (userManager.IsInRole(user.Id, "Employee"))
                {
                    adminView.Visible = false;
                    employeeView.Visible = true;
                    userStatus.Visible = false;
                }
                else
                {
                    adminView.Visible = false;
                    employeeView.Visible = false;
                    userStatus.Visible = true;
                }
            }
        }

        /// <summary>
        /// Books the room for user (ADMIN OR EMPLOYEE).
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void BookRoomForUser(object sender, EventArgs e)
        {
            //Finds the controls needed from the Manage login view:
            var tbFullName = (TextBox) lvManage.FindControl("tbFullName");
            var tbUserName = (TextBox) lvManage.FindControl("tbUserName");
            var tbTelephone = (TextBox) lvManage.FindControl("tbTelephone");
            
            try
            {
                sqlBookings.InsertParameters["HotelName"].DefaultValue = "Sandy Beach";
                sqlBookings.InsertParameters["RoomNr"].DefaultValue = _roomId;
                sqlBookings.InsertParameters["CheckedIn"].DefaultValue = _checkInDate;
                sqlBookings.InsertParameters["CheckingOut"].DefaultValue = _checkOutDate;
                sqlBookings.InsertParameters["NameOfBook"].DefaultValue = tbFullName.Text;
                sqlBookings.InsertParameters["Telephone"].DefaultValue = tbTelephone.Text;

                sqlBookings.InsertParameters["Account"].DefaultValue = string.IsNullOrEmpty(tbUserName.Text)
                                                                           ? ""
                                                                           : tbUserName.Text;

                sqlBookings.Insert();

                lblMessage.Text =
                    $"Booked room {_roomId} for {tbFullName.Text} from {_checkInDate.Trim()} to {_checkOutDate.Trim()}";
                lblMessage.ForeColor = Color.Green;
                            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message;
            }
        }

        /// <summary>
        /// Books the room (CUSTOMER).
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void BookRoom(object sender, EventArgs e)
        {
            //finds the controls from Customer login view.
            var tbFullName = (TextBox)lvCustomer.FindControl("tbFullName");
            var tbTelephone = (TextBox)lvCustomer.FindControl("tbTelephone");

            //gets the username of the current user
            string account = User.Identity.Name;

            try
            {
                sqlBookings.InsertParameters["HotelName"].DefaultValue = "Sandy Beach";
                sqlBookings.InsertParameters["RoomNr"].DefaultValue = _roomId;
                sqlBookings.InsertParameters["CheckedIn"].DefaultValue = _checkInDate;
                sqlBookings.InsertParameters["CheckingOut"].DefaultValue = _checkOutDate;
                sqlBookings.InsertParameters["NameOfBook"].DefaultValue = tbFullName.Text;
                sqlBookings.InsertParameters["Telephone"].DefaultValue = tbTelephone.Text;

                sqlBookings.InsertParameters["Account"].DefaultValue = account;

                sqlBookings.Insert();

                lblMessage.Text =
                    $"Booked room {_roomId} for {tbFullName.Text} from {_checkInDate.Trim()} to {_checkOutDate.Trim()}";
                lblMessage.ForeColor = Color.Green;

                //create and prompt user to download PDF receipt.
                CreateReceipt(_roomId, tbFullName.Text, _checkInDate, _checkOutDate);


            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message;
            }
        }

        /// <summary>
        /// Create a receipt.
        /// </summary>
        /// <param name="roomId">The room number.</param>
        /// <param name="text">The text.</param>
        /// <param name="checkInDate">The check in date.</param>
        /// <param name="checkOutDate">The check out date.</param>
        /// <param name="name">The name.</param>
        private void CreateReceipt(string roomId, string name, string checkInDate, string checkOutDate)
        {
            using (StringWriter sw = new StringWriter())
            {
                using (HtmlTextWriter hw = new HtmlTextWriter(sw))
                {
                    StringBuilder sb = new StringBuilder();

                    //Generate Receipt Header.
                    sb.Append("<table width='100%' cellspacing='0' cellpadding='2'>");
                    sb.Append("<tr>" +
                              "<td align='center'" +
                              " style='background-color: #18B5F0' " +
                              "colspan = '2'>" +
                              "<b>Sandy Beach</b>" +
                              "</td>" +
                              "</tr>");
                    sb.Append("<tr>" 
                        + "<td colspan = '2'>" +
                        "</td>" +
                        "</tr>");
                    sb.Append("<tr><td><b>Receipt</td></tr>");
                    sb.Append("<tr><td><b>Room Number: </b>");
                    sb.Append(roomId);
                    sb.Append("</td></tr>");
                    sb.Append("<tr><td><b>Check In: </b>");
                    sb.Append(checkInDate);
                    sb.Append("</td></tr>");
                    sb.Append("<tr><td><b>Check Out: </b>");
                    sb.Append(checkOutDate);
                    sb.Append("</td></tr>");
                    sb.Append("<tr><td><b>Name of booker: </b>");
                    sb.Append(name);
                    sb.Append("</td></tr>");
                    sb.Append("</table>");
                    sb.Append("<br />");


                    //Export HTML String as PDF.
                    StringReader sr = new StringReader(sb.ToString());
                    Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                    HTMLWorker htmlparser = new HTMLWorker(pdfDoc);
                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, Response.OutputStream);
                    pdfDoc.Open();
                    htmlparser.Parse(sr);
                    pdfDoc.Close();
                    Response.ContentType = "application/pdf";
                    Response.AddHeader("content-disposition", "attachment;filename=Receipt_" + roomId + "_" + name + ".pdf");
                    Response.Cache.SetCacheability(HttpCacheability.NoCache);
                    Response.Write(pdfDoc);
                    Response.End();
                }
            }
        
    }
    }
}