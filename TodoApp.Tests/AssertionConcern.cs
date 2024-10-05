using TodoApp.API.Model;

namespace TodoApp.Tests;

public class AssertionConcern
{
    private readonly HttpClient _client;

    public AssertionConcern()
    {
        // Configure the client (assuming you have a TestServer setup elsewhere)
        _client = new HttpClient(); // Replace with actual initialization as needed
    }


    public void TestTaskModelPropertyAssignment()
    {
        // Arrange
        var taskModel = new TaskModel
        {
            Id = 1,
            Title = "Test title",
            Description = "Test description",
            IsCompleted = false
        };

        // Act

        // Assert
        Assert.Equal(1, taskModel.Id);
        Assert.Equal("Test title", taskModel.Title);
        Assert.Equal("Test description", taskModel.Description);
        Assert.False(taskModel.IsCompleted);
    }

    public void TestTaskModelChangeStatus()
    {
        // Arrange
        var taskModel = new TaskModel
        {
            Id = 1,
            Title = "Test title",
            Description = "Test description",
            IsCompleted = false
        };

        // Act
        taskModel.MarkAsCompleted();

        // Assert
        Assert.True(taskModel.IsCompleted);
    }
}