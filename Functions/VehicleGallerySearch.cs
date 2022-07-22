//Fleet Nation Unassigned Vehicle Gallary Display

//Below is current code for back button on Driver_Identity screen

VehicleReference
  //Filter(VehiclesDemo,(Status.Value = "Unassigned") && StartsWith(Last_x0020_4_x0020_VIN,VehicleSearchInput.Text))
  //Filter(VehiclesDemo,Garaged="Fulton, MD" && Status.Value="Unassigned")    

//Current test code to narrow down search field by VIN 

Search(VehicleReference,VehicleSearchInput.Text,"Year",)
  //Filter(VehiclesDemo,(Status.Value = "Unassigned") && StartsWith(Last_x0020_4_x0020_VIN,VehicleSearchInput.Text))
  //Filter(VehiclesDemo,Garaged="Fulton, MD" && Status.Value="Unassigned")    