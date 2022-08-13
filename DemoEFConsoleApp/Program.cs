using System;
using System.Linq;

using var db = new BloggingContext();

Console.WriteLine("New Pizza");
db.Add(new Pizza { PizzaName="AliPizza", PizzaPrice=12});
db.SaveChanges();

// Delete
//Console.WriteLine("Delete the blog");
//db.Remove(blog);
//db.SaveChanges();