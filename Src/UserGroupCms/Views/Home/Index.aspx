<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<UserGroupCms.Models.Contexts.HomeContext>" %>
<%@ Import Namespace="UserGroupCms.Models"%>

<asp:Content ID="indexTitle" ContentPlaceHolderID="TitleContent" runat="server">
    Welcome to the Aggieland .NET User's Group
</asp:Content>

<asp:Content ID="indexContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <div id="welcomemessage">
	    <h2><%= Html.Encode(Model.Group.WelcomeMessage) %></h2>
    </div>
    
		<div>
		
			<h3>Upcoming Events</h3>
		
			<%foreach (Event futureEvent in Model.FutureEvents){%>
			
			<div class="event-description">
				<h4><%= futureEvent.Title %></h4>
				<h5>Presenter: </h5>
			
			</div>
			
			<%}%>
		</div>  
    
    <p>
        To learn more about ASP.NET MVC visit <a href="http://asp.net/mvc" title="ASP.NET MVC Website">http://asp.net/mvc</a>.
    </p>
</asp:Content>
