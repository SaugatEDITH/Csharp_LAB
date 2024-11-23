<%@ Page Language="C#" AutoEventWireup="true" CodeFile="redirect.aspx.cs" Inherits="studentform.redirect" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>Student Details</title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Student Details</h2>
        <label>Name:</label>
        <asp:Label ID="lblName" runat="server"></asp:Label><br /><br />
        <label>Age:</label>
        <asp:Label ID="lblAge" runat="server"></asp:Label><br /><br />
        <label>Course:</label>
        <asp:Label ID="lblCourse" runat="server"></asp:Label><br /><br />
    </form>
</body>
</html>