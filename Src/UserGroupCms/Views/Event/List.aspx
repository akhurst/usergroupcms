<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<UserGroupCms.Models.Event>>" %>
<%@ Import Namespace="UserGroupCms.Models"%>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	List
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Event List</h2>

<%
	foreach (Event ev in Model)
		Html.RenderPartial("EventDetails", ev);
%>

    <p>
        <%= Html.ActionLink("Create New", "Create") %>
    </p>

</asp:Content>

