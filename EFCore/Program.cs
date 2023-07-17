using EFCore.Models;
using EFCore.Data;

ApplicationDbContext dbContext = new ApplicationDbContext();

//User user = new User();
//user.Name = "aliyavar";
//user.Surname = "guluzada";
//user.Email = "aliyavarguluzada@gmail.com";
//user.Password = "aliyavar123";
//user.Age = 22;


User user = dbContext.Users.Where(u => u.Name == "aliyavar").FirstOrDefault();
user.Name = "mamed";
//dbContext.Add(user);
dbContext.SaveChanges();

