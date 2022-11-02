//Name: Available in MDX (on/off)
//Tooltip: Turn on or off the Available in MDX feature
//Enable: Column,Table
//Created by Jacqueline Kaltenborn
//Tabular Editor version 2.16.6
 
foreach(var c in Selected.Columns)
{
  if (c.IsAvaliableInMDX)
  {
      c.IsAvaliableInMDX = false;
  }
  else c.IsAvaliableInMDX = true;
}
