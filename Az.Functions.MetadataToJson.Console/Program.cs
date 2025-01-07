// See https://aka.ms/new-console-template for more information
using Az.Functions.MetadataToJson;
using System;
using System.Diagnostics;
using System.IO;
using System.CommandLine;

var fileOption = new Option<DirectoryInfo?>(
    name: "--file",
    description: "The file to read and display on the console.");

var rootCommand = new RootCommand("Sample app for System.CommandLine");
rootCommand.AddOption(fileOption);

rootCommand.SetHandler((file) =>
        {
            var task = new FunctionsMetadataToJson()
            {
                OutputDirectory = file == null || file.Exists == false ? "..\\..\\..\\..\\..\\..\\horseless-core-fx\\horselessfx\\horselessnewspaper.workflow.fx.infrastructure\\bin\\net8.0" : file.FullName,
                          };

            task.Execute();
        },
            fileOption);

return await rootCommand.InvokeAsync(args);


