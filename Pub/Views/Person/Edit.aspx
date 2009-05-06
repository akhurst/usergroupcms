<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<UserGroupCms.Models.Person>" %>

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
                <label for="BlogUrl">BlogUrl:</label>
                <%= Html.TextBox("BlogUrl", Model.BlogUrl) %>
                <%= Html.ValidationMessage("BlogUrl", "*") %>
            </p>
            <p>
                <label for="Url2">Url2:</label>
                <%= Html.TextBox("Url2", Model.Url2) %>
                <%= Html.ValidationMessage("Url2", "*") %>
            </p>
            <p>
                <label for="Bio">Bio:</label>
                <%= Html.TextBox("Bio", Model.Bio) %>
                <%= Html.ValidationMessage("Bio", "*") %>
            </p>
            <p>
                <label for="ImagePath">ImagePath:</label>
                <%= Html.TextBox("ImagePath", Model.ImagePath) %>
                <%= Html.ValidationMessage("ImagePath", "*") %>
            </p>
            <p>
                <label for="CompanyName">CompanyName:</label>
                <%= Html.TextBox("CompanyName", Model.CompanyName) %>
                <%= Html.ValidationMessage("CompanyName", "*") %>
            </p>
            <p>
						 <label for="Company">Company:</label>
							<%=Html.ListBox("Company", new MultiSelectList(ViewData["Companies"] as IList<UserGroupCms.Models.Company>, "Id", "Name"))%>
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

