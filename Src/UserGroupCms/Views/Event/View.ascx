<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<UserGroupCms.Models.Event>" %>

    <fieldset>
        <legend>Fields</legend>
        <p>
            Date:
            <%= Html.Encode(String.Format("{0:g}", Model.Date)) %>
        </p>
        <p>
            Title:
            <%= Html.Encode(Model.Name) %>
        </p>
        <p>
            Location:
            <%= Html.Encode(Model.Location) %>
        </p>
        <p>
            MapImageUrl:
            <%= Html.Encode(Model.MapImageUrl) %>
        </p>
        <p>
            Summary:
            <%= Html.Encode(Model.Summary) %>
        </p>
        <p>
            EventLink1:
            <%= Html.Encode(Model.EventLink1) %>
        </p>
        <p>
            EventLink2:
            <%= Html.Encode(Model.EventLink2) %>
        </p>
        <p>
            ArtifactsUrl:
            <%= Html.Encode(Model.ArtifactsUrl) %>
        </p>
        <p>
            SummaryHtml:
            <%= Html.Encode(Model.SummaryHtml) %>
        </p>
        <p>
            SpeakersString:
            <%= Html.Encode(Model.SpeakersString) %>
        </p>
        <p>
            Id:
            <%= Html.Encode(Model.Id) %>
        </p>
        <p>
            UserGroupId:
            <%= Html.Encode(Model.UserGroupId) %>
        </p>
        <p>
            IsNew:
            <%= Html.Encode(Model.IsNew) %>
        </p>
    </fieldset>
    <p>
        <%=Html.ActionLink("Edit", "Edit", new { /* id=Model.PrimaryKey */ }) %> |
        <%=Html.ActionLink("Back to List", "Index") %>
    </p>


