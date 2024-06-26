using MongoDB.Driver;
using Volo.Abp.MongoDB;

namespace AbpOrleansAppTemplate.Books;
//...

public class BookStoreMongoDbContext : AbpMongoDbContext
{
    public IMongoCollection<Book> Books => Collection<Book>();
    //...
}
