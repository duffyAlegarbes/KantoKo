using KantoCart.Web.Models;

namespace KantoCart.Web.Services;

public class MockProductService : IProductService
{
    private readonly List<Vendor> _vendors = new()
    {
        new Vendor
        {
            Id = "V-01",
            Name = "Manong Jun's Tusok-Tusok",
            Tagline = "Tapat ng Simbahan • Est. 2012",
            Type = VendorType.StreetFoodCart,
            Barangay = "Brgy. San Antonio",
            Rating = 4.9,
            TotalReviews = 412,
            EstimatedPrepTime = "5-10 mins",
            IsSukiVerified = true
        },
        new Vendor
        {
            Id = "V-02",
            Name = "Aling Tess Carinderia",
            Tagline = "Mainit na Ulam araw-araw",
            Type = VendorType.Carinderia,
            Barangay = "Brgy. San Antonio",
            Rating = 4.8,
            TotalReviews = 328,
            EstimatedPrepTime = "10-15 mins",
            IsSukiVerified = true
        },
        new Vendor
        {
            Id = "V-03",
            Name = "Nanay Bebeng Sari-Sari Store",
            Tagline = "Kumpleto sa Kusina at Bahay",
            Type = VendorType.SariSariStore,
            Barangay = "Brgy. San Antonio",
            Rating = 4.95,
            TotalReviews = 560,
            EstimatedPrepTime = "5 mins",
            IsSukiVerified = true
        }
    };

    private readonly List<ProductItem> _products = new()
    {
        // ==================== TUSOK-TUSOK (STREET FOOD) ====================
        new ProductItem
        {
            Id = "TUSOK-01",
            Name = "Golden Crispy Kwek-Kwek",
            LocalName = "Tokneneng / Kwek-Kwek",
            Description = "Crispy orange batter coated hard-boiled quail eggs, deep-fried to golden perfection. Served with spicy cucumber vinegar and sweet brown sauce.",
            Price = 45.00m,
            OriginalPrice = 55.00m,
            Category = ProductCategory.TusokTusok,
            ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTtLTbxsnT60Wv0BNS4hta0gAmqNe9T6R5pzoTUy0ZORA&s=10",
            VendorId = "V-01",
            VendorName = "Manong Jun's Tusok-Tusok",
            UnitDisplay = "8 pcs per cup",
            BadgeText = "BESTSELLER",
            AvailableSauces = new() { "Sweet Manong Sauce", "Spicy Pinoy Suka", "Mix (Sweet & Spicy)" }
        },
        new ProductItem
        {
            Id = "TUSOK-02",
            Name = "Charcoal Inihaw na Isaw ng Baboy",
            LocalName = "Pork Isaw Skewers",
            Description = "Freshly cleaned and marinated pork intestines, grilled over charcoal embers and glazed with sweet barbecue sauce.",
            Price = 80.00m,
            OriginalPrice = 95.00m,
            Category = ProductCategory.TusokTusok,
            ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSoN_oteIzUwneADVKDwewaGt8fYsV3u1B8AL-veC6GUA&s=10",
            VendorId = "V-01",
            VendorName = "Manong Jun's Tusok-Tusok",
            UnitDisplay = "5 sticks",
            BadgeText = "BAGONG INIHAW",
            AvailableSauces = new() { "Spicy Sinamak Suka", "Sweet BBQ Dip", "Pinoy Spicy Toyo-Mansi" }
        },
        new ProductItem
        {
            Id = "TUSOK-03",
            Name = "Crispy Fishball & Kikiam Bucket",
            LocalName = "Fishball at Kikiam Combo",
            Description = "Street-style flat fishballs and savory Chinese kikiam deep-fried crunchy on the outside, dipped in thick brown sauce.",
            Price = 50.00m,
            OriginalPrice = null,
            Category = ProductCategory.TusokTusok,
            ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSr4m9oJITL7BP831d_lwo7nwzNZzgvPvUqGZhcRq7TOQ&s=10",
            VendorId = "V-01",
            VendorName = "Manong Jun's Tusok-Tusok",
            UnitDisplay = "20 pcs mixed",
            BadgeText = "STREET CLASSIC",
            AvailableSauces = new() { "Manong's Brown Sauce", "Spicy Suka" }
        },
        new ProductItem
        {
            Id = "TUSOK-04",
            Name = "Inihaw na Betamax (Pork Blood)",
            LocalName = "Betamax Sticks",
            Description = "Solidified pork blood cubes marinated in garlic and calamansi, grilled tender and smoky on bamboo skewers.",
            Price = 60.00m,
            OriginalPrice = null,
            Category = ProductCategory.TusokTusok,
            ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRIx08FfUlmsH-ddS8xAxxszqRcTfODd1ALyoboDa2fkg&s=10",
            VendorId = "V-01",
            VendorName = "Manong Jun's Tusok-Tusok",
            UnitDisplay = "5 sticks",
            BadgeText = "KANTO FAVORITE",
            AvailableSauces = new() { "Spicy Vinegar Dip" }
        },

        // ==================== CARINDERIA ULAM ====================
        new ProductItem
        {
            Id = "CARIN-01",
            Name = "Classic Pork Belly Adobo",
            LocalName = "Adobong Baboy sa Toyo't Suka",
            Description = "Tender pork belly slow-braised in cane vinegar, soy sauce, garlic, and bay leaves until savory and rich.",
            Price = 120.00m,
            OriginalPrice = 140.00m,
            Category = ProductCategory.CarinderiaUlam,
            ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSy3Zt4x50RtWGhWsIGk3vcdxhlCbO5YDHNPVUnidNEXw&s=10",
            VendorId = "V-02",
            VendorName = "Aling Tess Carinderia",
            UnitDisplay = "1 full serving",
            BadgeText = "LUTONG BAHAY",
            AvailableSauces = new() { "Extra Adobo Sauce" }
        },
        new ProductItem
        {
            Id = "CARIN-02",
            Name = "Sizzling Crispy Pork Sisig",
            LocalName = "Pork Sisig w/ Egg & Calamansi",
            Description = "Minced crispy pork mask and belly seasoned with onions, chili peppers, chicken liver, topped with fresh egg and calamansi.",
            Price = 135.00m,
            OriginalPrice = 160.00m,
            Category = ProductCategory.CarinderiaUlam,
            ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTpkeWbIFyeU6kYw97wMhta9xqcn_OauIcLJu291zIchA&s=10",
            VendorId = "V-02",
            VendorName = "Aling Tess Carinderia",
            UnitDisplay = "1 sizzling plate",
            BadgeText = "SUKI NUMBER 1",
            AvailableSauces = new() { "Spicy Siling Labuyo", "Mayonnaise Drizzle" }
        },
        new ProductItem
        {
            Id = "CARIN-03",
            Name = "Sinigang na Baboy sa Sampalok",
            LocalName = "Pork Sinigang Soup",
            Description = "Pork ribs simmered in a sour tamarind broth with kangkong, radish, string beans, and green finger chilis.",
            Price = 130.00m,
            OriginalPrice = null,
            Category = ProductCategory.CarinderiaUlam,
            ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR2MpB4WOK8ppFXkPZlSdqdXfVQzrHWWuTOYSA4GQvtfw&s=10",
            VendorId = "V-02",
            VendorName = "Aling Tess Carinderia",
            UnitDisplay = "1 big bowl",
            BadgeText = "MAINIT NA SABAW",
            AvailableSauces = new() { "Patis with Sili" }
        },
        new ProductItem
        {
            Id = "CARIN-04",
            Name = "Spicy Bicol Express sa Gata",
            LocalName = "Bicol Express",
            Description = "Pork chunks cooked in rich coconut cream with bagoong alamang (shrimp paste) and generous green chilis.",
            Price = 125.00m,
            OriginalPrice = null,
            Category = ProductCategory.CarinderiaUlam,
            ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT3VZnv2nPkuaJNx9uwoQrzzFN4Etc8Bobu-PnE-yY0Pg&s=10",
            VendorId = "V-02",
            VendorName = "Aling Tess Carinderia",
            UnitDisplay = "1 full serving",
            BadgeText = "MAANGHANG",
            AvailableSauces = new() { "Extra Gata Sauce" }
        },

        // ==================== MERIENDA & PALAMIG ====================
        new ProductItem
        {
            Id = "MER-01",
            Name = "Special Halo-Halo Overload",
            LocalName = "Halo-Halo Espesyal",
            Description = "Finely crushed ice, sweet ube halaya, rich leche flan, nata de coco, sweetened saba, sago, topped with evaporated milk.",
            Price = 85.00m,
            OriginalPrice = 100.00m,
            Category = ProductCategory.MeriendaPalamig,
            ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSYVvFlC3nWhgpF9XdaAwWsqupyc-9pt9xm3M8qV3DuWw&s=10",
            VendorId = "V-02",
            VendorName = "Aling Tess Carinderia",
            UnitDisplay = "1 tall 16oz cup",
            BadgeText = "PANALONG LAMIG",
            AvailableSauces = new() { "Extra Leche Flan (+₱20)", "Regular" }
        },
        new ProductItem
        {
            Id = "MER-02",
            Name = "Crispy Golden Turon na may Langka",
            LocalName = "Turon w/ Sweet Jackfruit",
            Description = "Sweet Saba banana wrapped in spring roll pastry with jackfruit slivers, rolled in brown sugar, fried crisp and glazed.",
            Price = 35.00m,
            OriginalPrice = null,
            Category = ProductCategory.MeriendaPalamig,
            ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTU_nUFtxooSkh0w8kuxZB01DuGRfVYs97nT3Z5VcF_Ug&s=10",
            VendorId = "V-01",
            VendorName = "Manong Jun's Tusok-Tusok",
            UnitDisplay = "2 jumbo rolls",
            BadgeText = "BAGONG PRITO",
            AvailableSauces = new() { "Caramel Drizzle" }
        },
        new ProductItem
        {
            Id = "MER-03",
            Name = "Sago't Gulaman Palamig Jar",
            LocalName = "Brown Sugar Gulaman Cooler",
            Description = "Traditional iced brown sugar syrup infused with vanilla, chewy tapioca pearls, and tender grass jelly cubes.",
            Price = 30.00m,
            OriginalPrice = 40.00m,
            Category = ProductCategory.MeriendaPalamig,
            ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTaCXoKHWN6bY61R0jhFs0iYrtr8Epbf9e2xd84g9WkVQ&s=10",
            VendorId = "V-01",
            VendorName = "Manong Jun's Tusok-Tusok",
            UnitDisplay = "1 large cup (22oz)",
            BadgeText = "PAMPAWI UHAW",
            AvailableSauces = new() { "Regular Sweetness", "Less Sweet" }
        },
        new ProductItem
        {
            Id = "MER-04",
            Name = "Crispy Lumpiang Togue",
            LocalName = "Fried Bean Sprout Spring Rolls",
            Description = "Fried spring rolls stuffed with sautéed bean sprouts, carrots, and tofu. Best enjoyed with spicy garlic vinegar.",
            Price = 35.00m,
            OriginalPrice = null,
            Category = ProductCategory.MeriendaPalamig,
            ImageUrl = "https://media.istockphoto.com/id/1311559425/photo/freshly-cooked-filipino-food-called-lumpiang-shanghai.jpg?s=2048x2048&w=is&k=20&c=PsVh9q1Cem0TfGnvFLIa0ncY_-ZtYxIyyY7nS1jTJTo=",
            VendorId = "V-01",
            VendorName = "Manong Jun's Tusok-Tusok",
            UnitDisplay = "3 pcs per pack",
            BadgeText = "CRUNCHY",
            AvailableSauces = new() { "Spicy Sukang Paombong" }
        },

        // ==================== SARI-SARI DAILY PANTRY ====================
        new ProductItem
        {
            Id = "SARI-01",
            Name = "Pang-Gisa Essentials Bundle",
            LocalName = "Toyo, Suka, Sardinas at Bawang",
            Description = "1 Datu Puti Suka (350ml), 1 Datu Puti Toyo (350ml), 1 can Mega Sardines Red, and 1 whole head of garlic.",
            Price = 115.00m,
            OriginalPrice = 135.00m,
            Category = ProductCategory.SariSariDaily,
            ImageUrl = "https://images.unsplash.com/photo-1584473457406-6240486418e9?auto=format&fit=crop&w=700&q=80",
            VendorId = "V-03",
            VendorName = "Nanay Bebeng Sari-Sari Store",
            UnitDisplay = "4 items bundle",
            BadgeText = "TIPID PACK",
            AvailableSauces = new() { "Standard Pack" }
        },
        new ProductItem
        {
            Id = "SARI-02",
            Name = "Midnight Pancit Canton + Itlog Pack",
            LocalName = "2 Canton Chilimansi + 2 Fresh Eggs",
            Description = "2 packs Lucky Me! Pancit Canton Chilimansi + 2 fresh farm eggs for the ultimate midnight merienda.",
            Price = 58.00m,
            OriginalPrice = 68.00m,
            Category = ProductCategory.SariSariDaily,
            ImageUrl = "https://images.unsplash.com/photo-1612927601601-6638404737ce?auto=format&fit=crop&w=700&q=80",
            VendorId = "V-03",
            VendorName = "Nanay Bebeng Sari-Sari Store",
            UnitDisplay = "Bundle (2 noodles + 2 eggs)",
            BadgeText = "MIDNIGHT SAVER",
            AvailableSauces = new() { "Chilimansi", "Original", "Extra Hot" }
        },
        new ProductItem
        {
            Id = "SARI-03",
            Name = "Bigas Dinorado Premium (2kg)",
            LocalName = "Mabangong Kanin Dinorado",
            Description = "Premium soft and aromatic Dinorado white rice from Isabela. Malambot at masarap ipares sa ulam.",
            Price = 118.00m,
            OriginalPrice = 125.00m,
            Category = ProductCategory.SariSariDaily,
            ImageUrl = "https://images.unsplash.com/photo-1586201375761-83865001e31c?auto=format&fit=crop&w=700&q=80",
            VendorId = "V-03",
            VendorName = "Nanay Bebeng Sari-Sari Store",
            UnitDisplay = "2 kilograms",
            BadgeText = "BAGONG ANI",
            AvailableSauces = new() { "Standard Sack" }
        },
        new ProductItem
        {
            Id = "SARI-04",
            Name = "Sari-Sari Chichirya Snack Box",
            LocalName = "Piattos, Nova, Chippy & V-Cut Bundle",
            Description = "Assorted neighborhood snack pack: 1 Piattos Cheese, 1 Nova Country Cheddar, 1 Chippy BBQ, 1 V-Cut BBQ.",
            Price = 88.00m,
            OriginalPrice = 100.00m,
            Category = ProductCategory.SariSariDaily,
            ImageUrl = "https://images.unsplash.com/photo-1566478989037-eec170784d0b?auto=format&fit=crop&w=700&q=80",
            VendorId = "V-03",
            VendorName = "Nanay Bebeng Sari-Sari Store",
            UnitDisplay = "4 big snacks",
            BadgeText = "PANG-BARKADA",
            AvailableSauces = new() { "Assorted Flavors" }
        }
    };

    public Task<List<ProductItem>> GetFeaturedProductsAsync() =>
        Task.FromResult(_products);

    public Task<List<ProductItem>> GetProductsByCategoryAsync(ProductCategory category) =>
        Task.FromResult(_products.Where(p => p.Category == category).ToList());

    public Task<ProductItem?> GetProductByIdAsync(string id) =>
        Task.FromResult(_products.FirstOrDefault(p => p.Id == id));

    public Task<List<Vendor>> GetFeaturedVendorsAsync() =>
        Task.FromResult(_vendors);
}