<%@ Page Title="Posts List"  Language="C#"  MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PostsList.aspx.cs" Inherits="DataLog.Posts.PostsList" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <div class="form-horizontal">
        <h4>
            <asp:HyperLink runat="server" ID="CreateHyperLink" ViewStateMode="Disabled">Add a new Post</asp:HyperLink>
        </h4>
        
        <hr />
        <div class="table-wrapper w-100">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource1" EmptyDataText="There are no data records to display." AllowPaging="True" AllowSorting="True" CellPadding="4" ForeColor="#333333" GridLines="None" OnRowDeleted="GridView1_RowDeleted" OnRowUpdated="GridView1_RowUpdated">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                <asp:BoundField DataField="Id" HeaderText="Id" ReadOnly="True" SortExpression="Id" />
                <asp:BoundField DataField="Title" HeaderText="Title" SortExpression="Title" />
                <asp:BoundField DataField="Details" HeaderText="Details" SortExpression="Details" />
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DefaultConnection %>" DeleteCommand="DELETE FROM [Posts] WHERE [Id] = @Id" InsertCommand="INSERT INTO [Posts] ([Title], [Details]) VALUES (@Title, @Details)" ProviderName="<%$ ConnectionStrings:DefaultConnection.ProviderName %>" SelectCommand="SELECT [Id], [Title], [Details] FROM [Posts]" UpdateCommand="UPDATE [Posts] SET [Title] = @Title, [Details] = @Details WHERE [Id] = @Id">
            <DeleteParameters>
                <asp:Parameter Name="Id" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="Title" Type="String" />
                <asp:Parameter Name="Details" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="Title" Type="String" />
                <asp:Parameter Name="Details" Type="String" />
                <asp:Parameter Name="Id" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
        </div>
    </div>
</asp:Content>
