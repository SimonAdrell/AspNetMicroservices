using Catalog.API.Entites;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace Catalog.API.Data
{
    public class CatalogContext : ICatalogContext
    {
        public CatalogContext(IConfiguration configuration)
        {
            var client = new MongoClient(configuration.GetValue<string>("DatabaseConnection:ConnectionString"));
            var database = client.GetDatabase(configuration.GetValue<string>("DatabseConnection:DatabaseName"));
            Products = database.GetCollection<Product>(configuration.GetValue<string>("DatabaseConnection:CollectionName"));
            CatalogContextSeed.SeedData(Products);
        }

        public IMongoCollection<Product> Products { get; }
    }
}
