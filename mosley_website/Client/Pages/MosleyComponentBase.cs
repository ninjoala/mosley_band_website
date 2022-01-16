using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.JSInterop;
using mosley_website.Client.Extensions;


namespace mosley_website.Client.Pages
{
    public class MosleyComponentBase : ComponentBase, IDisposable
    {
        [Inject]
        public NavigationManager NavManager { get; set; }
        [Inject] 
        public IJSRuntime JsRuntime { get; set; }

        protected override void OnInitialized()
        {
            NavManager.LocationChanged += TryFragmentNavigation;
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            await NavManager.NavigateToFragmentAsync(JsRuntime);
        }

        private async void TryFragmentNavigation(object sender, LocationChangedEventArgs args)
        {
            await NavManager.NavigateToFragmentAsync(JsRuntime);
        }

        public void Dispose()
        {
            NavManager.LocationChanged -= TryFragmentNavigation;
        }
    }
}
