// See https://aka.ms/new-console-template for more information
using DiigoSharp.ApiClient;
using DiigoSharp.ApiClient.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = Host.CreateDefaultBuilder(args);

builder.ConfigureServices(services =>
{
    services.AddDiigoClient("", "", "");
});

var app = builder.Build();
var diigoClient = app.Services.GetRequiredService<IDiigoClient>();

var searchParams = new SearchParameters();
searchParams.User = "aforank";
searchParams.Count = 100;
searchParams.Filter = Visibility.All;

//var result = await diigoClient.GetBookmarks(searchParams);

var bookmark = new Bookmark()
{
    Title = "New Article",
    Url = "https://github.com/notion-dotnet/notion-sdk-net/blob/main/Src/Notion.Client/DI/ServiceCollectionExtensions.cs",
    Desc = "Notion Client",
    Shared = "no",
    ReadLater = "yes",
    Tags ="test"
};

var result1 = await diigoClient.SaveBookmark(bookmark);

app.Run();

