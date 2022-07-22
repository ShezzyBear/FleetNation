// Driver Data Collection

// Driver data collection occurs on Next button of Additional Comments screen

// Current code

ClearCollect(
    colDriverData1,
    {
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
NewForm(InspectionForm);
Clear(colImages);
Navigate(
    PhotoScreen,
    ScreenTransition.Cover
)

// Revised code to account for two additional forms (one for Incident Reports and another for Exit Surveys)

ClearCollect(
    colDriverData1,
    {
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
NewForm(InspectionForm);
NewForm(IncidentForm);
NewForm(ExitSurveyForm);
Clear(colImages);
Navigate(
    PhotoScreen,
    ScreenTransition.Cover
)
