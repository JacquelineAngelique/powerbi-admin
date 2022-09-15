# Developing Custom Workspace 
## Capabilities and properties of Power BI visuals
[https://docs.microsoft.com/en-us/power-bi/developer/visuals/capabilities]
Every visual has a capabilities.json file that is created automatically when you run the pbiviz new <visual project name> command to create a new visual. The capabilities.json file describes the visual to the host.

The capabilities.json file tells the host what kind of data the visual accepts, what customizable attributes to put on the properties pane, and other information needed to create the visual. Starting from API v4.6.0, all properties on the capabilities model are optional except privileges, which are mandatory.

The capabilities.json file lists the root objects in the following format:

```{
    "privileges": [ ... ],
    "dataRoles": [ ... ],
    "dataViewMappings": [ ... ],
    "objects":  { ... },
    "supportsHighlight": true|false,
    "advancedEditModeSupport": 0|1|2,
    "sorting": { ... }
    ...
}
```
## Sorting Options
