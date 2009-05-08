<%@ Import Namespace="UserGroupCms.Models"%>
<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<UserGroupCms.Models.Event>" %>

		<div class="event-description">
	    <fieldset>
        <legend class="event-description"><%= Html.Encode(Model.Title) %></legend>        
        <h5>&nbsp;&nbsp;Date: &nbsp;&nbsp;<%= Model.Date.ToString("f") %></h5>
				<h5>&nbsp;&nbsp;Presenter: &nbsp;&nbsp;<%= Model.SpeakersString %></h5>
				<h5>&nbsp;&nbsp;Venue: &nbsp;&nbsp;<%= Model.Venue.Name %></h5>
				<p><%= Model.Summary %></p>
				<p>RSVP: 
				<ul>
					<li><a href="<%= Model.EventLink1Url %>"><%= Model.EventLink1Text %></a></li>
					<li><a href="<%= Model.EventLink2Url %>"><%= Model.EventLink2Text %></a></li>
				</ul>
	    </fieldset>
		</div>
		
		<% if(ViewData["UserAccount"] != null && ((Account)ViewData["UserAccount"]).Admin) {%>
    <p>
        <%=Html.ActionLink("Edit", "Edit", new { ID = Model.Id })%> |
        <%=Html.ActionLink("Back to List", "Index") %>
    </p>
    <%} %>
