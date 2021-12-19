using Microsoft.AspNetCore.Components;

namespace mosley_website.Client.Pages
{
    public class EnsemblePageBase : MosleyComponentBase
    {
        [Parameter]
        public string? EnsembleName { get; set; }
        public string? Blurb { get; set; }
        public string? PicturePath { get; set; }
        public string? Article { get; set; }
        
        public bool Loading { get; set; }

        public const string Sotsl = "Sound of the Southland";
        public const string SymphonyBand = "Symphony Band";
        public const string SymphonicBand = "Symphonic Band";
        public const string JazzEnsemble = "Jazz Ensemble";
        public const string Percussion = "Percussion";
        public const string Colorguard = "Colorguard";

        public const string SotslBlurb = "SotslBlurb";
        public const string SymphonyBandBlurb = "SymponyBandBlurb";
        public const string SymphonicBandBlurb = "SymphonicBandBlurb";
        public const string JazzEnsembleBlurb = "JazzEnsembleBlurb";
        public const string PercussionBlurb = "PercussionBlurb";
        public const string ColorguardBlurb = "ColorguardBlurb";

        public const string SotslArticle = "SotslArticle";
        public const string SymphonyBandArticle = "SymponyBandArticle";
        public const string SymphonicBandArticle = "SymphonicBandArticle";
        public const string JazzEnsembleArticle = "JazzEnsembleArticle";
        public const string PercussionArticle = "PercussionArticle";
        public const string ColorguardArticle = "ColorguardArticle";

        public const string SotslPicturePath = "SotslPicturePath";
        public const string SymphonyBandPicturePath = "SymponyBandPicturePath";
        public const string SymphonicBandPicturePath = "SymphonicBandPicturePath";
        public const string JazzEnsemblePicturePath = "JazzEnsemblePicturePath";
        public const string PercussionPicturePath = "PercussionPicturePath";
        public const string ColorguardPicturePath = "ColorguardPicturePath";


        protected override async Task OnInitializedAsync()
        {
            await PageLoad.InvokeAsync();
            await base.OnInitializedAsync();
            Loading = false;
        }

        protected override async Task OnParametersSetAsync()
        {
            await PopulateData();
        }

        public async Task PopulateData()
        {
            switch (EnsembleName)
            {
                case "Sotsl":
                    Blurb = SotslBlurb;
                    Article = SotslArticle;
                    PicturePath = SotslPicturePath;
                    break;
                case "SymphonyBand":
                    Blurb = SymphonyBandBlurb;
                    Article = SymphonyBandArticle;
                    PicturePath = SymphonyBandPicturePath;
                    break;
                case "SymphonicBand":
                    Blurb = SymphonicBandBlurb;
                    Article = SymphonicBandArticle;
                    PicturePath = SymphonicBandPicturePath;
                    break;
                case "Jazz":
                    Blurb = JazzEnsembleBlurb;
                    Article = JazzEnsembleArticle;
                    PicturePath = JazzEnsemblePicturePath;
                    break;
                case "Percussion":
                    Blurb = PercussionBlurb;
                    Article = PercussionArticle;
                    PicturePath = PercussionPicturePath;
                    break;
                case "Colorguard":
                    Blurb = ColorguardBlurb;
                    Article = ColorguardArticle;
                    PicturePath = ColorguardPicturePath;
                    break;
            }
        }
    }
}
