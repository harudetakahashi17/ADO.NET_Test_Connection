<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DBConn.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Home</title>
</head>
<body>
    <h2>Home</h2>
    <a href="Default.aspx">Home</a> | <a href="Registration.aspx">Registration</a>
    <form id="form1" runat="server">
        <div>
            <p>Input Username</p>
            <asp:TextBox ID="tbUsername" Text="" runat="server"></asp:TextBox>
            <p>Enter Password</p>
            <asp:TextBox ID="tbPassword" Text="" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnSubmit" Text="Log In" runat="server" OnClick="submitEventMethod" />
        </div>
    </form>
</body>
</html>
