<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="WebChat.index" ValidateRequest="false" EnableEventValidation="false" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>WebChat</title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="align-content:center">
        <asp:ScriptManager ID="scriptManager" runat="server"></asp:ScriptManager>
        
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:Label ID="lbMessages" runat="server" Text=""></asp:Label>
                <asp:TextBox ID="txtMessage" runat="server" Width="602px" onfocus="this.value=this.value;"></asp:TextBox>
                <asp:Button ID="btnSendMessage" runat="server" Text="Send Message" OnClick="btnSendMessage_Click"/>
                <asp:Timer ID="timerRefresher" runat="server" Interval="10000" OnTick="timerRefresher_Tick"></asp:Timer>
            </ContentTemplate>
        </asp:UpdatePanel>
    </div>
    </form>
</body>
</html>
