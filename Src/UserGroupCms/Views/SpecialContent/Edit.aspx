<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<UserGroupCms.Models.SpecialContent>" %>

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
                <label for="Title">Title:</label>
                <%= Html.TextBox("Title", Model.Title) %>
                <%= Html.ValidationMessage("Title", "*") %>
            </p>
            <p>
                <label for="Description">Description:</label>
                <%= Html.TextBox("Description", Model.Description) %>
                <%= Html.ValidationMessage("Description", "*") %>
            </p>
            <p>
                <label for="ImageUrl">ImageUrl:</label>
                <%= Html.TextBox("ImageUrl", Model.ImageUrl) %>
                <%= Html.ValidationMessage("ImageUrl", "*") %>
            </p>
            <p>
                <label for="LinkUrl">LinkUrl:</label>
                <%= Html.TextBox("LinkUrl", Model.LinkUrl) %>
                <%= Html.ValidationMessage("LinkUrl", "*") %>
            </p>
            <p>
                <label for="Id">Id:</label>
                <%= Html.TextBox("Id", Model.Id) %>
                <%= Html.ValidationMessage("Id", "*") %>
            </p>
            <p>
                <label for="UserGroupId">UserGroupId:</label>
                <%= Html.TextBox("UserGroupId", Model.UserGroupId) %>
                <%= Html.ValidationMessage("UserGroupId", "*") %>
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

