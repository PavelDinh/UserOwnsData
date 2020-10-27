# UserOwnsData
https://www.youtube.com/watch?v=J9p9VgtNpTY&amp;ab_channel=MicrosoftPowerBI

## Setup VSCode project
### CLI commands:
 * dotnet new mvc --auth SingleOrg --framework netcoreapp3.1 
 * dotnet remove package Microsoft.AspNetCore.Authentication.AzureAD.UI # update to latest available version of Microsoft.Identity.Web  
 
 * dotnet add package Microsoft.Identity.Web 
 * dotnet add package Microsoft.Identity.Web.UI
 * dotnet add package Microsoft.PowerBi.Api
