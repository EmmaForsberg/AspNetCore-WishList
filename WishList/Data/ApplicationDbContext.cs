using Microsoft.EntityFrameworkCore;

namespace WishList
{ 

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options)
        :base(options)
    {

    }



}
}
