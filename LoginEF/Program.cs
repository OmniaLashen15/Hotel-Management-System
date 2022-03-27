using LoginEF.Context;
using LoginEF.Entity;
using Microsoft.EntityFrameworkCore;

using (Login_ManagementContext Context = new())
{
    Context.Database.Migrate();

    //Frontend f = new()
    //{
    //    UserName = "admin123",
    //    Password = "admin",
    //};

    Kitchen k = new()
    {
        UserName = "kitchen",
        Password = "kitchen"
    };

    //Context.Add(f);
    Context.Add(k);
    int R = Context.SaveChanges();
    Console.WriteLine($"Number of Rows Affected = {R}");
}

