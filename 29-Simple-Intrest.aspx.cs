// using System;

// namespace SImpleInterest
// {
//     public partial class Default : System.Web.UI.Page
//     {
//         protected void btnCalculate_Click(object sender, EventArgs e)
//         {
//             try
//             {
//                 // Retrieve user inputs
//                 double principal = Convert.ToDouble(txtPrincipal.Value);
//                 double rate = Convert.ToDouble(txtRate.Value);
//                 double time = Convert.ToDouble(txtTime.Value);

//                 // Calculate Simple Interest
//                 double interest = (principal * rate * time) / 100;

//                 // Store values in session
//                 Session["Principal"] = principal;
//                 Session["Rate"] = rate;
//                 Session["Time"] = time;
//                 Session["Interest"] = interest;

//                 // Redirect to Result.aspx to display the result
//                 Response.Redirect("prahar.aspx");
//             }
//             catch (Exception ex)
//             {
//                 // Handle errors (e.g., invalid input)
//                 Response.Write($"<script>alert('Error: {ex.Message}');</script>");
//             }
//         }
//     }
// }