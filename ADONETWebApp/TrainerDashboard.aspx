<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TrainerDashboard.aspx.cs" Inherits="ADONETWebApp.TrainerDashboard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>All Trainers</h1>
            <asp:GridView ID="gvTrainer" runat="server" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black" GridLines="None">
                <AlternatingRowStyle BackColor="PaleGoldenrod"></AlternatingRowStyle>

                <FooterStyle BackColor="Tan"></FooterStyle>

                <HeaderStyle BackColor="Tan" Font-Bold="True"></HeaderStyle>

                <PagerStyle HorizontalAlign="Center" BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue"></PagerStyle>

                <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite"></SelectedRowStyle>

                <SortedAscendingCellStyle BackColor="#FAFAE7"></SortedAscendingCellStyle>

                <SortedAscendingHeaderStyle BackColor="#DAC09E"></SortedAscendingHeaderStyle>

                <SortedDescendingCellStyle BackColor="#E1DB9C"></SortedDescendingCellStyle>

                <SortedDescendingHeaderStyle BackColor="#C2A47B"></SortedDescendingHeaderStyle>
            </asp:GridView>
            <asp:Label ID="lblMessage" runat="server" Text="Label" ForeColor="Red"></asp:Label>
        </div>
    </form>
</body>
</html>
