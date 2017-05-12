using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post
{
    class Program
    {
        static void Main(string[] args)
        {
            var stackPost = new Post("Exercise 2", "Exercise 1 was rough.", new DateTime(2017,5,11));
            stackPost.DownVote();
            stackPost.UpVote();
            Console.WriteLine(stackPost);
        }
    }
}
