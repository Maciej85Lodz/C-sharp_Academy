using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeptionsAndEvents
{
    class Blogger
    {
        public event EventHandler NewVideoBlog;
        public void OnNewVideoBlog(BloggerEventArgs e)
        {
            EventHandler newVideoBlog = NewVideoBlog;
            if (newVideoBlog != null)
                newVideoBlog(this, e);
        }
    }

    class BloggerEventArgs : EventArgs
    {
        //Tytuł
        public string Title { get; private set; }
        //Czas trwania Video bBloga
        public int DurationInSeconds { get; private set; }

        public BloggerEventArgs(string title, int durationInSeconds)
        {
            Title = title;
            DurationInSeconds = durationInSeconds;
        }
    }
}
