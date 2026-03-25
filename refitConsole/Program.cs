using System;
using learnRefit;

Console.WriteLine("Please enter a username to search: ");
var userName = Console.ReadLine();

var user = await GitHubService.GetUserAsync(userName);

if (user is null)
    return;

Console.WriteLine($"The user Name is: {user.Name}");
Console.WriteLine($"The user Login is: {user.Login}");
Console.WriteLine($"The user Avatar URL is: {user.Avatar_Url}");
Console.WriteLine($"The user URL is: {user.Url}");
Console.WriteLine($"{user.Name} has {user.Public_Repos} public repositories.");