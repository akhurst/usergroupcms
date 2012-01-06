<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>
<%@ Import Namespace="UserGroupCms.Models"%>
<%
    if (Request.IsAuthenticated) {
%>
        Welcome 
        <b>
					<%if (ViewData["UserAccount"] != null) {%>
					
		        <%= Html.Encode(((Account)ViewData["UserAccount"]).Name)%>

		      <%} else{%>

		        <%= Html.Encode(Page.User.Identity.Name)%>

		      <%} %>
	      </b>!
        [ <%= Html.ActionLink("Log Off", "LogOff", "Account") %> ]
<%
    }
    else {
%> 
        [ <%= Html.ActionLink("Log On", "LogOn", "Account") %> ]
<%
    }
%>
