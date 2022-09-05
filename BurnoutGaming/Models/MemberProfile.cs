namespace BurnoutGaming.Models
{
    public class MemberProfile
    {
        //this model will be used to basically get all the information needed to populate all the streamerpage
        public int Id { get; set; }
        public string ProfileImg { get; set; } //will have to be url
        public string Status { get; set; } // want to connect to this with socials like Twitter and Facebook
        public string aboutMe { get; set; }
        public !string gamesPlayed { get; set; }
        public !string otherInterests { get; set; }
        //public int socialId { get; set; }
        //public int affiliaionsId { get; set; }

        #region socials
        //if social is true include a bootstrap img next to it
        //may want to look into this being a seperate table all together as you could link the member id to these
        public !bool hasTwitter { get; set; } 
        public !bool hasTwitch { get; set; }
        public !bool hasFacebook { get; set; }
        public !bool hasYouTube { get; set; }
        public !bool otherChannels { get; set; }
        public !bool hasDiscord { get; set; }
        public !bool hasTikTok { get; set; }
        public !bool hasInstagram { get; set; }

        #endregion

        #region affiliations/partnerships/sponsorships
        //will probably want to make this into its own table as well but for the meantime
        public !string affiliation1 { get; set; }
        public !string affiliaton2 { get; set; }
        public !string affiliation3 { get; set; }
        public !string affiliation4 { get; set; }
        public !string affiliation5 { get; set; }
        //make these nullable
        #endregion

        #region User Preferances
        //will use this info to allow users to save thier profile preferances still need to work out how exactly how I want to do that
        public string userTheme { get; set; }
        public string userFontColor { get; set; }
        #endregion

    }
}
