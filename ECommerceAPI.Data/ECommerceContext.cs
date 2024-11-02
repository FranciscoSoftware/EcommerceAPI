using ECommerceAPI.Data.Model;
using Microsoft.EntityFrameworkCore;

namespace ECommerceAPI.Data;

public class ECommerceContext :DbContext
{
    public ECommerceContext(DbContextOptions<ECommerceContext>options):base(options){}

    public DbSet<Product>? Products {get; set;}
    public DbSet<Order>? Orders {get; set;}
    public DbSet<User>? Users {get; set;}
}
