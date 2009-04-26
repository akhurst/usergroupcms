<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<UserGroupCms.Models.Contexts.HomeContext>" %>
<%@ Import Namespace="UserGroupCms.Models"%>

<asp:Content ID="indexTitle" ContentPlaceHolderID="TitleContent" runat="server">
    Welcome to the Aggieland .NET User's Group
</asp:Content>

<asp:Content ID="indexContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <div class="rightside">
			<div class="contactinformation">
				<h3>Stay in touch with the DNUG</h3>
				<ul>
					<li>Join the <a href="">mailing list</a></li>
					<li>Follow us on <a href="http://twitter.com/aggielanddnug">twitter</a></li>
					<li>Join the <a href="">facebook group</a></li>
					<li></li>
				</ul>
			</div>
			
			<div class="specialcontent">
						
			</div>
			
		</div>
		
		<div class="leftside">
		
			<div class="welcomemessage">
				<h2><%= Html.Encode(Model.Group.WelcomeMessage) %></h2>
			</div>
	    
			<div class="eventlist">
			
				<h3>Upcoming Events</h3>
			
				<%foreach (Event futureEvent in Model.FutureEvents){%>
				
				<div class="event-description">
					<h4><%= Html.Encode(futureEvent.Title) %></h4>
					<h5>Presenter: <%= futureEvent.SpeakersString %></h5>
					<p><%= Html.Encode(futureEvent.Summary) %></p>
				</div>
				
				<%}%>
			</div>  
	        
			<div class="sponsorslist">
				<h3>Sponsors</h3>
				
				<% foreach(Company company in Model.Sponsors) { %>
					
					<a href="<%= company.Url %>"
				
				<% } %>
				
			</div>
			
		</div>

    
    <p>
        To learn more about ASP.NET MVC visit <a href="http://asp.net/mvc" title="ASP.NET MVC Website">http://asp.net/mvc</a>.
    </p>
</asp:Content>
