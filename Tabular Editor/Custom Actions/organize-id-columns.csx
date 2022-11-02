//Name: Organize ID Columns
//Tooltip: Places ID columns in an ID folder and hides them
//Enable: Model
//Created by Jacqueline Kaltenborn
//Tabular Editor version 2.16.6

foreach(var c in Model.AllColumns)
{
    if(c.Name.ToLower().Contains("id"))
    {
        c.DisplayFolder = "_IDs";
        c.IsHidden = true;
    }
   
}
