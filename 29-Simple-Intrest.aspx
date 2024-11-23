<%@ Page Language="C#" Inherits="SImpleInterest.Default" %>
<!DOCTYPE html>
<html>
<head>
    <title>Simple Interest Calculation</title>
</head>
<body>
    <h2>Simple Interest Calculator</h2>
    <form id="form1" runat="server">
        <div>
            <label for="txtPrincipal">Principal Amount:</label>
            <input type="text" id="txtPrincipal" runat="server" />
        </div>
        <div>
            <label for="txtRate">Rate of Interest (%):</label>
            <input type="text" id="txtRate" runat="server" />
        </div>
        <div>
            <label for="txtTime">Time (years):</label>
            <input type="text" id="txtTime" runat="server" />
        </div>
        <div>
            <input type="submit" value="Calculate" runat="server" onserverclick="btnCalculate_Click" />
        </div>
    </form>
</body>
</html>