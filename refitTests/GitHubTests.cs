using System.Threading.Tasks;
using learnRefit;

namespace refitTests;

public class UnitTest1
{
    [Fact]
    public async Task GetUserLogin()
    {
        var userName = "bniebauer";
        var expected = "bniebauer";

        var user = await GitHubService.GetUserAsync(userName);

        Assert.Equal(expected, user.Login);
    }

    [Fact]
    public async Task GetUserName()
    {
        var userName = "bniebauer";
        var expected = "Brenton Niebauer";

        var user = await GitHubService.GetUserAsync(userName);

        Assert.Equal(expected, user.Name);
    }

    [Fact]
    public async Task GetRepoList()
    {
        var userName = "bniebauer";
        var expected = 1;

        var listOfRepos = await GitHubService.GetAllReposAsync(userName);

        Assert.True(listOfRepos.Count() > expected);
    }
}