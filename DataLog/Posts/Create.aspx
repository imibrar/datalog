<%@ Page Title="Create New Post" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Create.aspx.cs" Inherits="DataLog.Posts.Create" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <h2><%: Title %>.</h2>

    <div class="form-horizontal">
        <h4>Add a New Post</h4>
        <hr />
        <asp:ValidationSummary runat="server" CssClass="text-danger" />
        <p class="text-danger">
            <asp:Literal runat="server" ID="ErrorMessage" />
        </p>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="Title1" CssClass="col-md-2 control-label">Title</asp:Label>
            <div class="col-md-10">
               <asp:TextBox runat="server" ID="Title1" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="Title1"
                                            CssClass="text-danger" ErrorMessage="The Title field is required." />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="Details" CssClass="col-md-2 control-label">Details</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="Details" CssClass="form-control" TextMode="MultiLine" ></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="Details"
                                            CssClass="text-danger" ErrorMessage="The Details field is required." />
            </div>
        </div>
        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <asp:Button runat="server" OnClick="BtnPost_Click"
                            Text="Submit" CssClass="btn btn-default" />
            </div>
        </div>
    </div>
</asp:Content>
