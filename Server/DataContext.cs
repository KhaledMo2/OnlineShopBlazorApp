using Microsoft.EntityFrameworkCore;
namespace OnlineShop.Server
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //Products
            //Beauty Category
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 1,
                Name = "Glossier - Beauty Kit",
                Description = "A kit provided by Glossier, containing skin care, hair care and makeup products",
                ImageURL = "https://glossier-prod.imgix.net/products/glossier-makeupset-carousel-01.png?auto=compress,format&cs=srgb&w=720",
                Price = 100,
                Qty = 100,
                CategoryId = 1

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 2,
                Name = "Curology - Skin Care Kit",
                Description = "A kit provided by Curology, containing skin care products",
                ImageURL = "https://images.ctfassets.net/mdcr7mahi0vp/5S6Fiuy439Ds6F6BZJD1ey/ce48c9098071b9d2e2fca10b7ce833a4/Curology-Products-at-Target.jpg?w=1200&h=700&fl=progressive&q=99&fm=jpg",
                Price = 50,
                Qty = 45,
                CategoryId = 1

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 3,
                Name = "Cocooil - Organic Coconut Oil",
                Description = "A kit provided by Curology, containing skin care products",
                ImageURL = "https://cdn.shopify.com/s/files/1/0534/8497/8336/products/cocooil-body-oil-685056_1000x1000.jpg?v=1615252544",
                Price = 20,
                Qty = 30,
                CategoryId = 1

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 4,
                Name = "Schwarzkopf - Hair Care and Skin Care Kit",
                Description = "A kit provided by Schwarzkopf, containing skin care and hair care products",
                ImageURL = "https://cdn.notinoimg.com/detail_main_mq/schwarzkopf-professional/4045787882247_01-o/schwarzkopf-professional-bc-bonacure-moisture-kick-set-i-fur-normales-bis-trockenes-haar-fur-damen_.jpg",
                Price = 50,
                Qty = 60,
                CategoryId = 1

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 5,
                Name = "Skin Care Kit",
                Description = "Skin Care Kit, containing skin care and hair care products",
                ImageURL = "https://u9p2d9z5.stackpathcdn.com/shop/media/catalog/product/cache/a5439cd2fd5f0af6ef1ac0cf86bb5fbc/b/r/brooklyn-soap-company-gesichtspflege-box.jpg",
                Price = 30,
                Qty = 85,
                CategoryId = 1

            });
            //Electronics Category
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 6,
                Name = "Air Pods",
                Description = "Air Pods - in-ear wireless headphones",
                ImageURL = "https://res.cloudinary.com/grover/image/upload/f_webp,q_auto/b_white,c_pad,dpr_2.0,h_500,w_520/f_auto,q_auto/v1635755348/txruwrmpwl1sqaplhcq3.png",
                Price = 100,
                Qty = 120,
                CategoryId = 3

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 7,
                Name = "On-ear Golden Headphones",
                Description = "On-ear Golden Headphones - these headphones are not wireless",
                ImageURL = "https://images.prolighting.de/imagesshop/webpL/PIHDJX5BTN.jpg",
                Price = 40,
                Qty = 200,
                CategoryId = 3

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 8,
                Name = "On-ear Black Headphones",
                Description = "On-ear Black Headphones - these headphones are not wireless",
                ImageURL = "https://i.ebayimg.com/images/g/B4AAAOSwxOFafO9B/s-l400.png",
                Price = 40,
                Qty = 300,
                CategoryId = 3

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 9,
                Name = "Sennheiser Digital Camera with Tripod",
                Description = "Sennheiser Digital Camera - High quality digital camera provided by Sennheiser - includes tripod",
                ImageURL = "https://cdn.shopify.com/s/files/1/0582/7218/6554/products/xs_lav_kit.jpg?v=1629419793",
                Price = 600,
                Qty = 20,
                CategoryId = 3

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 10,
                Name = "Canon Digital Camera",
                Description = "Canon Digital Camera - High quality digital camera provided by Canon",
                ImageURL = "https://m.media-amazon.com/images/I/81jsQHTHKmS._AC_UF1000,1000_QL80_.jpg",
                Price = 500,
                Qty = 15,
                CategoryId = 3

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 11,
                Name = "Nintendo Gameboy",
                Description = "Gameboy - Provided by Nintendo",
                ImageURL = "https://upload.wikimedia.org/wikipedia/commons/f/f4/Game-Boy-FL.jpg",
                Price = 100,
                Qty = 60,
                CategoryId = 3
            });
            //Furniture Category
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 12,
                Name = "Black Leather Office Chair",
                Description = "Very comfortable black leather office chair",
                ImageURL = "https://pictureserver.net/images/pic/08/ff/undef_src_sa_picid_343371_x_760_type_whitesh_image.jpg?ver=343",
                Price = 50,
                Qty = 212,
                CategoryId = 2
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 13,
                Name = "Pink Leather Office Chair",
                Description = "Very comfortable pink leather office chair",
                ImageURL = "https://www.orderofficefurniture.co.uk/media/catalog/product/cache/b9d908a4ed8da99de86c0645b2dab50b/a/0/a020_pink.jpg",
                Price = 50,
                Qty = 112,
                CategoryId = 2
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 14,
                Name = "Lounge Chair",
                Description = "Very comfortable lounge chair",
                ImageURL = "https://cdn.homedit.com/wp-content/uploads/2013/04/Lugo-Armless-Chaise-Lounge.jpg",
                Price = 70,
                Qty = 90,
                CategoryId = 2
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 15,
                Name = "Silver Lounge Chair",
                Description = "Very comfortable Silver lounge chair",
                ImageURL = "https://media.architecturaldigest.com/photos/5f160ad4baf7d8877d569924/master/w_320,c_limit/cozy-swivel-chair-o.jpg",
                Price = 120,
                Qty = 95,
                CategoryId = 2
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 16,
                Name = "Porcelain Table Lamp",
                Description = "White and blue Porcelain Table Lamp",
                ImageURL = "https://cdn.shopify.com/s/files/1/0802/8095/products/BM0463-TessaBlue_WhiteBirdTableLamp.jpg?v=1589936237g",
                Price = 15,
                Qty = 100,
                CategoryId = 2
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 17,
                Name = "Office Table Lamp",
                Description = "Office Table Lamp",
                ImageURL = "https://i.pinimg.com/originals/8c/e1/e1/8ce1e1d26d5b6d0450db65614cc01f8f.jpg",
                Price = 20,
                Qty = 73,
                CategoryId = 2
            });
            //Shoes Category
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 18,
                Name = "Puma Sneakers",
                Description = "Comfortable Puma Sneakers in most sizes",
                ImageURL = "https://images.puma.com/image/upload/f_auto,q_auto,b_rgb:fafafa,w_450,h_450/global/389862/01/sv01/fnd/EEA/fmt/png/Mayze-UT-Sneakers-Women",
                Price = 100,
                Qty = 50,
                CategoryId = 4
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 19,
                Name = "Colorful Trainers",
                Description = "Colorful trainsers - available in most sizes",
                ImageURL = "https://cdn.dribbble.com/users/43342/screenshots/12334381/media/38e229a39a72d799d8dc58e42c72e097.jpg?compress=1&resize=400x300",
                Price = 150,
                Qty = 60,
                CategoryId = 4
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 20,
                Name = "Blue Nike Trainers",
                Description = "Blue Nike Trainers - available in most sizes",
                ImageURL = "https://m.media-amazon.com/images/I/71pE7yNYMAL._AC_UY1000_.jpg",
                Price = 200,
                Qty = 70,
                CategoryId = 4
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 21,
                Name = "Colorful Hummel Trainers",
                Description = "Colorful Hummel Trainers - available in most sizes",
                ImageURL = "https://img01.ztat.net/article/spp-media-p1/d3cc2d2c038b40cc8dcc5ac41fb214c3/b98848ba665c457dbb2ec25093414553.jpg?imwidth=1800&filter=packshot",
                Price = 120,
                Qty = 120,
                CategoryId = 4
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 22,
                Name = "Red Nike Trainers",
                Description = "Red Nike Trainers - available in most sizes",
                ImageURL = "https://static.nike.com/a/images/c_limit,w_592,f_auto/t_product_v1/e8c0c1a8-8472-47d4-8b3f-33b069d29bb4/dunk-high-70-womens-shoes-RLwCTf.png",
                Price = 200,
                Qty = 100,
                CategoryId = 4
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 23,
                Name = "Birkenstock Sandles",
                Description = "Birkenstock Sandles - available in most sizes",
                ImageURL = "https://cdn.shopify.com/s/files/1/0411/5084/0988/articles/Blog_top_5_mens_birkenstock_sandals_image_1800x1200_a4cbdc2a-39d0-4740-a845-b369b5584611_2000x.jpg?v=1672378815",
                Price = 50,
                Qty = 150,
                CategoryId = 4
            });

            //Add users
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 1,
                UserName = "Bob",
                Password = "$2a$12$xOPOd1uBEGvlE3P.eRbQYOl72naoC8S2mmh852ZlbFBqCDrQoYi/G"

            });
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 2,
                UserName = "Sarah",
                Password = "$2a$12$GBMX2wioG4MFNiHOCD9dyua44uGfJ3TmaajPbhF9yfTzCn4SZLese"

            });

            //Create Shopping Cart for Users
            modelBuilder.Entity<Cart>().HasData(new Cart
            {
                Id = 1,
                UserId = 1

            });
            modelBuilder.Entity<Cart>().HasData(new Cart
            {
                Id = 2,
                UserId = 2

            });
            //Add Product Categories
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 1,
                Name = "Beauty",
                IconCSS = "fas fa-spa"
            });
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 2,
                Name = "Furniture",
                IconCSS = "fas fa-couch"
            });
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 3,
                Name = "Electronics",
                IconCSS = "fas fa-headphones"
            });
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 4,
                Name = "Shoes",
                IconCSS = "fas fa-shoe-prints"
            });


        }

        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
