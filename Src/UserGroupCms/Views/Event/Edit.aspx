<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<UserGroupCms.Models.Event>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Edit
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Edit</h2>

    <%= Html.ValidationSummary("Edit was unsuccessful. Please correct the errors and try again.") %>

    <% using (Html.BeginForm()) {%>

        <fieldset>
            <legend>Fields</legend>
            <p>
                <label for="Date">Date:</label>
                <%= Html.TextBox("Date", String.Format("{0:g}", Model.Date)) %>
                <%= Html.ValidationMessage("Date", "*") %>
            </p>
            <p>
                <label for="Title">Title:</label>
                <%= Html.TextBox("Title", Model.Title) %>
                <%= Html.ValidationMessage("Title", "*") %>
            </p>
            <p>
                <label for="Summary">Summary:</label>
                <%= Html.TextBox("Summary", Model.Summary) %>
                <%= Html.ValidationMessage("Summary", "*") %>
            </p>
            <p>
                <label for="EventLink">EventLink:</label>
                <%= Html.TextBox("EventLink", Model.EventLink) %>
                <%= Html.ValidationMessage("EventLink", "*") %>
            </p>
            <p>
                <label for="ArtifactsUrl">ArtifactsUrl:</label>
                <%= Html.TextBox("ArtifactsUrl", Model.ArtifactsUrl) %>
                <%= Html.ValidationMessage("ArtifactsUrl", "*") %>
            </p>
            <p>
						 <label for="Sponsord">Id:</label>
							<%=Html.ListBox("Sponsors", new MultiSelectList(ViewData["Sponsors"] as IList<UserGroupCms.Models.Sponsor>, "Id", "Name")) %>
            </p>
            <p>
                <input type="submit" value="Save" />
            </p>
        </fieldset>

    <% } %>

    <div>
        <%=Html.ActionLink("Back to List", "Index") %>
    </div>

</asp:Content>

