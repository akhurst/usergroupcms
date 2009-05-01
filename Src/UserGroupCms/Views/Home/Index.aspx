<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<UserGroupCms.Models.Contexts.HomeContext>" %>
<%@ Import Namespace="UserGroupCms.Models"%>

<asp:Content ID="indexTitle" ContentPlaceHolderID="TitleContent" runat="server">
    Welcome to the Aggieland .NET User's Group
</asp:Content>

<asp:Content ID="indexContent" ContentPlaceHolderID="MainContent" runat="server">

	<table class="indexcontent">
		<tr>
			<td class="leftside">				
					<div class="welcomemessage">
						<h2><%=Model.Group.WelcomeMessage%></h2>
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
							
							<a href="<%= company.Url %>"><img src="<%= company.LogoUrl %>" alt="<%=company.Name %>" /></a>
							&nbsp;&nbsp;&nbsp;
						
						<% } %>
						
					</div>
			</td>

			<td class="rightside">
					<div class="contactinformation">
						<h3>Stay in touch with the DNUG</h3>
						<ul>
							<li>Join the mailing list <a href="mailto://listserv@listserv.tamu.edu?body=subscribe%20dotnet">by email</a> or <a href="https://listserv.tamu.edu/cgi-bin/wa?SUBED1=dotnet&A=1">by web</a></li>
							<li>Follow us on <a href="http://twitter.com/aggielanddnug">twitter</a></li>
							<li>Join the <a href="">facebook group</a></li>
							<li></li>
						</ul>
					</div>
					
					<div class="specialcontent">
						<% foreach(SpecialContent content in Model.SpecialContent) { %>
							
							<div class="rightside-specialcontent">
								<%= content.Content %>
							</div>
						
						<% } %>
					</div>
					
			</td>
		</tr>
	</table>
</asp:Content>
