using Marten.Schema;

namespace Catalog.API.Data;

public class CatalogInitialData : IInitialData
{
    public async Task Populate(IDocumentStore store, CancellationToken cancellation)
    {
        using var session = store.LightweightSession();

        if (await session.Query<Product>().AnyAsync())
            return;

        session.Store(GetPreconfiguredProducts());
        await session.SaveChangesAsync();

    }

    private static IEnumerable<Product> GetPreconfiguredProducts() =>
    [
        new Product {
            Id = Guid.NewGuid(),
            Name = "Wireless Mouse",
            Category = ["Electronics", "Accessories"],
            Description = "A high-precision wireless mouse with long battery life.",
            ImageFile = "wireless_mouse.jpg",
            Price = 29.99m
        },
        new Product
        {
            Id = Guid.NewGuid(),
            Name = "Laptop Stand",
            Category = ["Office Supplies", "Accessories"],
            Description = "An ergonomic laptop stand for better posture.",
            ImageFile = "laptop_stand.jpg",
            Price = 34.99m
        },
        new Product
        {
            Id = Guid.NewGuid(),
            Name = "Noise-Cancelling Headphones",
            Category = ["Electronics", "Audio"],
            Description = "Premium headphones with active noise cancellation.",
            ImageFile = "headphones.jpg",
            Price = 199.99m
        },
        new Product
        {
            Id = Guid.NewGuid(),
            Name = "Smart Watch",
            Category = ["Electronics", "Wearables"],
            Description = "A smart watch with fitness tracking and notifications.",
            ImageFile = "smart_watch.jpg",
            Price = 149.99m
        },
        new Product
        {
            Id = Guid.NewGuid(),
            Name = "Portable Charger",
            Category = ["Electronics", "Accessories"],
            Description = "A high-capacity portable charger for on-the-go charging.",
            ImageFile = "portable_charger.jpg",
            Price = 49.99m
        },
        new Product
        {
            Id = Guid.NewGuid(),
            Name = "Office Chair",
            Category = ["Office Supplies", "Furniture"],
            Description = "An ergonomic office chair with adjustable height and lumbar support.",
            ImageFile = "office_chair.jpg",
            Price = 249.99m
        },
        new Product
        {
            Id = Guid.NewGuid(),
            Name = "Desk Lamp",
            Category = ["Office Supplies", "Lighting"],
            Description = "A modern desk lamp with adjustable brightness and color temperature.",
            ImageFile = "desk_lamp.jpg",
            Price = 29.99m
        },
        new Product
        {
            Id = Guid.NewGuid(),
            Name = "Bluetooth Speaker",
            Category = ["Electronics", "Audio"],
            Description = "A portable Bluetooth speaker with powerful sound.",
            ImageFile = "bluetooth_speaker.jpg",
            Price = 79.99m
        },
        new Product
        {
            Id = Guid.NewGuid(),
            Name = "External Hard Drive",
            Category = ["Electronics", "Storage"],
            Description = "A high-capacity external hard drive for data backup.",
            ImageFile = "external_hard_drive.jpg",
            Price = 99.99m
        },
        new Product
        {
            Id = Guid.NewGuid(),
            Name = "Gaming Keyboard",
            Category = ["Electronics", "Gaming"],
            Description = "A mechanical gaming keyboard with RGB backlighting.",
            ImageFile = "gaming_keyboard.jpg",
            Price = 129.99m
        }
    ];
}
