// Fleet Nation Camera "On-Select" Property/Patch

// Current code

Collect(
    colDriverData1,
    {Images: Camera.Photo}
)

// Test code

Set(
    varName,
    GUID()
);
Collect(
    colImages,
    {
        DisplayName: varName & ".jpg",
        Id: varName & ".jpg",
        Value: Camera.Photo}
)



Parent.Default