<%@ Import Namespace="UserGroupCms.Models"%>
<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<UserGroupCms.Models.Event>" %>

    <fieldset>
			<div class="event-description">
        <legend class="event-description"><%= Html.Encode(Model.Title) %></legend>        
        <h5>&nbsp;&nbsp;Date: &nbsp;&nbsp;<%= Model.Date.ToString("f") %></h5>
				<h5>&nbsp;&nbsp;Presenter: &nbsp;&nbsp;<%= Model.SpeakersString %></h5>
				<p><%= Html.Encode(Model.Summary) %></p>
				<p>RSVP: 
				<ul>
					<li><a href="<%= Model.EventLink1Url %>"><%= Model.EventLink1Text %></a></li>
					<li><a href="<%= Model.EventLink1Url %>"></a><%= Model.EventLink2Text %></li>
				</ul>
	    </fieldset>
		</div>
		
		<% if(ViewData["UserAccount"] != null && ((Account)ViewData["UserAccount"]).Admin) {%>
    <p>
        <%=Html.ActionLink("Edit", "Edit", new { /* id=Model.PrimaryKey */ }) %> |
        <%=Html.ActionLink("Back to List", "Index") %>
    </p>
    <%} %>
