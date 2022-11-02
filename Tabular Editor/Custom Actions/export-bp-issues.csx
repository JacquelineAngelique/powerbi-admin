//Name: Export Best Practice Issues
//Tooltip: run this file to export the BP violations in your pbix file for documentation purposes
//Created by Jacqueline Kaltenborn
//Tabular Editor version 2.16.6

using TabularEditor.BestPracticeAnalyzer; 

var bpa = new Analyzer(); 
bpa.SetModel(Model); 

var sb = new System.Text.StringBuilder(); 
string newline = Environment.NewLine; 

sb.Append("RuleCategory" + '\t' + "RuleName" + '\t' + "ObjectName" + '\t' + "ObjectType" + '\t' + "RuleSeverity" + '\t' + "HasFixExpression" + newline); 

foreach (var a in bpa.AnalyzeAll().ToList()) 
{     
    sb.Append(a.Rule.Category + '\t' + a.RuleName + '\t' + a.ObjectName + '\t' + a.ObjectType + '\t' + a.Rule.Severity + '\t' + a.CanFix + newline); 
} 

sb.Output();
