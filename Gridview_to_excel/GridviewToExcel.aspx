<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GridviewToExcel.aspx.cs" Inherits="Gridview_to_excel.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Gridview to Excel</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="float;left;margin-left:70px">
        <h2 style="color:#888;">Codepedia.info</h2>
        <a href="http://codepedia.info/2015/07/export-gridview-data-to-excel-in-asp-net-c/" title="Detail Explaination How to Export gridview data to Excel in Asp.net C#">Click to view Details Explaination</a><br /><br />
    <div>
       
<asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" CellPadding="4" ForeColor="#333333" GridLines="None">
    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
    <EditRowStyle BackColor="#999999" />
    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
    <SortedAscendingCellStyle BackColor="#E9E7E2" />
    <SortedAscendingHeaderStyle BackColor="#506C8C" />
    <SortedDescendingCellStyle BackColor="#FFFDF8" />
    <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
</asp:GridView><br />
<asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="Grid to CSV" />
   
    </div></div>
    </form>
</body>
</html>
