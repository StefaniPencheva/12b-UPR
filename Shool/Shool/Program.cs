using Shool.Data;
using System;

namespace Shool
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new SchoolContext();
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
        }
    }
}
