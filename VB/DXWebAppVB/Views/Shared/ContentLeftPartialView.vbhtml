﻿<div class="leftPanel">
    @Html.DevExpress().NavBar(Sub(settings)
    settings.Name = "LeftNavBar"
    settings.EnableAnimation = True
    settings.Width = System.Web.UI.WebControls.Unit.Percentage(100)
    settings.ControlStyle.Border.BorderWidth = System.Web.UI.WebControls.Unit.Pixel(0)
    settings.ControlStyle.Paddings.Padding = System.Web.UI.WebControls.Unit.Pixel(0)
    settings.ClientSideEvents.ItemClick = "OnItemClick"
    settings.Groups.Add(Sub(group)
    group.Name = "gAjax"
    group.Text = "Load via ajax callback"
    group.Items.Add("View 1", "View1Partial")
    group.Items.Add("View 2", "View2Partial")
    End Sub)
    settings.Groups.Add(Sub(group)
    group.Name = "gCallbackPanel"
    group.Text = "Load via CallbackPanel"
    group.Items.Add("View 3", "View3Partial")
    group.Items.Add("View 4", "View4Partial")
    End Sub)
    End Sub).GetHtml()
</div>
