using System;
using System.Runtime.InteropServices;

Console.WriteLine($"Hello SWETUGG 2024 from {RuntimeInformation.OSArchitecture}!");

var content = System.IO.File.ReadAllText("/etc/hosts");
Console.WriteLine(content);