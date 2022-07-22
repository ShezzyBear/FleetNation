//Fleet Nation Missing Tools Collection

//Below is current code for collection created when checkbox is clicked

ClearCollect(
    colMissingTools,
    {
        Tool: MTMissingToolGallery.Selected.Title,
        Image: MTMissingToolGallery.Selected.ToolPic,
        Vendor: MTMissingToolGallery.Selected.Vendor,
        Quantity: MTMissingToolGallery.Selected.Quantity_x0020_Needed,
        Selected: MTMissingToolGallery.Selected.Checkbox3,
        Status: MTMissingToolGallery.Selected
    }
);

//Final code to have correct entries in collection

ClearCollect(colMissingTools,ThisItem);