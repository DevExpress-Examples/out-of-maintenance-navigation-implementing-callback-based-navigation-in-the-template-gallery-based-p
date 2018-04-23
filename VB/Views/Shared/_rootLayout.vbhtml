<!DOCTYPE html>

<html>
<head>
    <meta charset="UTF-8" />
    <title>@ViewBag.Title</title>

    @Html.DevExpress().GetStyleSheets(
        New StyleSheet With {.ExtensionSuite = ExtensionSuite.NavigationAndLayout},
        New StyleSheet With {.ExtensionSuite = ExtensionSuite.Editors}
    )
    @Html.DevExpress().GetScripts(
        New Script With {.ExtensionSuite = ExtensionSuite.NavigationAndLayout},
        New Script With {.ExtensionSuite = ExtensionSuite.Editors}
    )

    <script type="text/javascript">
        function OnItemClick(s, e) {
            var name = e.item.name;

            if (e.item.group.name == 'gAjax') {
                $.ajax({
                    url: '@Url.Action("GetPartialView", "Home")',
                    type: "GET",
                    traditional: true,
                    data: { itemName: name },
                    success: function (data) {
                        $('#dvContainer').html(data);
                    },
                    error: function (xhr, textStatus, errorThrown) {
                        alert('Request Status: ' + xhr.status + '; Status Text: ' + textStatus + '; Error: ' + errorThrown);
                    }
                });
            }
            else if (e.item.group.name == 'gCallbackPanel') {
                CallbackPanel.PerformCallback({ itemName: name });
            }
        }
    </script>

</head>
<body>
    @Html.DevExpress().Splitter( _
    Sub(settings)
            settings.Name = "MainSplitter"
            settings.AllowResize = False
            settings.Orientation = System.Web.UI.WebControls.Orientation.Vertical
            settings.FullscreenMode = True
            settings.SeparatorVisible = False
            settings.Styles.Pane.Border.BorderWidth = System.Web.UI.WebControls.Unit.Pixel(0)
            settings.Styles.Pane.Paddings.Padding = System.Web.UI.WebControls.Unit.Pixel(0)
            settings.Panes.Add(Sub(pane)
                                       pane.Name = "Content"
                                       pane.PaneStyle.CssClass = "mainContentPane"
                                       pane.MinSize = System.Web.UI.WebControls.Unit.Pixel(375)
                                       pane.PaneStyle.BackColor = System.Drawing.Color.White
                                       pane.PaneStyle.BorderBottom.BorderWidth = System.Web.UI.WebControls.Unit.Pixel(1)
                                       pane.SetContent(RenderBody().ToHtmlString())
                               End Sub)
    End Sub).GetHtml()
</body>
</html>