<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<UserGroupCms.Models.UserGroup>" %>

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
                <label for="Name">Name:</label>
                <%= Html.TextBox("Name", Model.Name) %>
                <%= Html.ValidationMessage("Name", "*") %>
            </p>
            <p>
                <label for="ShortName">ShortName:</label>
                <%= Html.TextBox("ShortName", Model.ShortName) %>
                <%= Html.ValidationMessage("ShortName", "*") %>
            </p>
            <p>
                <label for="LogoUrl">LogoUrl:</label>
                <%= Html.TextBox("LogoUrl", Model.LogoUrl) %>
                <%= Html.ValidationMessage("LogoUrl", "*") %>
            </p>
            <p>
                <label for="WelcomeMessage">WelcomeMessage:</label>
                <%= Html.TextArea("WelcomeMessage", Model.WelcomeMessage) %>
                <%= Html.ValidationMessage("WelcomeMessage", "*") %>
            </p>
            <p>
                <label for="Inactive">Inactive:</label>
                <%= Html.TextBox("Inactive", Model.Inactive) %>
                <%= Html.ValidationMessage("Inactive", "*") %>
            </p>
            <p>
                <label for="ContactInfo">ContactInfoHtml:</label>
                <%= Html.TextArea("ContactInfo", Model.ContactInfoHtml) %>
                <%= Html.ValidationMessage("ContactInfo", "*") %>
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

