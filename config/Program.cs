﻿using System.Reflection;
using System.Text.Json;

var plugins = Directory.GetDirectories("../../../../plugin");
var p = "";
foreach (var plugin in plugins)
{
	try
	{
		var assemblyConfigurationAttribute = typeof(Program).Assembly.GetCustomAttribute<AssemblyConfigurationAttribute>();
		var buildConfigurationName = assemblyConfigurationAttribute?.Configuration;
		var x = Directory.GetDirectories(Path.Combine(plugin, "bin"));

		var f = $"{Path.GetFullPath(plugin)}/bin/{buildConfigurationName}/net8.0/{Path.GetFileName(plugin)}.dll";
		if (File.Exists(f))
			p += $"{f};";
		else
		{

			f = $"{Path.GetFullPath(plugin)}/bin/Debug/net8.0/{Path.GetFileName(plugin)}.dll";
			if (File.Exists(f))
				p += $"{f};";
		}
	}
	catch (Exception e)
	{
		Console.WriteLine(e);
	}
}

var content = JsonSerializer.Serialize(new
{
	DEBUG_PLUGINS = p
});

Console.WriteLine(content);
await File.WriteAllTextAsync("../../../../submodules/BTCPayServer/BTCPayServer/appsettings.dev.json", content);
