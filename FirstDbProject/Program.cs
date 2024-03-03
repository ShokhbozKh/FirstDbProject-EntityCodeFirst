using FirstDbProject.Data;
using FirstDbProject.Models;
using System;

internal class Program
{
     static void Main(string[] args)
    {
       
        AppDbContext appDbContext = new AppDbContext();
        //Create1
        //Student student = new Student();
        // student.FirtName = "Test";
        // student.LastName = "Test";
        // student.Age= 1;


        // appDbContext.Students.Add(student);
        // appDbContext.SaveChanges();

        //Create2
        //List<Teacher> list = new List<Teacher>()
        //{
        //    new Teacher() {FirtName = "Test", LastName="test2",Age=12,Address="termiz"},
        //    new Teacher() {FirtName = "Test2", LastName="test3",Age=21,Address="qarshi"},
        //    new Teacher() {FirtName = "Test3", LastName="test4",Age=32,Address="toshkent"},
        //};
        //appDbContext.AddRange(list);
        //appDbContext.SaveChanges();

        //Update
        //Guid id = Guid.Parse("850fe008-90b4-4d1e-dd40-08dc3b3bd2e5");
        //Teacher result = appDbContext.Teachers.Find(id);
        //result.FirtName = "Valiboy";
        //result.LastName = "Aliyev";
        //result.Age = 39;
        //appDbContext.SaveChanges();

        //Delete
        Guid id = Guid.Parse("850fe008-90b4-4d1e-dd40-08dc3b3bd2e5");
        Teacher result = appDbContext.Teachers.Find(id);
        appDbContext.Teachers.Remove(result);
        appDbContext.SaveChanges();


        Show();
    }
    static void Show()
    {
        AppDbContext dbContext = new AppDbContext();
        var Teachers = dbContext.Teachers.Where(x => x.Age > 0);
        foreach(var item in Teachers)
        {
            Console.WriteLine(item);
        }

    }
}