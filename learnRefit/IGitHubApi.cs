using Refit;
using learnRefit;

[Headers("User-Agent: RefitDemoApp")]
public interface IGitHubApi
{
    [Get("/users/{user}")]
    Task<User> GetUserAsync(string user);

    [Get("/search")]
    Task<List<User>> SearchUsersAsync([Query] string name);

    [Get("/users/{owner}/repos")]
    Task<List<Repo>> GetAllReposAsync([AliasAs("owner")] string user);

    [Get("/repos/{owner}/{repo}")]
    Task<Repo> GetRepo([AliasAs("owner")] string user, string repo);
}