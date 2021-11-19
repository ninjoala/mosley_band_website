using Microsoft.AspNetCore.Components;

namespace mosley_website.Client.Pages
{
    public class MosleyComponentBase : ComponentBase
    {
        [CascadingParameter]
        public EventCallback PageLoad { get; set; }
        protected override async Task OnInitializedAsync()
        {
            await PageLoad.InvokeAsync();
            await base.OnInitializedAsync();
        }
    }
}
