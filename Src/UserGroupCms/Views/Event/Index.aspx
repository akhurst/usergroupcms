<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<UserGroupCms.Models.Event>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Index</h2>

    <table>
        <tr>
            <th></th>
            <th>
                Date
            </th>
            <th>
                Title
            </th>
            <th>
                Location
            </th>
            <th>
                MapImageUrl
            </th>
            <th>
                Summary
            </th>
            <th>
                EventLink1
            </th>
            <th>
                EventLink2
            </th>
            <th>
                ArtifactsUrl
            </th>
            <th>
                SpeakersString
            </th>
        </tr>

    <% foreach (var item in Model) { %>
    
        <tr>
            <td>
                <%= Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }) %> |
                <%= Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ })%>
            </td>
            <td>
                <%= Html.Encode(String.Format("{0:g}", item.Date)) %>
            </td>
            <td>
                <%= Html.Encode(item.Name) %>
            </td>
            <td>
                <%= Html.Encode(item.Location) %>
            </td>
            <td>
                <%= Html.Encode(item.MapImageUrl) %>
            </td>
            <td>
                <%= Html.Encode(item.Summary) %>
            </td>
            <td>
                <%= Html.Encode(item.EventLink1) %>
            </td>
            <td>
                <%= Html.Encode(item.EventLink2) %>
            </td>
            <td>
                <%= Html.Encode(item.ArtifactsUrl) %>
            </td>
            <td>
                <%= Html.Encode(item.SpeakersString) %>
            </td>
        </tr>
    
    <% } %>

    </table>

    <p>
        <%= Html.ActionLink("Create New", "Create") %>
    </p>

</asp:Content>

