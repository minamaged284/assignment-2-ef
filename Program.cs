using assignment_1.contexts;
using assignment_1.entities;
using Microsoft.EntityFrameworkCore;

namespace assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            itiDbContext ItiDb = new itiDbContext();

            Department dept1 = new Department()
            {
                HiringDate = DateTime.Now,
                Name = "back end",
      
            };
            ItiDb.Add(dept1);
            

           ItiDb.SaveChanges();

            var dept1Update = (from d in ItiDb.Set<Department>()
                          where d.Id == 1
                          select d).First();
            Student student1 = new Student()
            {
                Adress = "cairo",
                DepartID = dept1Update,
                Age = 30,
                FNAme = "mina",
                LNAme = "magef"
            };

            ItiDb.Add(student1);
            dept1Update.Name = "front end";
            ItiDb.SaveChanges();

            Instructor instructor1 = new Instructor()
            {
                Address = "cairo",
                DepartId = dept1Update,
                Bonus = 30000,
                Name = "mina",
                Salary = 1500000,
                HourRate = 3000,
            };

            ItiDb.Add(instructor1);
            ItiDb.SaveChanges();

            Topic topic1 = new Topic()
            {
                Name = "c sharp"
            };

            ItiDb.Add(topic1);
            ItiDb.SaveChanges();

            var topic1Update = (from t in ItiDb.Set<Topic>()
                                where t.Id == 1
                                select t).ToList();
            ItiDb.SaveChanges();

            Course course1 = new Course()
            {
                Description = "back end and front end",
                Name = "fullstack",
                Duration = 1000,
                TopID = topic1Update,
 
            };

            ItiDb.Add(course1);
            ItiDb.SaveChanges();








        }
    }
}
