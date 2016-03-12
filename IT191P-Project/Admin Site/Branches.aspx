<%@ Page Title="" Language="C#" MasterPageFile="~/Admin Site/Admin.Master" AutoEventWireup="true" CodeBehind="Branches.aspx.cs" Inherits="IT191P_Project.Admin_Site.WebForm6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title_bar" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main_content" runat="server">
    <h1 class="page-header">Current Branches</h1>

    <div class="col-lg-2">
        <asp:DropDownList CssClass="form-control" ID="ddlSearchType" runat="server">
             <asp:ListItem>ID</asp:ListItem>
             <asp:ListItem>Location</asp:ListItem>
             <asp:ListItem>Branch Manager</asp:ListItem>
             <asp:ListItem>Branch Owner</asp:ListItem>
        </asp:DropDownList>
    </div>
    <div class="form-group input-group col-lg-10">
        <asp:TextBox type="text" ID="txtSearch" CssClass="form-control" runat="server" placeholder="Search"></asp:TextBox>
        <span class="input-group-btn">
            <button class="btn btn-default" type="button"><i class="fa fa-search"></i></button>
        </span>
    </div>

    (insert gridview here :v)

    
</asp:Content>
