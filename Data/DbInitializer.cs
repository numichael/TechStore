using ecommerce_api.Entities;

namespace ecommerce_api.Data
{
    public static class DbInitializer
    {
        public static void Initialize(StoreContext context)
        {
            if (context.Products.Any()) return;

            var products = new List<Product>
            {
                new Product
                {
                    Name = "Angular Speedster Board 2000",
                    Description = "This is angular speedster board 2000",
                    Price = 20000,
                    PictureUrl = "/images/products/sb-ang1.png",
                    Brand = "Angular",
                    Type = "Boards",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Green Angular Board 3000",
                    Description = "An angular board that's different from the former",
                    Price = 34000,
                    PictureUrl = "/images/products/sb-an2.png",
                    Brand = "Angular2",
                    Type = "New Boards",
                    QuantityInStock = 200
                },
                new Product
                {
                    Name = "React rounter tutorial skateboard",
                    Description = "The full package react rounter tutorial skate board is sleek and awesome",
                    Price = 5000,
                    PictureUrl = "/images/products/sb-reactrout.png",
                    Brand = "ReactJs",
                    Type = "React Boards",
                    QuantityInStock = 150
                },
                new Product
                {
                    Name = "HTML BOX item",
                    Description = "When you know how to use html, you have made a good choice",
                    Price = 34000,
                    PictureUrl = "/images/products/sb-html-1.png",
                    Brand = "HTML-Web",
                    Type = "Layout",
                    QuantityInStock = 5000
                },
                new Product
                {
                    Name = "Cascading Stylesheet or CSS",
                    Description = "There is not beauty of the web without stylesheet",
                    Price = 34000,
                    PictureUrl = "/images/products/sb-css.png",
                    Brand = "CSS",
                    Type = "Web styling",
                    QuantityInStock = 400
                }
                
            };
            context.Products.AddRange(products);

            //foreach (var product in products)
            //{
            //    context.Products.Add(product);
            //}
            context.SaveChanges();
        }
    }
}
