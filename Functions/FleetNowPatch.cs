// Driver Patch on Fleet Nation Beta

// Current code which is non-functional for patching to FleetNow(AutoRepo)
ClearCollect(
    colDriverData1,
    {
        Title: DriverShortVINInput.Text,
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
        Comments: CommentsDisplay.Text,
        Date: InspectionDate.SelectedDate,
        Driver: DriverNameInput.Text,
        ShortVIN: DriverShortVINInput.Text,
        Position: DriverPositionInput.Text,
        Initials: Initials.Text
    }
);
Patch(
    FleetNow,
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

// Revices working patch

Patch(
    FleetNow,
    ForAll(
        colDriverData1 As _item,
        {
            Title: _item.Driver,
            Title0: _item.Title,
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

// From Iota App

Collect(
    colDriverData1,
    {
        Title: DriverShortVINInput.Text,
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
        Comments: CommentsDisplay.Text,
        Date: InspectionDate.SelectedDate,
        Driver: DriverNameInput.Text,
        ShortVIN: DriverShortVINInput.Text,
        Position: DriverPositionInput.Text,
        Initials: Initials.Text
    }
);
Patch(
    Inspection,
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
