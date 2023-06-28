namespace PrtialViewDemo.Models
{
    public class ProductCRUD
    {
        private ApplicationDbContext db;
        public ProductCRUD(ApplicationDbContext db)
        {
            this.db = db;
        }
        public IEnumerable<Product> GetProducts()
        {
           
            return db.Products.ToList();
        }
    }
}
