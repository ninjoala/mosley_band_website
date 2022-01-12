using Microsoft.AspNetCore.Components;


namespace mosley_website.Client.Pages
{
    public class MosleyComponentBase : ComponentBase
    {
        [CascadingParameter]
        public EventCallback PageLoad { get; set; }

        [CascadingParameter]
        public bool IsAuthorized { get; set; }

        [CascadingParameter]
        public EventCallback LoginButtonPress { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        protected override async Task OnInitializedAsync()
        {
            //if (!IsAuthorized)
            //{
            //    NavigationManager.NavigateTo("/ComingSoon");
            //}
            await PageLoad.InvokeAsync();
            await base.OnInitializedAsync();
        }

        public async Task Login()
        {
            await LoginButtonPress.InvokeAsync();
        }
    }
}
