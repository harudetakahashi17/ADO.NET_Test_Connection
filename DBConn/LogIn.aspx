<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="DBConn.LogIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Log In</title>
</head>
<body>
    <h2>Log In Page</h2>
    <a href="Default.aspx">Home</a> | <a href="Registration.aspx">Registration</a>
    <h2>Hello, 
        <asp:Label ID="lbUser" Text="" runat="server"></asp:Label>
    </h2>
    <form id="form1" runat="server">
        <asp:FileUpload ID="fileUp" runat="server" />
        <asp:Button ID="btnUpload" Text="Upload" runat="server" OnClick="UploadBtn" />
    </form>
    <asp:Label ID="lblNotif" runat="server"></asp:Label>
</body>
</html>
