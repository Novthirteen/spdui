<%@ Control Language="C#" AutoEventWireup="true" CodeFile="NewBatchReport.ascx.cs"
    Inherits="Modules_OffLineReport_BatchMaintenance_NewBatchReport" %>
<!-- Modified By Vincent On 2006-9-3 Begin -->


<h2>
    Report</h2>
<p class="formBtnBoard">
    <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click"
        CssClass="btn" />
    <asp:Button ID="btnBack" runat="server" Text="Back" OnClick="btnBack_Click" CssClass="btn" />
</p>
<asp:HiddenField ID="txtReportBatchId" runat="server" />
<asp:GridView ID="gvReportList" runat="server" DataKeyNames="Id" AutoGenerateColumns="false"
    CellPadding="4" CssClass="list" GridLines="Horizontal">
    <HeaderStyle CssClass="listhead" HorizontalAlign="Left" />
    <Columns>
        <asp:TemplateField HeaderText="Report">
            <ItemTemplate>
                <asp:CheckBox ID="cbSelect" runat="server" Checked='<%# hasData((int)DataBinder.Eval(Container.DataItem, "Id")) %>' />
            </ItemTemplate>
        </asp:TemplateField>
        <asp:BoundField DataField="Id" HeaderText="Id"></asp:BoundField>
        <asp:BoundField DataField="Name" HeaderText="Report Name"></asp:BoundField>
        <asp:BoundField DataField="ReportType" HeaderText="Report Type"></asp:BoundField>
        <asp:BoundField DataField="Description" HeaderText="Description"></asp:BoundField>
    </Columns>
</asp:GridView>
<asp:Label ID="lblMessage" runat="server" Visible="false" CssClass="error"></asp:Label>
<!-- Modified By Vincent On 2006-9-3 End -->
