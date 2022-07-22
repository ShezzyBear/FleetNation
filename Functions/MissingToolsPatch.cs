// Current PA code to collect items and patch

ClearCollect(colSTMissingTools,
 {
     Title: MissingToolName_1.Text,
     Initials: Initials2.Text,
     Date: InspectionDate.SelectedDate
 }
);
ClearCollect(colMissingTools,
 {
     Title: MissingToolName.Text,
     Initials: Initials2.Text,
     Date: InspectionDate.SelectedDate
 }
);
Patch(
    ToolsNowDemo,
    ForAll(
        colSTMissingTools As _item,
        {
            Title: _item.Title,
            Initials: _item.Initials,
            Date: _item.Date
        }
    )
);
Patch(
    ToolsNowDemo,
    ForAll(
        colMissingTools As _item,
        {
            Title: _item.Title,
            Initials: _item.Initials,
            Date: _item.Date
        }
    )
);
Navigate(ToolsAuditFinishScreen, ScreenTransition.Fade)

// Test 1

Patch(
    ToolsNowDemo,
    ForAll(STConfirmGallery.AllItems,
        {
            Title: MissingToolName_1.Text,
            Initials: Initials2.Text,
            Date: InspectionDate.SelectedDate
        }
    )
);
Patch(
    ToolsNowDemo,
    ForAll(MTConfirmGallery.AllItems,
        {
            Title: MissingToolName_1.Text,
            Initials: Initials2.Text,
            Date: InspectionDate.SelectedDate
        }
    )
);
Navigate(ToolsAuditFinishScreen, ScreenTransition.Fade)

// Final code with conditional statement

If(
    DriverPositionInput.Text = "Service Technician",
    Patch(
        ToolsNowDemo,
        ForAll(
            STConfirmGallery.AllItems,
            {
                Title: MissingToolName_1.Text,
                Initials: Initials2.Text,
                Date: InspectionDate.SelectedDate,
                Position: DriverPositionInput
            }
        )
    ),
    Patch(
        ToolsNowDemo,
        ForAll(
            MTConfirmGallery.AllItems,
            {
                Title: MissingToolName.Text,
                Initials: Initials2.Text,
                Date: InspectionDate.SelectedDate,
                Position: DriverPositionInput.Text
            }
        )
    )
);
Navigate(
    ToolsAuditFinishScreen,
    ScreenTransition.Fade
)

// Test code for separate ATB page.

Patch(
    ToolsNowDemo,
    ForAll(
        colMissingTools,
        {
            Initials: Initials3.Text,
            Date: InspectionDate.SelectedDate,
            Position: DriverPositionInput.Text
        }
    )
);
Navigate(
    ToolsAuditFinishScreen,
    ScreenTransition.Fade
)

// Conditional statement for having all tools onboard.

If(isBlank(colMissingTools,colSTMissingTools),
Patch(
    ToolsNowDemo,
    Defaults(ToolsNowDemo),
        {
            Title: "N/A",
            Initials: Initials3.Text,
            Date: InspectionDate.SelectedDate,
            Position: DriverPositionInput.Text
        }
    )
);
Navigate(
    ToolsAuditFinishScreen,
    ScreenTransition.Fade
)

// Final code for submit button

If(
    DriverPositionInput.Text = "Service Technician",
    Patch(
        ToolsNowDemo,
        ForAll(
            STConfirmGallery.AllItems,
            {
                Title: MissingToolName_1.Text,
                Initials: Initials2.Text,
                Date: InspectionDate.SelectedDate,
                Position: DriverPositionInput
            }
        )
    ),
    Patch(
        ToolsNowDemo,
        ForAll(
            MTConfirmGallery.AllItems,
            {
                Title: MissingToolName.Text,
                Initials: Initials2.Text,
                Date: InspectionDate.SelectedDate,
                Position: DriverPositionInput.Text
            }
        )
    )
);
If(
    DriverPositionInput.Text = "Service Technician" && (IsEmpty(colSTMissingTools)),
Patch(
    ToolsNowDemo,
    Defaults(ToolsNowDemo),
        {
            Title: "All Tools Onboard",
            Initials: Initials2.Text,
            Date: InspectionDate.SelectedDate,
            Position: DriverPositionInput.Text
        }
    )
);
If(
    DriverPositionInput.Text = "Measure Technician" && (IsEmpty(colMissingTools)),
Patch(
    ToolsNowDemo,
    Defaults(ToolsNowDemo),
        {
            Title: "All Tools Onboard",
            Initials: Initials2.Text,
            Date: InspectionDate.SelectedDate,
            Position: DriverPositionInput.Text
        }
    )
);
Navigate(
    ToolsAuditFinishScreen,
    ScreenTransition.Fade
)