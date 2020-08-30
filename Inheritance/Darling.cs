using System;
namespace Inheritance
{
    public class Darling : Heroine
    {
       public Darling(string name, int height, int age, int moviesCount)
        {
            heroineName = name;
            heroineHeight = height;
            heroineAge = age;
            heroineMoviesCount = moviesCount;
        }
       public int latestMovie()
        {
            Console.WriteLine("The Old Guard");
            return 0;
        }
    }
}
