<%@ Control Language="vb" AutoEventWireup="true" CodeBehind="ViewSwitcher.ascx.vb" Inherits="ScatterRadarLine.ViewSwitcher" %>
<div id="viewSwitcher">
    <%:CurrentView%> view | <a href="<%:SwitchUrl%>">Switch to <%:AlternateView%></a>
</div>