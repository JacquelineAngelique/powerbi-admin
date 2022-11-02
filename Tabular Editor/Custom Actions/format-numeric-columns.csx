//Name: Format Numeric Columns
//Tooltip: Format numberic columns that does not have a format already
//Enable: Model
//Created by Jacqueline Kaltenborn
//Tabular Editor version 2.16.6

foreach (var c in Model.AllColumns)
{
    if(c.DataType == DataType.Decimal  && c.FormatString == "" || c.DataType == DataType.Double && c.FormatString == "")
    {  
        c.FormatString = "#,0.00";
    }
    if(c.DataType == DataType.Int64 && c.FormatString == "")
    {
        c.FormatString = "#,0";
    }
}
