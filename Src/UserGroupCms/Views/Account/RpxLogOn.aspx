<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Login
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>OpenID Login</h2>
    <p>
        Please enter your OpenID.
    </p>
    <%= Html.ValidationSummary("Login was unsuccessful. Please correct the errors and try again.") %>


    <% using (Html.BeginForm("Authenticate", "Account")) { %>
        <div>
<%--            <fieldset>
                <p>
									<label for="openid">OpenID:</label>
									<input type="text" name="openid" id="openid" class="openidinput" />
									<input type="submit" value="Login" class="loginbutton" />
									<%= Html.ValidationMessage("openid") %>
                </p>
            </fieldset>--%>
            
            <iframe src="<%= ViewData["RpxLoginUrl"] %>"
						  scrolling="no" frameBorder="no" style="width:400px;height:240px;">
						</iframe>

        </div>
    <% } %>

</asp:Content>
