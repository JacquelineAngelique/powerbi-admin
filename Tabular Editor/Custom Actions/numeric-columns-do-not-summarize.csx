//Name: Numeric Column to Do Not Summarize
//Tooltip: Change all numeric columns to do not summarize
//Enable: Model
//Created by Jacqueline Kaltenborn
//Tabular Editor version 2.16.6

foreach (var c in Model.AllColumns)
{
    if(c.DataType == DataType.Decimal ||  c.DataType == DataType.Double || c.DataType == DataType.Int64)
    {  
    c.SummarizeBy = AggregateFunction.None;
    }
}
