<!-- <%@ Page Language="C#" Inherits="country_form.Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Product Update Form</title>
    <style>
        table, th, td {
            border: 1px solid black;
            border-collapse: collapse;
        }
        th, td {
            padding: 10px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Product List (Unitwise > 1000)</h2>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnRowCommand="GridView1_RowCommand">
                <Columns>
                    <asp:BoundField DataField="productID" HeaderText="Product ID" SortExpression="productID" />
                    <asp:BoundField DataField="productName" HeaderText="Product Name" SortExpression="productName" />
                    <asp:BoundField DataField="unitwise" HeaderText="Unitwise" SortExpression="unitwise" />
                    <asp:ButtonField ButtonType="Button" CommandName="Select" Text="Select" />
                </Columns>
            </asp:GridView>

            <h2>Update Product Information</h2>
            <asp:Label ID="lblProductID" runat="server" Text="Product ID:"></asp:Label>
            <asp:TextBox ID="txtProductID" runat="server" ReadOnly="true"></asp:TextBox><br />

            <asp:Label ID="lblProductName" runat="server" Text="Product Name:"></asp:Label>
            <asp:TextBox ID="txtProductName" runat="server"></asp:TextBox><br />

            <asp:Label ID="lblUnitwise" runat="server" Text="Unitwise:"></asp:Label>
            <asp:TextBox ID="txtUnitwise" runat="server"></asp:TextBox><br />

            <asp:Button ID="btnUpdate" runat="server" Text="Update Product" OnClick="btnUpdate_Click" />
        </div>
    </form>
</body>
</html> -->