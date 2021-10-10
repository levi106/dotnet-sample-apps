// https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/const

const string Language = "C#";
const string Platform = ".NET";
const string Version = "10.0";
const string FullProductName = $"{Platform} - Language: {Language} Version: {Version}";

Console.WriteLine(FullProductName);
