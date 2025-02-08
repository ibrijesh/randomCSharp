using randomCSharp.Asynchronous;

namespace randomCSharp;

public class TryOut
{
    static async Task Main()
    {
        Console.WriteLine($"Thread ID: {Thread.CurrentThread.ManagedThreadId}  Before API Call");
        
        string data = await FetchData();

        Console.WriteLine($"Thread ID: {Thread.CurrentThread.ManagedThreadId}  After API Call");
        
        Console.WriteLine($"Thread ID: {Thread.CurrentThread.ManagedThreadId}  {data}");
    }
    
    static async Task<string> FetchData()
    {

        HttpClientHandler handler = new HttpClientHandler
        {
            ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => true
        };

        using HttpClient client = new HttpClient(handler);

        // Synchronous API call (blocks execution)
        HttpResponseMessage response = await client.GetAsync("https://hub.dummyapis.com/delay?seconds=5");

        // Synchronously read response content
        string data = await response.Content.ReadAsStringAsync();

        return data;
    }
}