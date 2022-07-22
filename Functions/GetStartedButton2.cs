//Fleet Nation Get Started Button

//Below is current code for Get Started on Home_Screen

If(
    DriverPositionInput.Text = "Measure Technician" || "Service Technician",
    Navigate(
        Driver_Identity,
        ScreenTransition.Fade
    ),
    Navigate(PrimaryUnassignScreen)
)

// Below is test code to reference driver position from collection earlier in app

If(
    "Measure Technician" in colBuild.Position,
        Navigate(
        Driver_Identity,
        ScreenTransition.Fade
    ),
    Navigate(PrimaryUnassignScreen))

// Test code to add multiple positions

If(
    "Measure Technician" in colDriverFrag.Position,
    Navigate(
        Driver_Identity,
        ScreenTransition.Fade
    ),
    "Service Technician" in colDriverFrag.Position,
    Navigate(
        Driver_Identity,
        ScreenTransition.Fade
    ),
    Navigate(PrimaryUnassignScreen)
)