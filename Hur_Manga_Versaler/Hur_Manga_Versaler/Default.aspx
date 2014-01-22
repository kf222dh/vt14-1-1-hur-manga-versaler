<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Hur_Manga_Versaler.Default" ViewStateMode="Disabled" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" lang="sv">
<head runat="server">
    <title>Hur många versaler</title>
    <link href="Style.css" rel="stylesheet" />
</head>
<body>
    <div class="container">
        <h1>Hur många versaler</h1>
        <form id="form1" runat="server">
            <div>
                <asp:TextBox ID="textBox" runat="server" TextMode="MultiLine" ViewStateMode="Enabled"></asp:TextBox>
                <asp:Label ID="resultLabel" runat="server" Visible="False"></asp:Label>
                <asp:Button ID="sendButton" runat="server" Text="Räkna ut antal versaler" OnClick="sendButton_Click"/>
            </div>
        </form>
    </div>
</body>
</html>