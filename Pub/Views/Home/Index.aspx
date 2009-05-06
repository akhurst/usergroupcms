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
						<h1><%=Model.Group.WelcomeMessage%></h1>
					</div>
			    
					<div class="eventlist">
					
						<h3>Upcoming Events</h3>
					
						<%foreach (Event futureEvent in Model.FutureEvents)
								Html.RenderPartial("EventDetails", futureEvent); %>
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
					<div class="contactinformation"><%= Model.Group.ContactInfo %></div>
					
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
