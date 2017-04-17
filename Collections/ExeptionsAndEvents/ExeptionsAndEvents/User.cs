using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeptionsAndEvents
{
    class User
    {
        public string Name { get; private set; }
        public User(string name, Blogger blogger)
        {
            Name = name;
            blogger.NewVideoBlog += Blogger_NewVideoBlog;

        }
        private void Blogger_NewVideoBlog(object sender, EventArgs e)
        {
            if (e is BloggerEventArgs)
            {
                BloggerEventArgs bloggerEventArgs = e as BloggerEventArgs;

                Console.WriteLine("User {0} Nowy Film od Bloggera!", Name);
                Console.WriteLine("Title: {0}:", bloggerEventArgs.Title);
                Console.WriteLine("Time: {0} /sec", bloggerEventArgs.DurationInSeconds);
                Console.WriteLine();
            }
        }
    }
}

