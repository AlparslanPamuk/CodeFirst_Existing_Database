using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst_Existing_Database
{
    class Program
    {
        static void Main(string[] args)
        {

            ////////////////////////////////////////////// Adding Objects //////////////////////////////////////////////
            //var context = new PlutoContext();

            //var authors = context.Authors.ToList();

            //var author = context.Authors.Single(a => a.Id == 1);
            //var course = new Courses
            //{
            //    Name = "New Course",
            //    Description = "New Description",
            //    FullPrice = 19.95f,
            //    level = 1,
            //    Authors = author
            //};

            //context.Courses.Add(course);

            //context.SaveChanges();

            ////////////////////////////////////////////// Updating Objects //////////////////////////////////////////////
            //var context = new PlutoContext();

            //var course = context.Courses.Find(4);
            //course.Name = "Mustafa Alparslan Pamuk";
            //course.Author_Id = 2;
            //context.SaveChanges();

            ////////////////////////////////////////////// Deleting Objects //////////////////////////////////////////////

            //var context = new PlutoContext();

            //var authors = context.Authors.Include(a => a.Courses).Single(a => a.Id == 2);
            //context.Courses.RemoveRange(authors.Courses);
            //context.Authors.Remove(authors);

            //context.SaveChanges();

        }
    }
}
