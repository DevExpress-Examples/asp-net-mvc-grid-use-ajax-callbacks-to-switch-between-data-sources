@ModelType System.Collections.IEnumerable

@Html.DevExpress().GridView( _
    Sub(settings)
            settings.Name = "GridView"
            settings.KeyFieldName = CStr(ViewData("KeyFieldName"))
            settings.CallbackRouteValues = New With {.Controller = "Home", .Action = "GridViewPartial"}
            settings.ClientSideEvents.BeginCallback = "OnBeginCallback"
    End Sub).Bind(Model).GetHtml()