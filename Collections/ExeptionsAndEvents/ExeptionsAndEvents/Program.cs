using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeptionsAndEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    int[] myTab = new int[2];
            //    myTab[0] = 1;
            //    myTab[1] = 2;
            //    int element = myTab[10];
            //}

            //catch(IndexOutOfRangeException exception)
            //{
            //    Console.WriteLine("Error: " + exception.Message);
            //}
            //catch(Exception exception)
            //{
            //    Console.WriteLine("Other exception: " + exception.Message);
            //}


            //Events:
            Blogger blogger = new Blogger();
            User user1 = new User("Maciej", blogger);
            User user2 = new User("Natalia", blogger);
            User user3 = new User("Adam", blogger);
            User user4 = new User("Ania", blogger);

            BloggerEventArgs bloggerArgs = new BloggerEventArgs("Odcinek1", 180);
            blogger.OnNewVideoBlog(bloggerArgs);
            bloggerArgs = new BloggerEventArgs("Odcinek 2", 220);
            blogger.OnNewVideoBlog(bloggerArgs);


            Console.ReadKey();
        }
    }
}
