// Code being pulled for reference to have certain positions not see the manager menu dropdown

If(
    "Measure Technician" in DriverPositionStart.Text,
    Navigate(
        Driver_Identity,
        ScreenTransition.Fade
    ),
    "Service Technician" in DriverPositionStart.Text,
    Navigate(
        Driver_Identity,
        ScreenTransition.Fade
    ),
    "EDC" in DriverPositionStart.Text,
    Navigate(
        Driver_Identity,
        ScreenTransition.Fade
    ),
    "Auditor" in DriverPositionStart.Text,
    Navigate(
        Driver_Identity,
        ScreenTransition.Fade
    ),
    Navigate(PrimaryUnassignScreen)
)

// Test Code

If(
    "Measure Technician" || "Service Technician" || "EDC" || "Auditor" in DriverPositionStart.Text,
    false
    ), true

// Final working code

If(
    "Measure Technician" || "Service Technician" || "EDC" || "Auditor" in DriverPositionStart.Text,
    false,
    true,
    If(
        varMenu,
        true
    )
)
