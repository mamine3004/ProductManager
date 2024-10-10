using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataLayer
{
    public class ProductContextFactory:IDesignTimeDbContextFactory<ProductContext>
    {
            public ProductContext CreateDbContext(string[] args)
            {
                var optionsBuilder = new DbContextOptionsBuilder<ProductContext>();

                // Use your connection string or configure it accordingly
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-TOLSAEC\\SQLEXPRESS;Initial Catalog=productstore;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");

                return new ProductContext(optionsBuilder.Options);
            }

    }
}
