namespace TodoApp.Tests;

public class AssertionConcern
{
    private readonly HttpClient _client;

    public AssertionConcern()
    {
        // Configure the client (assuming you have a TestServer setup elsewhere)
        _client = new HttpClient(); // Replace with actual initialization as needed
    }

    [Fact]
    public async Task Should_Return200_When_GetTodoItem()
    {
        // Arrange
        var requestUri = "https://localhost:44330/api/task/1"; // Update with actual route

        // Act
        var response = await _client.GetAsync(requestUri);

        // Assert
        response.EnsureSuccessStatusCode();
        Assert.Equal(System.Net.HttpStatusCode.OK, response.StatusCode);
    }

    [Fact]
    public async Task Should_Return404_When_TodoItemNotFound()
    {
        // Arrange
        var requestUri = "https://localhost:44330/api/task/999"; // Non-existing ID

        // Act
        var response = await _client.GetAsync(requestUri);

        // Assert
        Assert.Equal(System.Net.HttpStatusCode.NotFound, response.StatusCode);
    }

    // Additional test cases can be added here
}