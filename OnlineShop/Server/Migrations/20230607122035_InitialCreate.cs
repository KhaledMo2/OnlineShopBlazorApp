using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OnlineShop.Server.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CartId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Qty = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IconCSS = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Qty = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_ProductCategories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "ProductCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "Id", "UserId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "Id", "IconCSS", "Name" },
                values: new object[,]
                {
                    { 1, "fas fa-spa", "Beauty" },
                    { 2, "fas fa-couch", "Furniture" },
                    { 3, "fas fa-headphones", "Electronics" },
                    { 4, "fas fa-shoe-prints", "Shoes" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Password", "UserName" },
                values: new object[,]
                {
                    { 1, "$2a$12$xOPOd1uBEGvlE3P.eRbQYOl72naoC8S2mmh852ZlbFBqCDrQoYi/G", "Bob" },
                    { 2, "$2a$12$GBMX2wioG4MFNiHOCD9dyua44uGfJ3TmaajPbhF9yfTzCn4SZLese", "Sarah" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageURL", "Name", "Price", "Qty" },
                values: new object[,]
                {
                    { 1, 1, "A kit provided by Glossier, containing skin care, hair care and makeup products", "https://glossier-prod.imgix.net/products/glossier-makeupset-carousel-01.png?auto=compress,format&cs=srgb&w=720", "Glossier - Beauty Kit", 100m, 100 },
                    { 2, 1, "A kit provided by Curology, containing skin care products", "https://images.ctfassets.net/mdcr7mahi0vp/5S6Fiuy439Ds6F6BZJD1ey/ce48c9098071b9d2e2fca10b7ce833a4/Curology-Products-at-Target.jpg?w=1200&h=700&fl=progressive&q=99&fm=jpg", "Curology - Skin Care Kit", 50m, 45 },
                    { 3, 1, "A kit provided by Curology, containing skin care products", "https://cdn.shopify.com/s/files/1/0534/8497/8336/products/cocooil-body-oil-685056_1000x1000.jpg?v=1615252544", "Cocooil - Organic Coconut Oil", 20m, 30 },
                    { 4, 1, "A kit provided by Schwarzkopf, containing skin care and hair care products", "https://cdn.notinoimg.com/detail_main_mq/schwarzkopf-professional/4045787882247_01-o/schwarzkopf-professional-bc-bonacure-moisture-kick-set-i-fur-normales-bis-trockenes-haar-fur-damen_.jpg", "Schwarzkopf - Hair Care and Skin Care Kit", 50m, 60 },
                    { 5, 1, "Skin Care Kit, containing skin care and hair care products", "https://u9p2d9z5.stackpathcdn.com/shop/media/catalog/product/cache/a5439cd2fd5f0af6ef1ac0cf86bb5fbc/b/r/brooklyn-soap-company-gesichtspflege-box.jpg", "Skin Care Kit", 30m, 85 },
                    { 6, 3, "Air Pods - in-ear wireless headphones", "https://res.cloudinary.com/grover/image/upload/f_webp,q_auto/b_white,c_pad,dpr_2.0,h_500,w_520/f_auto,q_auto/v1635755348/txruwrmpwl1sqaplhcq3.png", "Air Pods", 100m, 120 },
                    { 7, 3, "On-ear Golden Headphones - these headphones are not wireless", "https://images.prolighting.de/imagesshop/webpL/PIHDJX5BTN.jpg", "On-ear Golden Headphones", 40m, 200 },
                    { 8, 3, "On-ear Black Headphones - these headphones are not wireless", "https://i.ebayimg.com/images/g/B4AAAOSwxOFafO9B/s-l400.png", "On-ear Black Headphones", 40m, 300 },
                    { 9, 3, "Sennheiser Digital Camera - High quality digital camera provided by Sennheiser - includes tripod", "https://cdn.shopify.com/s/files/1/0582/7218/6554/products/xs_lav_kit.jpg?v=1629419793", "Sennheiser Digital Camera with Tripod", 600m, 20 },
                    { 10, 3, "Canon Digital Camera - High quality digital camera provided by Canon", "https://m.media-amazon.com/images/I/81jsQHTHKmS._AC_UF1000,1000_QL80_.jpg", "Canon Digital Camera", 500m, 15 },
                    { 11, 3, "Gameboy - Provided by Nintendo", "https://upload.wikimedia.org/wikipedia/commons/f/f4/Game-Boy-FL.jpg", "Nintendo Gameboy", 100m, 60 },
                    { 12, 2, "Very comfortable black leather office chair", "https://pictureserver.net/images/pic/08/ff/undef_src_sa_picid_343371_x_760_type_whitesh_image.jpg?ver=343", "Black Leather Office Chair", 50m, 212 },
                    { 13, 2, "Very comfortable pink leather office chair", "https://www.orderofficefurniture.co.uk/media/catalog/product/cache/b9d908a4ed8da99de86c0645b2dab50b/a/0/a020_pink.jpg", "Pink Leather Office Chair", 50m, 112 },
                    { 14, 2, "Very comfortable lounge chair", "https://cdn.homedit.com/wp-content/uploads/2013/04/Lugo-Armless-Chaise-Lounge.jpg", "Lounge Chair", 70m, 90 },
                    { 15, 2, "Very comfortable Silver lounge chair", "https://media.architecturaldigest.com/photos/5f160ad4baf7d8877d569924/master/w_320,c_limit/cozy-swivel-chair-o.jpg", "Silver Lounge Chair", 120m, 95 },
                    { 16, 2, "White and blue Porcelain Table Lamp", "https://cdn.shopify.com/s/files/1/0802/8095/products/BM0463-TessaBlue_WhiteBirdTableLamp.jpg?v=1589936237g", "Porcelain Table Lamp", 15m, 100 },
                    { 17, 2, "Office Table Lamp", "https://i.pinimg.com/originals/8c/e1/e1/8ce1e1d26d5b6d0450db65614cc01f8f.jpg", "Office Table Lamp", 20m, 73 },
                    { 18, 4, "Comfortable Puma Sneakers in most sizes", "https://images.puma.com/image/upload/f_auto,q_auto,b_rgb:fafafa,w_450,h_450/global/389862/01/sv01/fnd/EEA/fmt/png/Mayze-UT-Sneakers-Women", "Puma Sneakers", 100m, 50 },
                    { 19, 4, "Colorful trainsers - available in most sizes", "https://cdn.dribbble.com/users/43342/screenshots/12334381/media/38e229a39a72d799d8dc58e42c72e097.jpg?compress=1&resize=400x300", "Colorful Trainers", 150m, 60 },
                    { 20, 4, "Blue Nike Trainers - available in most sizes", "https://m.media-amazon.com/images/I/71pE7yNYMAL._AC_UY1000_.jpg", "Blue Nike Trainers", 200m, 70 },
                    { 21, 4, "Colorful Hummel Trainers - available in most sizes", "https://img01.ztat.net/article/spp-media-p1/d3cc2d2c038b40cc8dcc5ac41fb214c3/b98848ba665c457dbb2ec25093414553.jpg?imwidth=1800&filter=packshot", "Colorful Hummel Trainers", 120m, 120 },
                    { 22, 4, "Red Nike Trainers - available in most sizes", "https://static.nike.com/a/images/c_limit,w_592,f_auto/t_product_v1/e8c0c1a8-8472-47d4-8b3f-33b069d29bb4/dunk-high-70-womens-shoes-RLwCTf.png", "Red Nike Trainers", 200m, 100 },
                    { 23, 4, "Birkenstock Sandles - available in most sizes", "https://cdn.shopify.com/s/files/1/0411/5084/0988/articles/Blog_top_5_mens_birkenstock_sandals_image_1800x1200_a4cbdc2a-39d0-4740-a845-b369b5584611_2000x.jpg?v=1672378815", "Birkenstock Sandles", 50m, 150 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartItems");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "ProductCategories");
        }
    }
}
