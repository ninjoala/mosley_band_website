using Microsoft.AspNetCore.Components;


namespace mosley_website.Client.Pages
{
    public class MosleyComponentBase : ComponentBase
    {

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        protected override void OnInitialized()
        {
            base.OnInitialized();
        }
    }
}
