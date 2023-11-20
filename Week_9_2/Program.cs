// See https://aka.ms/new-console-template for more information
using Week_9_2;

Console.WriteLine("Singleton");


ConfigurationService.GetInstance();
ConfigurationService.GetInstance();
ConfigurationService.GetInstance().GetValue("");
ConfigurationService configurationService = ConfigurationService.GetInstance();
var azureConnectionString = configurationService.GetValue("Storage:Azure");
Console.WriteLine();