using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace GoCart.Client.Shared
{
    public partial class ProductList
    {
        [Inject]
        private HttpClient HttpClient { get; set; }

        private List<Product> Products = new List<Product>();

        protected override async Task OnInitializedAsync()
        {
            var result = await HttpClient.GetFromJsonAsync<List<Product>>("api/Product");
            if (result != null)
            {
                Products = result;
            }
        }
    }
}