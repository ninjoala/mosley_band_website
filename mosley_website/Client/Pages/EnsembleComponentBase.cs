﻿using Microsoft.AspNetCore.Components;

namespace mosley_website.Client.Pages
{
    public class EnsembleComponentBase : ComponentBase
    {
        [Parameter]
        public string? EnsembleName { get; set; }
        public string? Header { get; set; }
        public string? Blurb { get; set; }
        public string? PicturePath { get; set; }
        public string? Article { get; set; }
        
        public bool Loading { get; set; }

        public const string SotslHeader = "Sound of the Southland";
        public const string SymphonyBandHeader = "Symphony Band";
        public const string SymphonicBandHeader = "Symphonic Band";
        public const string JazzEnsembleHeader = "Jazz Ensemble";
        public const string PercussionHeader = "Percussion";
        public const string ColorguardHeader = "Colorguard";



        public const string SotslArticle = @"Founded in 1974, the “Sound of the Southland” (SOTSL) serves as the marching band 
within the Mosley Band Program. The SOTSL performs regularly for all football home and away games, community parades, 
and various events throughout Bay County. The group participates in regional marching band competitions and festivals, 
where they consistently receive “Superior” ratings and other accolades.";
        public const string SymphonyBandArticle = @"The Mosley Symphony Band is the advanced group and premiere instrumental 
ensemble of the Mosley Band Program. The Mosley Symphony Band is an auditioned ensemble that is open to all band 
students and historically performs Grade Five literature.";
        public const string SymphonicBandArticle = @"The Symphonic Band is the intermediate group within the Mosley Band Program. 
This ensemble is non-auditioned and is open to any band students. The Symphonic Band will foster and develop 
students’ individual and ensemble skills in a setting best suited to meet their needs.";
        public const string JazzEnsembleArticle = @"The Mosley Jazz Ensemble is open to any musician currently enrolled 
in a band class. Students will learn jazz history, jazz theory, and techniques specific to this American artform. 
Jazz Ensemble meets each day and for select after-school rehearsals.";
        public const string PercussionArticle = @"The percussion program at Mosley is comprised of percussion students that 
perform with the Mosley Drumline, percussion ensemble, as well as several small chamber groups. Percussion students at 
Mosley meet each day during school. Percussion students at Mosley are trained in a variety of aspects of percussion 
and have an opportunity to perform with not only the above ensembles but also in one of two concert bands and jazz band.";
        public const string ColorguardArticle = @"Colorguard is a combination of the use of flags, sabers, mock rifles, 
and other equipment, as well as dance and other interpretive movements. Colorguards can be found in high schools, 
middle schools, universities, and other independent organizations. The Mosley Colorguard performs with the 
“Sound of the Southland'' Marching Band at all football games as well as other scheduled competitions and parades,
as well as Solo and Ensemble.";

        public const string SotslPicturePath = "images/sotsl.jpg";
        public const string SymphonyBandPicturePath = "images/symphony-band.jpg";
        public const string SymphonicBandPicturePath = "images/symphonic-band.jpg";
        public const string JazzEnsemblePicturePath = "images/jazz_ensemble.jpg";
        public const string PercussionPicturePath = "images/percussion_ensemble.jpg";
        public const string ColorguardPicturePath = "images/colorguard_ensemble.jpg";


        protected override async Task OnInitializedAsync()
        {
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
                    Header = SotslHeader;
                    Article = SotslArticle;
                    PicturePath = SotslPicturePath;
                    break;
                case "SymphonyBand":
                    Header = SymphonyBandHeader;
                    Article = SymphonyBandArticle;
                    PicturePath = SymphonyBandPicturePath;
                    break;
                case "SymphonicBand":
                    Header = SymphonicBandHeader;
                    Article = SymphonicBandArticle;
                    PicturePath = SymphonicBandPicturePath;
                    break;
                case "Jazz":
                    Header = JazzEnsembleHeader;
                    Article = JazzEnsembleArticle;
                    PicturePath = JazzEnsemblePicturePath;
                    break;
                case "Percussion":
                    Header = PercussionHeader;
                    Article = PercussionArticle;
                    PicturePath = PercussionPicturePath;
                    break;
                case "Colorguard":
                    Header = ColorguardHeader;
                    Article = ColorguardArticle;
                    PicturePath = ColorguardPicturePath;
                    break;
            }
        }
    }
}
