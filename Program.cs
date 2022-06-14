using System;
using Conceitos_POO.ContentContext;
using Conceitos_POO.ContentContext.Enums;
using System.Collections.Generic;
using System.Linq;
using Conceitos_POO.SubscriptionContext;

namespace Conceitos_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            var articles = new List<Article>();
            articles.Add(new Article("Artigo sobre OOP1","orienta1"));
            articles.Add(new Article("Artigo sobre OOP2","orienta2"));
            articles.Add(new Article("Artigo sobre OOP3","orienta3"));

            // foreach(var article in articles)
            // {
            //     Console.WriteLine(article.Id);
            //     Console.WriteLine(article.Title);
            //     Console.WriteLine(article.Url);
            //     Console.WriteLine();
            // }

            var courses = new List<Course>();
            var course1 = new Course("Artigo sobre OOP1","orienta1");
            var course2 = new Course("Artigo sobre OOP2","orienta2");
            var course3 = new Course("Artigo sobre OOP3","orienta3");

            courses.Add(course1);
            courses.Add(course2);
            courses.Add(course3);



            var careers = new List<Career>();
            var career = new Career("Especialista .Net","especialista-dotnet");
            var careerItem2 = new CareerItem(2,"OOP","",null);
            var careerItem = new CareerItem(1,"Comece aqui","",course1);
            var careerItem3 = new CareerItem(3,"Aprenda .Net","",course3);

            career.Items.Add(careerItem3);
            career.Items.Add(careerItem);
            career.Items.Add(careerItem2);
            
            careers.Add(career);

            foreach(var i in careers)
            {
                Console.WriteLine(career.Title);
                foreach(var j in  career.Items.OrderBy(x => x.Order))
                {
                    Console.WriteLine($"{j.Order} - {j.Title}");
                    Console.WriteLine(j.Course?.Title);
                    Console.WriteLine(j.Course?.Level);

                    foreach(var notification in j.Notifications)
                    {
                        Console.WriteLine($"{notification.Property} - {notification.Message}");
                    }
                }
            }
            
            var payPalSubscription = new PayPalSubscription();
            var student = new Student();
            student.CreateSubscription(payPalSubscription);
        }
    }
}
