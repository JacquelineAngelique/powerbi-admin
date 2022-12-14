//Name: Default Measure Description
//Tooltip: Adds expression to the description
//Enable: Model
//Created by Jacqueline Kaltenborn
//Tabular Editor version 2.16.6

//It is better to format DAX before adding it into the descriptions
foreach(var m in Model.AllMeasures)
{
    if(m.Description == "")
    {    
        m.Description =  "Expression:" + "\n" + m.Expression;
    }
    else if (!m.Description.Contains("Expression"))
    {
        m.Description = m.Description + "\n" + "Expression:" + "\n" + m.Expression;
    }
    else
    {
        // reset expressions already added
        int pos = m.Description.IndexOf("Expression",0); 
        bool onlyExpression = (pos == 0);
        
        if (onlyExpression) {
            m.Description = "Expression:" + "\n" + m.Expression;
        } else {
            m.Description = m.Description.Substring(0,pos-1)  + "\n" + "Expression:" + "\n" + m.Expression;
        }
    }
}
