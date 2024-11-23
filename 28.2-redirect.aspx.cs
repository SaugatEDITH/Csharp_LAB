// using System;

// namespace studentform
// {
//     public partial class redirect : System.Web.UI.Page
//     {
//         protected void Page_Load(object sender, EventArgs e)
//         {
//             if (!IsPostBack)
//             {
//                 lblName.Text = Session["Name"] as string ?? "N/A";
//                 lblAge.Text = Session["Age"] as string ?? "N/A";
//                 lblCourse.Text = Session["Course"] as string ?? "N/A";
//             }
//         }
//     }
// }