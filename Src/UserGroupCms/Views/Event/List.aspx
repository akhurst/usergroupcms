<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<UserGroupCms.Models.Event>>" %>
<%@ Import Namespace="UserGroupCms.Models"%>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Aggieland DNUG Event List
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Upcoming Events</h2>
			<%
				foreach (Event ev in Model)
				{
					if(ev.Date > DateTime.Today.AddDays(1))
						Html.RenderPartial("EventDetails", ev);
				}
			%>

    <h2>Past Events</h2>
			<%
				foreach (Event ev in Model)
				{
					if(ev.Date <= DateTime.Today.AddDays(1))
						Html.RenderPartial("EventHistory", ev);
				}
			%>

		<% if(ViewData["UserAccount"] != null && ((Account)ViewData["UserAccount"]).Admin) {%>
    <p>
        <%= Html.ActionLink("Create New", "Create") %>
    </p>
    <%} %>

</asp:Content>

