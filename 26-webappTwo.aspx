<%@ Page Language="C#" Inherits="country_form.Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registration Form</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Registration Form</h2>

            <!-- Name Field -->
            <asp:Label ID="lblName" runat="server" Text="Name:" AssociatedControlID="txtName"></asp:Label>
            <asp:TextBox ID="txtName" runat="server" Width="200px"></asp:TextBox>
            <br /><br />

            <!-- Password Field -->
            <asp:Label ID="lblPassword" runat="server" Text="Password:" AssociatedControlID="txtPassword"></asp:Label>
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" Width="200px"></asp:TextBox>
            <br /><br />

            <!-- Confirm Password Field -->
            <asp:Label ID="lblConfirmPassword" runat="server" Text="Confirm Password:" AssociatedControlID="txtConfirmPassword"></asp:Label>
            <asp:TextBox ID="txtConfirmPassword" runat="server" TextMode="Password" Width="200px"></asp:TextBox>
            <br /><br />

            <!-- Age Field -->
            <asp:Label ID="lblAge" runat="server" Text="Age:" AssociatedControlID="txtAge"></asp:Label>
            <asp:TextBox ID="txtAge" runat="server" Width="50px"></asp:TextBox>
            <br /><br />

            <!-- Email ID Field -->
            <asp:Label ID="lblEmail" runat="server" Text="Email ID:" AssociatedControlID="txtEmail"></asp:Label>
            <asp:TextBox ID="txtEmail" runat="server" TextMode="Email" Width="200px"></asp:TextBox>
            <br /><br />

            <!-- Submit Button -->
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" />
            <br /><br />

            <!-- Label to display submission result -->
            <asp:Label ID="lblResult" runat="server" ForeColor="Green"></asp:Label>
        </div>
    </form>
</body>
</html>