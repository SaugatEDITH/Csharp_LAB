// using System;
// using System.Web;
// using System.Web.UI;

// namespace SImpleIntrest
// {

//     public partial class prahar : System.Web.UI.Page
//     {
//         protected void Page_Load(object sender, EventArgs e)
//         {
//             try
//             {
//                 // Retrieve values from the session
//                 double principal = 0;
//                 double rate = 0;
//                 double time = 0;
//                 double interest = 0;

//                 if (Session["Principal"] != null && Session["Rate"] != null && Session["Time"] != null && Session["Interest"] != null)
//                 {
//                     principal = Convert.ToDouble(Session["Principal"]);
//                     rate = Convert.ToDouble(Session["Rate"]);
//                     time = Convert.ToDouble(Session["Time"]);
//                     interest = Convert.ToDouble(Session["Interest"]);
//                 }
//                 else
//                 {
//                     Result.Text = "Error: Missing data.";
//                     return;
//                 }

//                 // Display the result on the lblResult label
//                 Result.Text = $"Principal: {principal}<br/>" +
//                                  $"Rate: {rate}%<br/>" +
//                                  $"Time: {time} years<br/>" +
//                                  $"Simple Interest: {interest}";
//             }
//             catch (Exception ex)
//             {
//                 // Handle any exceptions and show the error message
//                 Result.Text = "Error: " + ex.Message;
//             }
//         }
//     }
// }
