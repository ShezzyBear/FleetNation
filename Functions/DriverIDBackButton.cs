//Fleet Nation Driver_Identity Back Button

//Below is current code for back button on Driver_Identity screen

Navigate(Home_Screen, ScreenTransition.Fade)

//Current If statement iteration is to allow managers to click back button and navigate back to PrimaryUnAssignScreen 

If(
    DriverPositionInput.Text = "Branch Mgr - CT",
    Navigate(
        PrimaryUnAssignScreen,
        ScreenTransition.Fade
    ),
    Navigate(
        Home_Screen,
        ScreenTransition.Fade
    ), true
)

//Below is test code for IsBlank statement in back button on Driver_Identity screen

If(
    !IsBlank(
        Find ("Branch",DriverPositionInput.Text)
       );
    Navigate(
        PrimaryUnAssignScreen,
        ScreenTransition.Fade
    ), false,
    Navigate(
        Home_Screen,
        ScreenTransition.Fade
    )
)

// Test code for IsMatch statement in back button in Driver_Identity screen

If(
    (IsMatch(
        DriverPositionInput.Text,
        "Branch",
        BeginsWith
    )),
    Navigate(
        PrimaryUnAssignScreen,
        ScreenTransition.Fade
    ),
    Navigate(
        ManagersOptionScreen,
        ScreenTransition.Fade
    )
)

// NEW final code for IsMatch statement in back button in Driver_Identity screen with applicable conditions

If(
    (IsMatch(
        DriverPositionInput.Text,
        "Branch",
        BeginsWith
    ) || (IsMatch(
        DriverPositionInput.Text,
        "Install Mgr",
        BeginsWith
    ) || (IsMatch(
        DriverPositionInput.Text,
        "Sales - Manager",
        BeginsWith
    )))),
    Navigate(
        PrimaryUnAssignScreen,
        ScreenTransition.Fade
    ),
    Navigate(
        ManagersOptionScreen,
        ScreenTransition.Fade
    )
)

// Code to reference colDriverFrag.Position instead of IsMatch statement using DriverPositionInput.Text

If(
    "Measure Technician" in colDriverFrag.Position,
    Navigate(
        Home_Screen,
        ScreenTransition.Fade
    ),
    "Service Technician" in colDriverFrag.Position,
    Navigate(
        Home_Screen,
        ScreenTransition.Fade
    ),
    "EDC" in colDriverFrag.Position,
    Navigate(
        Home_Screen,
        ScreenTransition.Fade
    ),
    Navigate(PrimaryUnassignScreen)
)