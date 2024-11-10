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

            <!-- Address Field -->
            <asp:Label ID="lblAddress" runat="server" Text="Address:" AssociatedControlID="txtAddress"></asp:Label>
            <asp:TextBox ID="txtAddress" runat="server" TextMode="MultiLine" Rows="3" Width="200px"></asp:TextBox>
            <br /><br />

            <!-- Gender Field -->
            <asp:Label ID="lblGender" runat="server" Text="Gender:"></asp:Label>
            <asp:RadioButton ID="rblGenderMale" runat="server" GroupName="Gender" Text="Male" />
            <asp:RadioButton ID="rblGenderFemale" runat="server" GroupName="Gender" Text="Female" />
            <br /><br />

            <!-- Country Field -->
            <asp:Label ID="lblCountry" runat="server" Text="Country:" AssociatedControlID="ddlCountry"></asp:Label>
            <asp:DropDownList ID="ddlCountry" runat="server">
                <asp:ListItem Text="Select Country" Value=""></asp:ListItem>
                <asp:ListItem Text="Nepal" Value="Nepal"></asp:ListItem>
                <asp:ListItem Text="India" Value="India"></asp:ListItem>
                <asp:ListItem Text="United States" Value="United States"></asp:ListItem>
                <asp:ListItem Text="Australia" Value="Australia"></asp:ListItem>
            </asp:DropDownList>
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
