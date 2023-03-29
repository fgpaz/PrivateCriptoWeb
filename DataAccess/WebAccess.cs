using Newtonsoft.Json;

namespace DataAccess;

public class WebAccess
{
    protected HttpClient _httpClient = null!;

    protected async Task<T?> Get<T>(string url)
    {
        var response = await _httpClient.GetAsync(url);
        var content = await response.Content.ReadAsStringAsync();


        if (response.IsSuccessStatusCode)
        {
            var result = JsonConvert.DeserializeObject<T>(content);
            return result;
        }

        throw new Exception($"\nError en request: {_httpClient.BaseAddress}{url}\n" +
                            $"StatusCode: {response.StatusCode}\n" +
                            $"Respuesta: {content}\n");
    }
}