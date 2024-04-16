<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="PasswordStrengthApplication.Register" %>

<!DOCTYPE html>
<html>
<head>
    <title>Register</title>
    <script>
        function checkPasswordStrength() {
            var password = document.getElementById('<%= txtPassword.ClientID %>').value;
            // Your JavaScript code to check password strength and provide feedback to users
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" onchange="checkPasswordStrength()"></asp:TextBox>
            <asp:Label ID="lblPasswordStrength" runat="server" Text=""></asp:Label>
            <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" />
            <asp:Label ID="lblErrorMessage" runat="server" ForeColor="Red" Visible="false"></asp:Label>
        </div>
    </form>
</body>
</html>

