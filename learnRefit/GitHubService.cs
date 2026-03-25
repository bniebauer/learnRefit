using System;
using Refit;
using learnRefit;

namespace learnRefit;

public static class GitHubService
{
    public static async Task<User?> GetUserAsync(string userName)
    {
        Console.WriteLine("Setting up the API..");
        var api = RestService.For<IGitHubApi>("https://api.github.com");
        Console.WriteLine("Making the call for user: octocat");
        try
        {
            var user = await api.GetUserAsync(userName);
            return user;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        return null;
    }
    
    public static async Task<List<Repo>?> GetAllReposAsync(string userName)
    {
        Console.WriteLine("Setting up the API..");
        var api = RestService.For<IGitHubApi>("https://api.github.com");
        Console.WriteLine("Making the call for repos");
        try
        {
            var repos = await api.GetAllReposAsync(userName);
            return repos;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        return null;        
    }
}
