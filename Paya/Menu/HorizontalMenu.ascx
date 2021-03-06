﻿<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="HorizontalMenu.ascx.cs" Inherits="Paya.Menu.HorizontalMenu" %>
<asp:Repeater ID="_rpFooterMenu" runat="server">
    <HeaderTemplate>
         <ul id="HeaderMenu" class="HorzMenuUL">
    </HeaderTemplate>
    <ItemTemplate>
        <li>
            <asp:HyperLink runat="server" ID="_hyplnkTab" Target='<%# DataBinder.Eval(Container.DataItem, "Target") %>'
                NavigateUrl='<%# DataBinder.Eval(Container.DataItem, "Url") %>'>
<span ><%# DataBinder.Eval(Container.DataItem, "Name") %></span>
            </asp:HyperLink>
        </li>
    </ItemTemplate>
    <FooterTemplate>
       </ul>
    </FooterTemplate>
</asp:Repeater>