<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<UserGroupCms.Models.UserGroup>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	List
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>List</h2>

    <table>
        <tr>
            <th></th>
            <th>
                LogoUrl
            </th>
            <th>
                Name
            </th>
            <th>
                ShortName
            </th>
            <th>
                WelcomeMessage
            </th>
            <th>
                Inactive
            </th>
            <th>
                ContactInfoHtml
            </th>
            <th>
                Id
            </th>
            <th>
                UserGroupId
            </th>
            <th>
                IsNew
            </th>
        </tr>

    <% foreach (var item in Model) { %>
    
        <tr>
            <td>
                <%= Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }) %> |
                <%= Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ })%>
            </td>
            <td>
                <%= Html.Encode(item.LogoUrl) %>
            </td>
            <td>
                <%= Html.Encode(item.Name) %>
            </td>
            <td>
                <%= Html.Encode(item.ShortName) %>
            </td>
            <td>
                <%= Html.Encode(item.WelcomeMessage) %>
            </td>
            <td>
                <%= Html.Encode(item.Inactive) %>
            </td>
            <td>
                <%= Html.Encode(item.ContactInfoHtml) %>
            </td>
            <td>
                <%= Html.Encode(item.Id) %>
            </td>
            <td>
                <%= Html.Encode(item.UserGroupId) %>
            </td>
            <td>
                <%= Html.Encode(item.IsNew) %>
            </td>
        </tr>
    
    <% } %>

    </table>

    <p>
        <%= Html.ActionLink("Create New", "Create") %>
    </p>

</asp:Content>

