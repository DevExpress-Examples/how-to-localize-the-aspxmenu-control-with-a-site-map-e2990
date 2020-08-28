<%@ Page Language="vb" AutoEventWireup="true" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<%@ Register Assembly="DevExpress.Web.v13.1, Version=13.1.14.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
	Namespace="DevExpress.Web.ASPxMenu" TagPrefix="dx" %>

<%@ Register assembly="DevExpress.Web.v13.1, Version=13.1.14.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxSiteMapControl" tagprefix="dx" %>

<%@ Register assembly="DevExpress.Web.v13.1, Version=13.1.14.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
	<title></title>
</head>
<body>
	<form id="form1" runat="server">
	<div>
		<br />
		<dx:ASPxMenu ID="menu" runat="server" DataSourceID="siteMapSource">
		</dx:ASPxMenu>
	</div>
	<dx:ASPxSiteMapDataSource ID="siteMapSource" runat="server" 
		SiteMapFileName="~/web.sitemap" />
	<dx:ASPxRadioButtonList ID="combo" runat="server" 
		SelectedIndex="0" oninit="combo_Init">
		<ClientSideEvents SelectedIndexChanged="function (s, e) { 
			ASPxClientUtils.SetCookie('Culture', s.GetValue());
			window.location = window.location;
		}" />
		<Items>
			<dx:ListEditItem Selected="True" Text="English" Value="en-US" />
			<dx:ListEditItem Text="Deutsch" Value="de-DE" />
		</Items>
	</dx:ASPxRadioButtonList>   
	</form>
</body>
</html>