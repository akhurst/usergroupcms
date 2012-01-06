<%@ Import Namespace="UserGroupCms.Models"%>
<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<UserGroupCms.Models.Event>" %>

		<div class="event-description">
	    <fieldset>
        <legend class="event-description"><%= Html.Encode(Model.Name) %></legend>        
        <h5>&nbsp;&nbsp;Date: &nbsp;&nbsp;<%= Model.Date.ToString("f") %></h5>
				<h5>&nbsp;&nbsp;Presenter: &nbsp;&nbsp;<%= Model.SpeakersString %></h5>
				<% if(Model.Venue != null) { %>
					<h5>&nbsp;&nbsp;Venue: &nbsp;&nbsp;<a href="<%= Model.Venue.MapImageUrl %>" target="blank"><%= Model.Venue.Name %></a></h5>
				<% } %>
				<p><%= Model.Summary %></p>
				<% if (!string.IsNullOrEmpty(Model.ArtifactsUrl)) {%>
					<p>Presentation Materials: 
						<ul>
							<li><a href="<%= Model.ArtifactsUrl %>"><%= Model.ArtifactsUrl%></a></li>
						</ul>
					</p>
				<%} %>
	    </fieldset>
		</div>
		
		<% if(ViewData["UserAccount"] != null && ((Account)ViewData["UserAccount"]).Admin) {%>
    <p>
        <%=Html.ActionLink("Edit", "Edit", "Event", new { id = Model.Id }, null)%> |
        <%=Html.ActionLink("Back to List", "Index", "Event") %>
    </p>
    <%} %>
