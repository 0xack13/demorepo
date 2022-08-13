using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

public class CarContext : DbContext
{
    public DbSet<Car> Cars { get; set; }
    public DbSet<Part> Parts { get; set; }

    public string DbPath { get; }

    public CarContext()
    {
        //var folder = Environment.SpecialFolder.LocalApplicationData;
        //var path = Environment.GetFolderPath(folder);
        DbPath = "/Users/s0x/dbsqlite/carsdb.db";
    }

    // The following configures EF to create a Sqlite database file in the
    // special "local" folder for your platform.
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");


}

public class Car
{
    public int CarId { get; set; }
    public string CarName { get; set; }

    public List<Part> Parts { get; } = new();
}

public class Part
{
    public int PartId { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }

    public int CarId { get; set; }
    public Car Car { get; set; }
}
