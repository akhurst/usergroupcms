<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Login with your OpenID
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>OpenID Login</h2>
    <p>
        Please enter your OpenID.
    </p>
    <%= Html.ValidationSummary("Login was unsuccessful. Please correct the errors and try again.") %>


    <% using (Html.BeginForm("Authenticate", "Account")) { %>
        <div>
            <fieldset>
                <legend>OpenID</legend>
                <p>
									<label for="openid">OpenID:</label>
									<input type="text" name="openid" id="openid" size="53" class="openidinput" />
									<input type="submit" value="Login" class="loginbutton" />
									<%= Html.ValidationMessage("openid") %>
                </p>
            </fieldset>
        </div>
    <% } %>
</asp:Content>
