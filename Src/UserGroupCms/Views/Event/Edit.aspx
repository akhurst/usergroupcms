<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<UserGroupCms.Models.Event>" %>
<%@ Import Namespace="UserGroupCms.Models"%>

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
                <label for="EventLink1Text">EventLink1Text:</label>
                <%= Html.TextBox("EventLink1Text", Model.EventLink1Text) %>
                <%= Html.ValidationMessage("EventLink1Text", "*") %>
            </p>
            <p>
                <label for="EventLink1Url">EventLink1Url:</label>
                <%= Html.TextBox("EventLink1Url", Model.EventLink1Url) %>
                <%= Html.ValidationMessage("EventLink1Url", "*") %>
            </p>
            <p>
                <label for="EventLink2Text">EventLink2Text:</label>
                <%= Html.TextBox("EventLink2Text", Model.EventLink2Text) %>
                <%= Html.ValidationMessage("EventLink2Text", "*") %>
            </p>
            <p>
                <label for="EventLink2Url">EventLink2Url:</label>
                <%= Html.TextBox("EventLink2Url", Model.EventLink2Url) %>
                <%= Html.ValidationMessage("EventLink2Url", "*") %>
            </p>
            <p>
                <label for="ArtifactsUrl">ArtifactsUrl:</label>
                <%= Html.TextBox("ArtifactsUrl", Model.ArtifactsUrl) %>
                <%= Html.ValidationMessage("ArtifactsUrl", "*") %>
            </p>
            <p>
						 <label for="Sponsors">Sponsors:</label>
							<%=Html.ListBox("SponsorsList", new MultiSelectList(ViewData["Companies"] as IList<UserGroupCms.Models.Company>, "Id", "Name", Model.Sponsors)) %>
            </p>
            <p>
						 <label for="Speakers">Speakers:</label>
							<%=Html.ListBox("SpeakersList", new MultiSelectList(ViewData["Speakers"] as IList<UserGroupCms.Models.Person>, "Id", "Name", Model.Speakers)) %>
            </p>
            <p>
							 <label for="Venue">Venue:</label>
							<%=Html.DropDownList("VenuesList", new SelectList(ViewData["Venues"] as IList<UserGroupCms.Models.Venue>, "Id", "Name", Model.Venue))%>
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

