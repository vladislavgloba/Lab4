namespace TestareSoft
{
    public class Xpaths
    {
        //elementul pentru input cu name = q;
        public string googleXpath = "//input[@name='q']";
        //elementul care se afla in header, cautam dupa id, in cazul dat cautam o imagine
        public string googleHeader = "//a[@id='logo']";
        
        public string youtubeXpath = "//input[@name='search_query']";
        public string youtubeHeader = "//yt-icon[@id='logo-icon']";
        
        public string amazonXpath = "//input[@name='field-keywords']";
        public string amazonHeader = "//a[@id='nav-logo-sprites']";
        
        public string ebayXpath = "//input[@name='_nkw']";
        public string ebayHeader = "//a[@id='gh-la']";

    }
}