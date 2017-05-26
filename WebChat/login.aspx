<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="WebChat.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="lbNickname" runat="server" Text="Nickname:" Style="padding-right:10px;"></asp:Label>
        <asp:TextBox ID="txtNickname" runat="server" ></asp:TextBox>
        <asp:Button ID="btnEnter" runat="server" Text="Enter" OnClick="btnEnter_Click"/>
    </div>
    </form>
</body>
</html>
