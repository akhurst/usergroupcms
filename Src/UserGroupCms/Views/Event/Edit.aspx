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
                <div class="editor-label">
                    <%: Html.LabelFor(m=>m.Date) %>
                </div>
                <div class="editor-field">
                    <%: Html.EditorFor(m=> m.Date) %>
                    <%: Html.ValidationMessageFor(m=>m.Date) %>
                </div>

                <div class="editor-label">
                    <%: Html.LabelFor(m=>m.Title) %>
                </div>
                <div class="editor-field">
                    <%: Html.TextBoxFor(m=> m.Title) %>
                    <%: Html.ValidationMessageFor(m=>m.Title) %>
                </div>

                <div class="editor-label">
                    <%: Html.LabelFor(m=>m.Summary) %>
                </div>
                <div class="editor-field">
                    <%: Html.EditorFor(m=> m.Summary) %>
                    <%: Html.ValidationMessageFor(m=>m.Summary) %>
                </div>

                <div class="editor-label">
                    <%: Html.LabelFor(m=>m.EventLink1Text) %>
                </div>
                <div class="editor-field">
                    <%: Html.EditorFor(m=> m.EventLink1Text) %>
                    <%: Html.ValidationMessageFor(m=>m.EventLink1Text) %>
                </div>

                <div class="editor-label">
                    <%: Html.LabelFor(m=>m.EventLink1Url) %>
                </div>
                <div class="editor-field">
                    <%: Html.EditorFor(m=> m.EventLink1Url) %>
                    <%: Html.ValidationMessageFor(m=>m.EventLink1Url) %>
                </div>

                <div class="editor-label">
                    <%: Html.LabelFor(m=>m.EventLink2Text) %>
                </div>
                <div class="editor-field">
                    <%: Html.EditorFor(m=> m.EventLink2Text) %>
                    <%: Html.ValidationMessageFor(m=>m.EventLink2Text) %>
                </div>

                <div class="editor-label">
                    <%: Html.LabelFor(m=>m.EventLink2Url) %>
                </div>
                <div class="editor-field">
                    <%: Html.EditorFor(m=> m.EventLink2Url) %>
                    <%: Html.ValidationMessageFor(m=>m.EventLink2Url) %>
                </div>

                <div class="editor-label">
                    <%: Html.LabelFor(m=>m.ArtifactsUrl) %>
                </div>
                <div class="editor-field">
                    <%: Html.EditorFor(m=> m.ArtifactsUrl) %>
                    <%: Html.ValidationMessageFor(m=>m.ArtifactsUrl) %>
                </div>

                <div class="editor-label">
                    <%: Html.LabelFor(m=>m.Sponsors) %>
                </div>
                <div class="editor-field">
                    <%: Html.ListBoxFor(m=>m.Sponsors, (MultiSelectList)ViewData["Companies"]) %>
                    <%: Html.ValidationMessageFor(m=>m.Sponsors) %>
                </div>

                <div class="editor-label">
                    <%: Html.LabelFor(m=>m.Speakers) %>
                </div>
                <div class="editor-field">
                    <%: Html.ListBoxFor(m=>m.Speakers,(MultiSelectList)ViewData["Speakers"]) %>
                    <%: Html.ValidationMessageFor(m=>m.Speakers) %>
                </div>

                <div class="editor-label">
                    <%: Html.LabelFor(m=>m.Venue) %>
                </div>
                <div class="editor-field">
                    <%: Html.DropDownListFor(m=>m.Venue,(SelectList)ViewData["Venues"]) %>
                    <%: Html.ValidationMessageFor(m=>m.Venue) %>
                </div>

                <input type="submit" value="Save" />
        </fieldset>

    <% } %>

    <div>
        <%=Html.ActionLink("Back to List", "Index") %>
    </div>

</asp:Content>

