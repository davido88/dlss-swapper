using Octokit;
using System.Diagnostics;

var client = new GitHubClient(new ProductHeaderValue("DLSS-Swapper_WingetManifestBuilder"));
var releases = await client.Repository.Release.GetAll("beeradmoore", "dlss-swapper");
var latest = releases.FirstOrDefault();

Debugger.Break();

Console.WriteLine(
    "The latest release is tagged at {0} and is named {1}",
    latest.TagName,
    latest.Name);
