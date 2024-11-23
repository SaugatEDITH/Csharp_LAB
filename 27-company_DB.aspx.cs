// using System;
// using MySql.Data.MySqlClient;
// using System.Web.UI.WebControls;

// namespace country_form
// {
//     public partial class Default : System.Web.UI.Page
//     {
//         // Connection string to MySQL database
//         string connStr = "Server=localhost;Database=company;Uid=saugat;Pwd=hackthebox;";

//         protected void Page_Load(object sender, EventArgs e)
//         {
//             if (!IsPostBack)
//             {
//                 BindGridView();
//             }
//         }

//         // Method to bind GridView with products having unitwise > 1000
//         private void BindGridView()
//         {
//             using (MySqlConnection conn = new MySqlConnection(connStr))
//             {
//                 string query = "SELECT productID, productName, unitwise FROM products WHERE unitwise > 1000";
//                 MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
//                 System.Data.DataTable dt = new System.Data.DataTable();
//                 adapter.Fill(dt);
//                 GridView1.DataSource = dt;
//                 GridView1.DataBind();
//             }
//         }

//         // Event handler when a user selects a product from the GridView
//         protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
//         {
//             if (e.CommandName == "Select")
//             {
//                 int rowIndex = Convert.ToInt32(e.CommandArgument);
//                 GridViewRow row = GridView1.Rows[rowIndex];
//                 string productID = row.Cells[0].Text;
//                 string productName = row.Cells[1].Text;
//                 string unitwise = row.Cells[2].Text;

//                 // Set the values to the form controls for updating
//                 txtProductID.Text = productID;
//                 txtProductName.Text = productName;
//                 txtUnitwise.Text = unitwise;
//             }
//         }

//         // Method to handle the Update button click event
//         protected void btnUpdate_Click(object sender, EventArgs e)
//         {
//             int productID = Convert.ToInt32(txtProductID.Text);
//             string productName = txtProductName.Text;
//             int unitwise = Convert.ToInt32(txtUnitwise.Text);

//             using (MySqlConnection conn = new MySqlConnection(connStr))
//             {
//                 string query = "UPDATE products SET productName = @productName, unitwise = @unitwise WHERE productID = @productID";
//                 MySqlCommand cmd = new MySqlCommand(query, conn);

//                 cmd.Parameters.AddWithValue("@productID", productID);
//                 cmd.Parameters.AddWithValue("@productName", productName);
//                 cmd.Parameters.AddWithValue("@unitwise", unitwise);

//                 conn.Open();
//                 cmd.ExecuteNonQuery();
//                 conn.Close();
//             }

//             // Rebind the GridView to reflect updated data
//             BindGridView();
//         }
//     }
// }