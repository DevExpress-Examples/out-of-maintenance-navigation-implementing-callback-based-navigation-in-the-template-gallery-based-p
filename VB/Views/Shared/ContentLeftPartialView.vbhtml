<div class="leftPanel">
    @* DXCOMMENT: Configure the left panel's menu *@
    @Html.DevExpress().NavBar( _
        Sub(settings)
                settings.Name = "LeftNavBar"
                settings.EnableAnimation = True
                settings.Width = System.Web.UI.WebControls.Unit.Percentage(100)
                settings.ControlStyle.Border.BorderWidth = System.Web.UI.WebControls.Unit.Pixel(0)
                settings.ControlStyle.Paddings.Padding = System.Web.UI.WebControls.Unit.Pixel(0)
                settings.ClientSideEvents.ItemClick = "OnItemClick"
                settings.Groups.Add(Sub(grp)
                                            grp.Name = "gAjax"
                                            grp.Text = "Load via ajax callback"
                                            grp.Items.Add("View 1", "View1Partial")
                                            grp.Items.Add("View 2", "View2Partial")
                                    End Sub)
                settings.Groups.Add(Sub(grp)
                                            grp.Name = "gCallbackPanel"
                                            grp.Text = "Load via CallbackPanel"
                                            grp.Items.Add("View 3", "View3Partial")
                                            grp.Items.Add("View 4", "View4Partial")
                                    End Sub)
        End Sub).GetHtml()
</div>