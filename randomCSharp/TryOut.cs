using randomCSharp.Asynchronous;

namespace randomCSharp;

public class TryOut
{
    static void Main()
    {
        Console.WriteLine($"Thread ID: {Thread.CurrentThread.ManagedThreadId}  Before API Call");
        
        string data = FetchData();

        Console.WriteLine($"Thread ID: {Thread.CurrentThread.ManagedThreadId}  After API Call");
        
        Console.WriteLine($"Thread ID: {Thread.CurrentThread.ManagedThreadId}  {data}");
    }
    
    static string FetchData()
    {

        HttpClientHandler handler = new HttpClientHandler
        {
            ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => true
        };

        using HttpClient client = new HttpClient(handler);

        // Synchronous API call (blocks execution)
        HttpResponseMessage response = client.GetAsync("https://hub.dummyapis.com/delay?seconds=5").GetAwaiter().GetResult();

        // Synchronously read response content
        string data = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();

        return data;
    }
}