using System.Net;

namespace Searcher
{
    public static class Search
    {
        public static string GetSearchString(int index, string term)
        {
            term = HttpUtility.UrlEncode(term);

            switch (index)
            {
                case 0: //google
                    return "http://www.google.com/search?&ie=UTF-8&q=" + term;

                case 1: //bing
                    return "http://www.bing.com/search?q=" + term;

                case 2: //amazon
                    return "http://www.amazon.com/s/ref=nb_sb_noss?url=search-alias%3Daps&field-keywords=" + term + "&x=0&y=0";

                case 3: //wikipedia
                    return "http://en.wikipedia.org/w/index.php?title=Special:Search&search=" + term;

                case 4: // duckduckgo
                    return "http://duckduckgo.com/?q=" + term;

                case 5: //facebook
                    return "http://www.facebook.com/search/?src=os&q=" + term;
            }

            return string.Empty;
        }
    }
}