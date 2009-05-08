<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<UserGroupCms.Models.Person>" %>

    <fieldset>
        <legend>Fields</legend>
        <p>
            Name:
            <%= Html.Encode(Model.Name) %>
        </p>
        <p>
            BlogUrl:
            <%= Html.Encode(Model.BlogUrl) %>
        </p>
        <p>
            Url2:
            <%= Html.Encode(Model.Url2) %>
        </p>
        <p>
            Bio:
            <%= Html.Encode(Model.Bio) %>
        </p>
        <p>
            ImagePath:
            <%= Html.Encode(Model.ImagePath) %>
        </p>
        <p>
            CompanyName:
            <%= Html.Encode(Model.CompanyName) %>
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


