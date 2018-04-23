<script type="text/javascript">
    function OnValueChanged(s, e) {
        $.ajax({
            url: '@Url.Action("GridViewPartial", "Home")',
            type: "GET",
            data: { gridType: RadioButtonList.GetSelectedItem().text },
            success: function (data) {
                $('#dvContainer').html(data);
            },
            error: function (xhr, textStatus, errorThrown) {
                alert('Request Status: ' + xhr.status + '; Status Text: ' + textStatus + '; Error: ' + errorThrown);
            }
        });
    }

    function OnBeginCallback(s, e) {
        e.customArgs["gridType"] = RadioButtonList.GetSelectedItem().text;
    }
</script>

@Html.DevExpress().RadioButtonList( _
    Sub(settings)
            settings.Name = "RadioButtonList"
            settings.SelectedIndex = 0
            settings.Properties.ClientSideEvents.ValueChanged = "OnValueChanged"
    End Sub).BindList(System.Enum.GetNames(GetType(GridType))).GetHtml()

<div id="dvContainer">
    @Html.Action("GridViewPartial")
</div>