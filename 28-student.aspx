<%@ Page Language="C#" Inherits="studentform.Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>Student Registration</title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Student Registration Form</h2>
        <label>Student Name:</label>
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox><br /><br />
        <label>Age:</label>
        <asp:TextBox ID="txtAge" runat="server"></asp:TextBox><br /><br />
        <label>Course:</label>
        <asp:TextBox ID="txtCourse" runat="server"></asp:TextBox><br /><br />
        <asp:Button ID="btnSubmit" Text="Submit" runat="server" OnClick="btnSubmit_Click" />
    </form>
</body>
</html>