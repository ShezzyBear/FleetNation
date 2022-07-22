//Fleet Nation Home_Screen Get Started Button

//Below is current code for Get Started button on Home_Screen

If(
    !"Measure Technician" || "Service Technician" in colDriverFrag.Position,
    Navigate(
        Driver_Identity,
        ScreenTransition.Fade
    ),
    Navigate(PrimaryUnassignScreen)
)

//Below is final code for different if statement to navigate to correct page

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
    "EDC" in colDriverFrag.Position,
    Navigate(
        Driver_Identity,
        ScreenTransition.Fade
    ),
    Navigate(PrimaryUnassignScreen)
)