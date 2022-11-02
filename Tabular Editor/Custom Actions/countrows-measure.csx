//Name: Countrows Measure
//Tooltip: Create countrows measure for selected tables
//Enable: Table
//Tabular Editor version 2.16.0

foreach(var table in Selected.Tables) {
    
    var newMeasure = table.AddMeasure(
    "# " + table.Name + " rows",                       // Name
    "Countrows(" + table.DaxObjectFullName + ")"       // DAX expression
    );
    
    // Set the format string on the new measure:
    newMeasure.FormatString = "#,0";
    newMeasure.Description = "Expression: Countrows(" + table.DaxObjectFullName + ")";
}
