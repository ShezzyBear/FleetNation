//Fleet Nation Confirm Screen Submit Button

//Below is current code for back button on Driver_Identity screen

Patch(
    FleetNow,
    Defaults(FleetNow),
    {
        Title: "frrr"
    }
);
ClearCollect(
    colDriverData1,
    {
        Title: DriverShortVINInput.Text - DriverShortVINInput.Text,
        Odometer: OdometerInput.Text,
        Noises: NoisesDropdown.SelectedText,
        DashboardLights: DashboardLightDropdown.SelectedText,
        Headlight: HeadlightsDropdown.SelectedText,
        BrakeLights: BrakeLightsDropDown.SelectedText,
        TurnSignals: TurnSignalDropDown.SelectedText,
        Inflation: ProperInflationDropdown.SelectedText,
        Tread: AdequateTreadDropDown.SelectedText,
        Oil: OilDropDown.SelectedText,
        Leaks: MirrorsDropdown.SelectedText,
        Brakes: BrakeLightsDropDown.SelectedText,
        Parking_Brakes: ParkingBrakesDropDown.SelectedText,
        Wipers: WindshieldWipersDropdown.SelectedText,
        Fans: FansDropDown.SelectedText,
        Defroster: DefrosterDropDown.SelectedText,
        Mirrors: MirrorsDropdown.SelectedText,
        Horn: HornDropDown.SelectedText,
        Condition: VehicleConditionDropDown.SelectedText,
        Comments: Comments_Input.Text,
        Date: InspectionDate.SelectedDate,
        Driver: DriverNameInput.Text,
        ShortVIN: DriverShortVINInput.Text,
        Position: DriverPositionInput.Text
    }
);
Patch(
    FleetNowDemo,
    ForAll(
        colDriverData1 As _item,
        {
            Title: _item.Title,
            Driver: _item.Driver,
            Odometer: _item.Odometer,
            Noises: _item.Noises.Value,
            DashboardLights: _item.DashboardLights.Value,
            Headlight: _item.Headlight.Value,
            BrakeLights: _item.BrakeLights.Value,
            TurnSignals: _item.TurnSignals.Value,
            Inflation: _item.Inflation.Value,
            Tread: _item.Tread.Value,
            Oil: _item.Oil.Value,
            Leaks: _item.Leaks.Value,
            Brakes: _item.Brakes.Value,
            Parking_Brakes: _item.Parking_Brakes.Value,
            Wipers: _item.Wipers.Value,
            Fans: _item.Fans.Value,
            Defroster: _item.Defroster.Value,
            Mirrors: _item.Mirrors.Value,
            Horn: _item.Horn.Value,
            Condition: _item.Condition.Value,
            Comments: _item.Comments,
            Date: _item.Date,
            ShortVIN: _item.ShortVIN,
            Position: _item.Position
        }
    )
);
If(
    NoisesDropdown.Selected.OptionID = 3 || DashboardLightDropdown.Selected.OptionID = 3 || HeadlightsDropdown.Selected.OptionID = 3 || BrakeLightsDropDown.Selected.OptionID = 3 || TurnSignalDropDown.Selected.OptionID = 3 || ProperInflationDropdown.Selected.OptionID = 3 || AdequateTreadDropDown.Selected.OptionID = 3 || OilDropDown.Selected.OptionID = 3 || MirrorsDropdown.Selected.OptionID = 3 || BrakeLightsDropDown.Selected.OptionID = 3 || ParkingBrakesDropDown.Selected.OptionID = 3 || WindshieldWipersDropdown.Selected.OptionID = 3 || FansDropDown.Selected.OptionID = 3 || DefrosterDropDown.Selected.OptionID = 3 || MirrorsDropdown.Selected.OptionID = 3 || HornDropDown.Selected.OptionID = 3 || VehicleConditionDropDown.Selected.OptionID = 3 || VehicleConditionDropDown.Selected.OptionID = 4 || false,
    Navigate(
        EnterpriseContactScreen,
        ScreenTransition.CoverRight
    ),
    If(
        DriverPositionInput.Text = "Measure Technician" || DriverPositionInput.Text = "Service Technician",
        Navigate(
            TechnicianInspectionFinishScreen,
            ScreenTransition.CoverRight
        ),
        Navigate(InspectionFinishScreen),
        ScreenTransition.Fade
    )
)

// Below is test code for suggested change

ClearCollect(
    colDriverData1,
    {
        Title: DriverShortVINInput.Text - DriverShortVINInput.Text,
        Odometer: OdometerInput.Text,
        Noises: NoisesDropdown.SelectedText,
        DashboardLights: DashboardLightDropdown.SelectedText,
        Headlight: HeadlightsDropdown.SelectedText,
        BrakeLights: BrakeLightsDropDown.SelectedText,
        TurnSignals: TurnSignalDropDown.SelectedText,
        Inflation: ProperInflationDropdown.SelectedText,
        Tread: AdequateTreadDropDown.SelectedText,
        Oil: OilDropDown.SelectedText,
        Leaks: MirrorsDropdown.SelectedText,
        Brakes: BrakeLightsDropDown.SelectedText,
        Parking_Brakes: ParkingBrakesDropDown.SelectedText,
        Wipers: WindshieldWipersDropdown.SelectedText,
        Fans: FansDropDown.SelectedText,
        Defroster: DefrosterDropDown.SelectedText,
        Mirrors: MirrorsDropdown.SelectedText,
        Horn: HornDropDown.SelectedText,
        Condition: VehicleConditionDropDown.SelectedText,
        Comments: Comments_Input.Text,
        Date: InspectionDate.SelectedDate,
        Driver: DriverNameInput.Text,
        ShortVIN: DriverShortVINInput.Text,
        Position: DriverPositionInput.Text
    }
);
If(
    NoisesDropdown.Selected.OptionID = 3 || DashboardLightDropdown.Selected.OptionID = 3 || HeadlightsDropdown.Selected.OptionID = 3 || BrakeLightsDropDown.Selected.OptionID = 3 || TurnSignalDropDown.Selected.OptionID = 3 || ProperInflationDropdown.Selected.OptionID = 3 || AdequateTreadDropDown.Selected.OptionID = 3 || OilDropDown.Selected.OptionID = 3 || MirrorsDropdown.Selected.OptionID = 3 || BrakeLightsDropDown.Selected.OptionID = 3 || ParkingBrakesDropDown.Selected.OptionID = 3 || WindshieldWipersDropdown.Selected.OptionID = 3 || FansDropDown.Selected.OptionID = 3 || DefrosterDropDown.Selected.OptionID = 3 || MirrorsDropdown.Selected.OptionID = 3 || HornDropDown.Selected.OptionID = 3 || VehicleConditionDropDown.Selected.OptionID = 3 || VehicleConditionDropDown.Selected.OptionID = 4 || false,
    Navigate(
        EnterpriseContactScreen,
        ScreenTransition.CoverRight
    ),
    Navigate(InspectionVerificationScreen),
    ScreenTransition.Fade
)

// To be used on ConfirmScreen

If(
    NoisesDropdown.Selected.OptionID = 3 || DashboardLightDropdown.Selected.OptionID = 3 || HeadlightsDropdown.Selected.OptionID = 3 || BrakeLightsDropDown.Selected.OptionID = 3 || TurnSignalDropDown.Selected.OptionID = 3 || ProperInflationDropdown.Selected.OptionID = 3 || AdequateTreadDropDown.Selected.OptionID = 3 || OilDropDown.Selected.OptionID = 3 || MirrorsDropdown.Selected.OptionID = 3 || BrakeLightsDropDown.Selected.OptionID = 3 || ParkingBrakesDropDown.Selected.OptionID = 3 || WindshieldWipersDropdown.Selected.OptionID = 3 || FansDropDown.Selected.OptionID = 3 || DefrosterDropDown.Selected.OptionID = 3 || MirrorsDropdown.Selected.OptionID = 3 || HornDropDown.Selected.OptionID = 3 || VehicleConditionDropDown.Selected.OptionID = 3 || VehicleConditionDropDown.Selected.OptionID = 4 || false,
    Navigate(
        EnterpriseContactScreen,
        ScreenTransition.CoverRight
    ),
    Navigate(InspectionVerificationScreen),
    ScreenTransition.Fade
)
// To be used on Initials page

ClearCollect(
    colDriverData1,
    {
        Title: DriverShortVINInput.Text - DriverShortVINInput.Text,
        Odometer: OdometerInput.Text,
        Noises: NoisesDropdown.SelectedText,
        DashboardLights: DashboardLightDropdown.SelectedText,
        Headlight: HeadlightsDropdown.SelectedText,
        BrakeLights: BrakeLightsDropDown.SelectedText,
        TurnSignals: TurnSignalDropDown.SelectedText,
        Inflation: ProperInflationDropdown.SelectedText,
        Tread: AdequateTreadDropDown.SelectedText,
        Oil: OilDropDown.SelectedText,
        Leaks: OtherDropDown.SelectedText,
        Brakes: BrakesDropDown.SelectedText,
        Parking_Brakes: ParkingBrakesDropDown.SelectedText,
        Wipers: WindshieldWipersDropdown.SelectedText,
        Fans: FansDropDown.SelectedText,
        Defroster: DefrosterDropDown.SelectedText,
        Mirrors: MirrorsDropdown.SelectedText,
        Horn: HornDropDown.SelectedText,
        Condition: VehicleConditionDropDown.SelectedText,
        Comments: Comments_Input.Text,
        Date: InspectionDate.SelectedDate,
        Driver: DriverNameInput.Text,
        ShortVIN: DriverShortVINInput.Text,
        Position: DriverPositionInput.Text,
        Initials: Initials.Text
    }
);
Patch(
    FleetNowDemo,
    ForAll(
        colDriverData1 As _item,
        {
            Title: _item.Title,
            Driver: _item.Driver,
            Odometer: _item.Odometer,
            Noises: _item.Noises.Value,
            DashboardLights: _item.DashboardLights.Value,
            Headlight: _item.Headlight.Value,
            BrakeLights: _item.BrakeLights.Value,
            TurnSignals: _item.TurnSignals.Value,
            Inflation: _item.Inflation.Value,
            Tread: _item.Tread.Value,
            Oil: _item.Oil.Value,
            Leaks: _item.Leaks.Value,
            Brakes: _item.Brakes.Value,
            Parking_Brakes: _item.Parking_Brakes.Value,
            Wipers: _item.Wipers.Value,
            Fans: _item.Fans.Value,
            Defroster: _item.Defroster.Value,
            Mirrors: _item.Mirrors.Value,
            Horn: _item.Horn.Value,
            Condition: _item.Condition.Value,
            Comments: _item.Comments,
            Date: _item.Date,
            ShortVIN: _item.ShortVIN,
            Position: _item.Position,
            Initials: _item.Initials
        }
    )
);