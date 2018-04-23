@Html.DevExpress().CallbackPanel( _
    Sub(settings)
            settings.Name = "CallbackPanel"
            settings.CallbackRouteValues = New With {.Controller = "Home", .Action = "CallbackPanelPartial"}
            
            If ViewData("ActionName") IsNot Nothing Then
                settings.SetContent(Sub()
                                            Html.RenderAction(ViewData("ActionName").ToString())
                                    End Sub)
            End If
    End Sub).GetHtml()