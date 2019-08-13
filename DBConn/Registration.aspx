<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="DBConn.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registration</title>
</head>
<body>
    <h2>Registration Page</h2>
    <a href="Default.aspx">Home</a> | <a href="Registration.aspx">Registration</a>
    <form id="form1" runat="server">
        <div>
            <p>Input New Username</p>
            <asp:TextBox ID="tbNewUsername" Text="" runat="server" ></asp:TextBox>
            <p>Enter New Password</p>
            <asp:TextBox ID="tbNewPassword" Text="" runat="server"></asp:TextBox>
            <p>Enter NIM</p>
            <asp:TextBox ID="tbNIM" Text="" runat="server"></asp:TextBox>
            <p>Enter Name</p>
            <asp:TextBox ID="tbName" Text="" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnRegSubmit" Text="Submit" runat="server" OnClick="regEventMethod" />
        </div>
    </form>
</body>
</html>
