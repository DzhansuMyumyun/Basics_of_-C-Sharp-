using Intro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.Business;

public class CourseManager
{

    Course[] courses = new Course[3];


   //constructor
    public CourseManager()
    {
        Course course1 = new Course();
        course1.Id = 1;
        course1.Name = "C#";
        course1.Description = ".Net";
        course1.Price = 0;

        Course course2 = new Course();
        course2.Id = 2;
        course2.Name = "JAVA";
        course2.Description = ".Net";
        course2.Price = 0;

        Course course3 = new Course();
        course3.Id = 3;
        course3.Name = "CSS";
        course3.Description = ".Net";
        course3.Price = 0;
        
        courses = new Course[] { course1, course2, course3 };
        courses[0] = course1;
        courses[1] = course2;
        courses[2] = course3;   
    }

    public Course[] GetAll()
    {
        return courses;
    }
}
