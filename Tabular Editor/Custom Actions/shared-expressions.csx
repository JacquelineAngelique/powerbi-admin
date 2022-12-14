//Name: Shared Expressions
//Tooltip: export share expressions information
//Enable: Model
//Created by Jacqueline Kaltenborn
//Tabular Editor version 2.16.6

// Collect share expressions information:
var objects = Model.Expressions;
 
// Get properties:
var tsv = ExportProperties(objects,"Name, Expression, Annotations");
 
// Output to screen (can then be copy-pasted into another application):
 tsv.Output();
