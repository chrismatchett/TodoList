using System.Net.Http.Json;

public class TodoItemService
{
    private readonly HttpClient _httpClient;
    
    public TodoItemService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    // public async Task<TodoItem> GetTodo()
    // {
    //     return await _httpClient.GetFromJsonAsync<TodoItem>($"/api/todoitems/{id}");
    // }    
    public async Task<TodoItem> GetTodoItem(int id)
    {
        return await _httpClient.GetFromJsonAsync<TodoItem>($"/api/todoitems/{id}");
    }
}
