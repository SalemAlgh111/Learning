using System;
using Learning.Models;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();
var connString = builder.Configuration.GetConnectionString("DefaultConnection");


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();



//// ﬁÌ„… À«» Â ·«   €Ì—
//const string MyNameIsConstent = "Salem A Alghassab";



//var age = 23;

//if (age ==14)
//{
//    Console.WriteLine("young");

//}
//else if (age == 15)
//{
//    Console.WriteLine("bzr");
//}
//else if (age == 30)
//{
//    Console.WriteLine("grandfather");

//}
//else if (age ==23)
//{
//    Console.WriteLine("correct age");
//}


//we use the switch statment if we have a lot if comprasion choices 



//var  CarModel = 2023;

//switch (CarModel)
//{
//    case 2012:
//        Console.WriteLine("not Allowed ");
//        break;
//    case 2015:
//        Console.WriteLine("orcjn");
//        break;
//    case 2023:
//        Console.WriteLine("hello");
//        break;
//    default:
//        Console.WriteLine("none");
//}
//var Name=new String[5];
//Name[0] = "Ahmed";
//Name[1] = "Salem";
//Name[2] = "Asma";
//Name[3] = "Faisal";
//Name[4] = "Abdulrhman";
//Name[5] = "Fahad";

//foreach (var name in Name )
//{
//    Console.WriteLine();
//}