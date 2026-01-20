using PcComponents.Blazor.Models;

namespace PcComponents.Blazor.Clients
{
    public class PcComponentsClient(HttpClient httpClient)
    {
        public async Task<PcComponent[]> GetComponentsAsync() =>
         await httpClient.GetFromJsonAsync<PcComponent[]>("/components") ?? [];
    }
}
