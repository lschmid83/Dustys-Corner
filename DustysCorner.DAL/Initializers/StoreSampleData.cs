using DustysCorner.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DustysCorner.DAL.Initializers
{
    public static class StoreSampleData
    {
        public static List<Product> GetProducts(StoreContext context)
        {
            // Sculptures.
            var categoryId = context.Category.Where(x => x.Name == "Sculptures" && x.Route == "Shop").FirstOrDefault().Id;
            var sculptures = new List<Product>() {
                new Product {
                    Name = "Movie Head 1",
                    Description = "<p>Resin cast appox 25mm tall.</p>" +
                    "<p>Supplied unpainted.</p>",
                    Image = "HENRIKSEN15.JPG",
                    Thumbnail = "HENRIKSEN15.JPG",
                    AdditionalImages = new List<ProductImage>()
                    {
                        new ProductImage { Name = "HENRIKSEN16.JPG" },
                        new ProductImage { Name = "HENRIKSEN18.JPG" }
                    },
                    Price = 3m,
                    Discount = 10,
                    CategoryId = categoryId
                },
                new Product {
                    Name = "Movie Head 2",
                    Description = "<p>Resin cast appox 25mm tall.</p>" +
                    "<p>Supplied unpainted.</p>",
                    Image = "SEAGAL16.JPG",
                    Thumbnail = "SEAGAL16.JPG",
                    AdditionalImages = new List<ProductImage>()
                    {
                        new ProductImage { Name = "SEAGAL15.JPG" },
                        new ProductImage { Name = "SEAGAL18.JPG" }
                    },
                    Price = 3m,
                    CategoryId = categoryId
                },
                new Product {
                    Name = "Skull 15mm",
                    Description = "<p>Cast in resin.</p>" +
                    "<p>Supplied unpainted.</p>",
                    Image = "SKULLPAINTED.JPG",
                    Thumbnail = "SKULLPAINTED.JPG",
                    AdditionalImages = new List<ProductImage>()
                    {
                        new ProductImage { Name = "SKULLRESIN.JPG" }
                    },
                    Price = 3m,
                    CategoryId = categoryId
                },
                new Product {
                    Name = "Zombie 1",
                    Description = "<p>This simple zombie is just that. It's a basic design for sequents to follow. Converting for model makers should be fairly striaght forward.</p>" +
                    "<p>Supplied unassembled / unpainted. Requires glue. Pinning will help secure parts.</p>" +
                    "<p>Comes with 25mm round base.</p>" +
                    "<p>Washing parts to remove residue before assembly is recommend!</p>",
                    Image = "ZOMBIE1.JPG",
                    Thumbnail = "ZOMBIE1.JPG",
                    AdditionalImages = new List<ProductImage>()
                    {
                        new ProductImage { Name = "ZOMBIE4.JPG" }
                    },
                    Price = 5m,
                    CategoryId = categoryId
                },
                new Product {
                    Name = "Zombie 2",
                    Description = "<p>Cast in resin.</p>" +
                    "<p>Supplied unpainted.</p>",
                    Image = "ZOMBIE2.JPG",
                    Thumbnail = "ZOMBIE2.JPG",
                    AdditionalImages = new List<ProductImage>()
                    {
                        new ProductImage { Name = "ZOMBIE22.JPG" },
                    },
                    Price = 8m,
                    LimitedStock = true,
                    CategoryId = categoryId
                }
            };

            // Bases.
            categoryId = context.Category.Where(x => x.Name == "Bases" && x.Route == "Shop").FirstOrDefault().Id;
            var bases = new List<Product>() {
                new Product {
                    Name = "Grass",
                    Description = "<p>25mm Round basic grass base. 5xbases supplied.</p>" +
                    "<p>Requires sanding & painting.</p>",
                    Image = "BASEGRASS.JPG",
                    Thumbnail = "BASEGRASS.JPG",
                    Price = 1m,
                    CategoryId = categoryId
                },
                new Product {
                    Name = "Cracked Stone",
                    Description = "<p>25mm Round basic grass base. 5xbases supplied.</p>" +
                    "<p>Requires sanding & painting.</p>",
                    Image = "BASECRACKEDSTONE.JPG",
                    Thumbnail = "BASECRACKEDSTONE.JPG",
                    Price = 1m,
                    CategoryId = categoryId
                },
                new Product {
                    Name = "Industrial",
                    Description = "<p>25mm Round basic grass base. 5xbases supplied.</p>" +
                    "<p>Requires sanding & painting.</p>",
                    Image = "BASEINDUSTRIAL.JPG",
                    Thumbnail = "BASEINDUSTRIAL.JPG",
                    Price = 1m,
                    CategoryId = categoryId
                },
                new Product {
                    Name = "Disco",
                    Description = "<p>25mm Round basic grass base. 5xbases supplied.</p>" +
                    "<p>Requires sanding & painting.</p>",
                    Image = "BASEDISCO.JPG",
                    Thumbnail = "BASEDISCO.JPG",
                    Price = 1m,
                    CategoryId = categoryId
                },
                new Product {
                    Name = "Moon Surface",
                    Description = "<p>25mm Round basic grass base. 5xbases supplied.</p>" +
                    "<p>Requires sanding & painting.</p>",
                    Image = "BASEMOON.JPG",
                    Thumbnail = "BASEMOON.JPG",
                    Price = 1m,
                    CategoryId = categoryId
                },
            };

            categoryId = context.Category.Where(x => x.Name == "Jewellery" && x.Route == "Shop").FirstOrDefault().Id;
            var jewellery = new List<Product>() {
                new Product {
                    Name = "Skull Earrings",
                    Description = "<p>Handcrafted, handpainted, sculpted by Dusty</p>" +
                    "<p>Comes as a pair and available in colours - Natural, Green, Blue, Red, Purple</p>",
                    Image = "EARRINGSKULLSET1.JPG",
                    Thumbnail = "EARRINGSKULLSET1.JPG",
                    AdditionalImages = new List<ProductImage>()
                    {
                        new ProductImage { Name = "EARRINGSKULLSET5.JPG" },
                        new ProductImage { Name = "EARRINGSKULLSET6.JPG" }
                    },
                    Price = 5m,
                    CategoryId = categoryId
                },
                new Product {
                    Name = "Skull (OpenJaw) Earrings",
                    Description = "<p>Handcrafted, handpainted, sculpted by Dusty.</p>" +
                    "<p>Comes as a pair.</p>",
                    Image = "EARRINGSKULLSET7.JPG",
                    Thumbnail = "EARRINGSKULLSET7.JPG",
                    AdditionalImages = new List<ProductImage>()
                    {
                        new ProductImage { Name = "EARRINGSKULLSET8.JPG" }
                    },
                    Price = 6m,
                    CategoryId = categoryId,
                    Options = new List<ProductOption>
                    {
                        new ProductOption() { Name = "Natural" },
                        new ProductOption() { Name = "Green" },
                        new ProductOption() { Name = "Purple" },
                        new ProductOption() { Name = "Red" },
                        new ProductOption() { Name = "Blue" }
                    }
                },
                new Product {
                    Name = "Dangley Skull",
                    Description = "<p>Resin skull, handpainted, on a loop cord.</p>" +
                    "<p>Other colours available.</p>" +
                    "<p>Hang it from; Phones, xmas trees, bags/ zips, wallets / keyrings...etc</p>" +
                    "<p>Keep outta reach of kids,  choking hazard!</p>",
                    Image = "SKULLDANGLEY.JPG",
                    Thumbnail = "SKULLDANGLEY.JPG",                   
                    Price = 8m,
                    Discount = 15,
                    CategoryId = categoryId
                },
                new Product {
                    Name = "Desktop Skull",
                    Description = "<p>Painted resin orniment. Nice for sitting on desktops, dashboards etc.</p>" +
                    "<p>Add an LED to make it glow!</p>",
                    Image = "SKULL&BASE.JPG",
                    Thumbnail = "SKULL&BASE.JPG",
                    Price = 4m,
                    CategoryId = categoryId
                },
                new Product {
                    Name = "Smilies Earrings",
                    Description = "<p>Be happy, be smiley :)</p>",
                    Image = "SMILIESEARRING.JPG",
                    Thumbnail = "SMILIESEARRING.JPG",
                    AdditionalImages = new List<ProductImage>()
                    {
                        new ProductImage { Name = "SMILIESEARRING2.JPG" },
                    },
                    Price = 4m,
                    CategoryId = categoryId
                },
                new Product {
                    Name = "Smilies Bracelet",
                    Description = "<p>Be happy with this smilies bracelet!</p>",
                    Image = "SMILIESBRACELET.JPG",
                    Thumbnail = "SMILIESBRACELET.JPG",
                    Price = 4m,
                    CategoryId = categoryId
                },
            };


            var products = new List<Product>();
            products.AddRange(sculptures);
            products.AddRange(bases);
            products.AddRange(jewellery);

            int order = 1;
            int imgOrder = 1;
            foreach (var item in products)
            {
                if (item.AdditionalImages != null)
                {
                    foreach (var img in item.AdditionalImages)
                    {
                        img.Order = imgOrder;
                        imgOrder++;
                    }
                }
                imgOrder = 1;
                order++;
            }

            order = 1;
            int optionOrder = 1;
            foreach (var item in products)
            {
                if (item.Options != null)
                {
                    foreach (var option in item.Options)
                    {
                        option.Order = optionOrder;
                        optionOrder++;
                    }
                }
                optionOrder = 1;
                order++;
            }


            return products;
        }

        public static List<FeaturedProduct> GetFeaturedProducts(StoreContext context)
        {
            var featuredProducts = new List<FeaturedProduct>() {
                new FeaturedProduct {
                   ProductId = context.Product.Where(x => x.Name == "Movie Head 1").FirstOrDefault().Id,
                   Order = 1
                },
                new FeaturedProduct {
                   ProductId = context.Product.Where(x => x.Name == "Movie Head 2").FirstOrDefault().Id,
                   Order = 2
                },
                new FeaturedProduct {
                   ProductId = context.Product.Where(x => x.Name == "Skull 15mm").FirstOrDefault().Id,
                   Order = 3
                },
                new FeaturedProduct {
                   ProductId = context.Product.Where(x => x.Name == "Zombie 1").FirstOrDefault().Id,
                   Order = 4
                },
                new FeaturedProduct {
                   ProductId = context.Product.Where(x => x.Name == "Zombie 2").FirstOrDefault().Id,
                   Order = 5
                },
                new FeaturedProduct {
                   ProductId = context.Product.Where(x => x.Name == "Dangley Skull").FirstOrDefault().Id,
                   Order = 6
                }
            };
            return featuredProducts;
        }

        public static Event GetEvent()
        {
            var startDate = new DateTime(DateTime.Now.Year, 5, 29);
            if (DateTime.Now > startDate)
                startDate = new DateTime(DateTime.Now.Year + 1, 5, 29);
            return new Event()
            {
                Name = "UK Games Expo",
                Image = "/images/event.png",
                StartDate = startDate,
                EndDate = startDate.AddDays(2),
                Location = "NEC Birmingham",
                Url = "http://www.ukgamesexpo.co.uk/tickets.php",
                Twitter = "https://twitter.com/UKGamesExpo?ref_src=twsrc%5Egoogle%7Ctwcamp%5Eserp%7Ctwgr%5Eauthor"
            };
        }

        public static List<Review> GetReviews()
        {
            return new List<Review>() {
                new Review {
                    Name = "Chris Olesen",
                    Image = "/images/review-1.png",
                    Text =  "I went to Dusty's Corner after previously ordering some awesome scale models. " +
                    "I needed a background which could be displayed behind a model for a exhibition. " +
                    "The finished backdrop was a masterpiece."
                },
                new Review {
                    Name = "Maria Forbes",
                    Image = "/images/review-2.png",
                    Text =  "I love the new website design! I build miniature models as a hobby and have " +
                    "found this to be one of the better website to visit for customer support and tutorials " +
                    "on how to build and finish my models for display purposes."
                },
                new Review {
                    Name = "Suzzane Langen",
                    Image = "/images/review-3.png",
                    Text =  "I decided to order some custom scale models to go with my existing collection. " +
                    "The range of products available and the fact that I could communicate with the owner " +
                    "through email and oversee the design process really helped."
                }
            };
        }

        public static List<Category> GetCategories() => new List<Category>
        {
            new Category { Name = "Home", Order = 1, Route = string.Empty },
            new Category { Name = "Gallery", Order = 2, Route = "Gallery" },
                new Category { Name = "Sculptures", ParentId = 2, Order = 1, Route = "Gallery" },
                new Category { Name = "Models", ParentId = 2, Order = 2, Route = "Gallery" },
                new Category { Name = "Architectural", ParentId = 2, Order = 3, Route = "Gallery" },
                new Category { Name = "Sketches", ParentId = 2, Order = 4, Route = "Gallery" },
            new Category { Name = "Shop", Order = 3, Route = "Shop" },
                new Category { Name = "Sculptures", ParentId =7, Order = 1, Route = "Shop" },
                new Category { Name = "Bases", ParentId = 7, Order = 2, Route = "Shop" },
                new Category { Name = "Jewellery", ParentId = 7, Order = 3, Route = "Shop" },
            new Category { Name = "Contact", Order = 4, Route = "Contact" },
        };

        public static List<Gallery> GetGallery(StoreContext context)
        {
            // Sculptures.
            var categoryId = context.Category.Where(x=> x.Name == "Sculptures" && x.Route == "Gallery").FirstOrDefault().Id;
            var sculptures = new List<Gallery>() {
                new Gallery {
                    Name = "Zombie Bust",
                    Image = "zombiebustpainted1.jpg",
                    AdditionalImages = new List<GalleryImage>()
                    {
                        new GalleryImage { Name = "zombiebustpainted2.jpg" },
                        new GalleryImage { Name = "zombiebustpainted3.jpg" },
                        new GalleryImage { Name = "zombiebustpainted4.jpg" },
                        new GalleryImage { Name = "zombiebustpainted5.jpg" },
                        new GalleryImage { Name = "zombiebustpainted6.jpg" },
                        new GalleryImage { Name = "zombiebustpainted7.jpg" },
                        new GalleryImage { Name = "zombiebustpainted8.jpg" },
                    },
                    CategoryId = categoryId
                },
                new Gallery {
                    Name = "Henriksen",
                    Image = "Henriksen1.jpg",
                    AdditionalImages = new List<GalleryImage>()
                    {
                        new GalleryImage { Name = "Henriksen2.jpg" },
                        new GalleryImage { Name = "Henriksen3.jpg" },
                        new GalleryImage { Name = "Henriksen4.jpg" },
                        new GalleryImage { Name = "Henriksen5.jpg" },
                        new GalleryImage { Name = "Henriksen6.jpg" },
                        new GalleryImage { Name = "Henriksen7.jpg" },
                        new GalleryImage { Name = "Henriksen8.jpg" },
                        new GalleryImage { Name = "Henriksen9.jpg" },
                        new GalleryImage { Name = "Henriksen10.jpg" },
                        new GalleryImage { Name = "Henriksen11.jpg" },
                        new GalleryImage { Name = "Henriksen15.jpg" },
                        new GalleryImage { Name = "Henriksen16.jpg" },
                        new GalleryImage { Name = "Henriksen17.jpg" },
                        new GalleryImage { Name = "Henriksen18.jpg" },
                        new GalleryImage { Name = "Henriksen19.jpg" }
                    },
                    CategoryId = categoryId
                },
                new Gallery {
                    Name = "Seagal",
                    Image = "Seagal8.jpg",
                    AdditionalImages = new List<GalleryImage>()
                    {
                        new GalleryImage { Name = "Seagal9.jpg" },
                        new GalleryImage { Name = "Seagal10.jpg" },
                        new GalleryImage { Name = "Seagal15.jpg" },
                        new GalleryImage { Name = "Seagal16.jpg" },
                        new GalleryImage { Name = "seagal17.jpg" },
                        new GalleryImage { Name = "seagal18.jpg" }
                    },
                    CategoryId = categoryId
                },
                new Gallery {
                    Name = "Brain",
                    Image = "BrainPainted1.jpg",
                    AdditionalImages = new List<GalleryImage>()
                    {
                        new GalleryImage { Name = "BrainPainted2.jpg" },
                        new GalleryImage { Name = "BrainPainted3.jpg" },
                        new GalleryImage { Name = "BrainPainted4.jpg" }
                    },
                    CategoryId = categoryId
                },
                new Gallery {
                    Name = "Open Mouth Skull",
                    Image = "SkullOpenMouth1.jpg",
                    AdditionalImages = new List<GalleryImage>()
                    {
                        new GalleryImage { Name = "SkullOpenMouth2.jpg" },
                        new GalleryImage { Name = "SkullOpenMouth3.jpg" },
                        new GalleryImage { Name = "SkullOpenMouth5.jpg" },
                        new GalleryImage { Name = "SkullSplitJaw3.jpg" }
                    },
                    CategoryId = categoryId,
                },
                new Gallery {
                    Name = "Skull (Pea Size)",
                    Image = "2013Skulls1.jpg",
                    AdditionalImages = new List<GalleryImage>()
                    {
                        new GalleryImage { Name = "2013Skulls2.jpg" },
                        new GalleryImage { Name = "BakeskullsSpread.jpg" }
                    },
                    CategoryId = categoryId
                },
                new Gallery {
                    Name = "Skull (Marble Size)",
                    Image = "AnatomySkull1.jpg",
                    AdditionalImages = new List<GalleryImage>()
                    {
                        new GalleryImage { Name = "AnatomySkull2.jpg" },
                        new GalleryImage { Name = "AnatomySkull4.jpg" },
                    },
                    CategoryId = categoryId
                },
                new Gallery {
                    Name = "Bomberman",
                    Image = "2015SculptsBomberman.jpg",
                    CategoryId = categoryId
                },
                new Gallery {
                    Name = "Bender",
                    Image = "2015SculptsBender.jpg",
                    CategoryId = categoryId
                },
                new Gallery {
                    Name = "Zombies",
                    Image = "Zombie3.jpg",
                    AdditionalImages = new List<GalleryImage>()
                    {
                        new GalleryImage { Name = "Zombie1.jpg" },
                        new GalleryImage { Name = "Zombie2.jpg" },
                    },
                    CategoryId = categoryId
                },
                new Gallery {
                    Name = "Spaceman Bop",
                    Image = "SpacemanBop.jpg",
                    CategoryId = categoryId
                },
                new Gallery {
                    Name = "Chess Piece",
                    Image = "ChessRook1.jpg",
                    CategoryId = categoryId
                },
                new Gallery {
                    Name = "Guinea Pigs",
                    Image = "Pigbase.jpg",
                    AdditionalImages = new List<GalleryImage>()
                    {
                        new GalleryImage { Name = "PiggiesPaint1.jpg"}
                    },
                    CategoryId = categoryId
                },
                new Gallery {
                    Name = "Screaming Stone",
                    Image = "ScreamingRock1.jpg",
                    AdditionalImages = new List<GalleryImage>()
                    {
                        new GalleryImage { Name = "ScreamingRock2.jpg" }
                    },
                    CategoryId = categoryId
                },
                new Gallery {
                    Name = "Big Head",
                    Image = "BigHead.jpg",
                    CategoryId = categoryId
                },
                new Gallery {
                    Name = "Pods",
                    Image = "PodA.jpg",
                    AdditionalImages = new List<GalleryImage>()
                    {
                        new GalleryImage { Name = "PodB1.jpg" },
                        new GalleryImage { Name = "PodB2.jpg" }
                    },
                    CategoryId = categoryId
                },
                new Gallery {
                    Name = "Penguin",
                    Image = "Penguin2.jpg",
                    AdditionalImages = new List<GalleryImage>()
                    {
                        new GalleryImage { Name = "Penguin1.jpg" },
                        new GalleryImage { Name = "Penguin3.jpg" },
                        new GalleryImage { Name = "Penguin4.jpg" },
                        new GalleryImage { Name = "Penguin5.jpg" },
                        new GalleryImage { Name = "Penguin6.jpg" }
                    },
                    CategoryId = categoryId
                },
                new Gallery {
                    Name = "Frog",
                    Image = "Frogsculpt.jpg",
                    CategoryId = categoryId
                },
                new Gallery {
                    Name = "Jarlid",
                    Image = "Jarlid.jpg",
                    CategoryId = categoryId
                  }
            };


            // Models.
            categoryId = context.Category.Where(x => x.Name == "Models" && x.Route == "Gallery").FirstOrDefault().Id;
            var models = new List<Gallery>() {
                new Gallery {
                    Name = "Stompy",
                    Image = "ST1770.jpg",
                    AdditionalImages = new List<GalleryImage>()
                    {
                        new GalleryImage { Name = "ST1771.jpg" },
                        new GalleryImage { Name = "ST1772.jpg" },
                        new GalleryImage { Name = "ST1774.jpg" },
                        new GalleryImage { Name = "ST1777.jpg" },
                        new GalleryImage { Name = "ST1778.jpg" },
                        new GalleryImage { Name = "ST1780.jpg" },
                        new GalleryImage { Name = "ST1781.jpg" },
                        new GalleryImage { Name = "ST1782.jpg" },
                        new GalleryImage { Name = "ST1785.jpg" },
                        new GalleryImage { Name = "ST1804.jpg" },
                        new GalleryImage { Name = "Stomp8927.jpg" },
                    },
                    CategoryId = categoryId
                },
                new Gallery {
                    Name = "Brain Machine",
                    Image = "Brainmachine1.jpg",
                    AdditionalImages = new List<GalleryImage>()
                    {
                        new GalleryImage { Name = "Brainmachine2.jpg" },
                        new GalleryImage { Name = "Brainmachine3.jpg" },
                        new GalleryImage { Name = "Brainmachine4.jpg" },
                        new GalleryImage { Name = "Brainmachine5.jpg" },
                        new GalleryImage { Name = "Brainmachine6.jpg" },
                        new GalleryImage { Name = "Brainmachine7.jpg" },
                        new GalleryImage { Name = "Brainmachine8.jpg" },
                        new GalleryImage { Name = "Brainmachine9.jpg" },
                        new GalleryImage { Name = "BrainMachine10.jpg" },
                        new GalleryImage { Name = "BrainMachine11.jpg" },
                        new GalleryImage { Name = "BrainMachine12.jpg" },
                        new GalleryImage { Name = "BrainMachine13.jpg" },
                        new GalleryImage { Name = "BrainMachine14.jpg" },
                        new GalleryImage { Name = "BrainMachine15.jpg" },
                        new GalleryImage { Name = "BrainMachine16.jpg" },
                        new GalleryImage { Name = "BrainMachine17.jpg" },
                        new GalleryImage { Name = "BrainMachine18.jpg" },
                        new GalleryImage { Name = "BrainMachine19.jpg" },
                    },
                    CategoryId = categoryId
                },
                new Gallery {
                    Name = "Falcon",
                    Image = "Fal7670.jpg",
                    AdditionalImages = new List<GalleryImage>()
                    {
                        new GalleryImage { Name = "Fal7675.jpg" },
                        new GalleryImage { Name = "Fal7660.jpg" },
                        new GalleryImage { Name = "Fal7661.jpg" },
                        new GalleryImage { Name = "Fal7666.jpg" },
                        new GalleryImage { Name = "Fal7673.jpg" }
                    },
                    CategoryId = categoryId
                },
                new Gallery {
                    Name = "Truescale Marine",
                    Image = "Head-hunter1.jpg",
                    AdditionalImages = new List<GalleryImage>()
                    {
                        new GalleryImage { Name = "Head-hunter2.jpg" },
                        new GalleryImage { Name = "Head-hunter3.jpg" },
                        new GalleryImage { Name = "Head-hunter4.jpg" },
                        new GalleryImage { Name = "Headhunter6.jpg" },
                        new GalleryImage { Name = "Headhunter7.jpg" }
                    },
                    CategoryId = categoryId
                },
                new Gallery {
                    Name = "Rhino Conversion",
                    Image = "Bronco3303.jpg",
                    AdditionalImages = new List<GalleryImage>()
                    {
                        new GalleryImage { Name = "Bronco3287.jpg" },
                        new GalleryImage { Name = "Bronco3288.jpg" },
                        new GalleryImage { Name = "Bronco3290.jpg" },
                        new GalleryImage { Name = "Bronco3294.jpg" },
                        new GalleryImage { Name = "Bronco3301.jpg" },
                        new GalleryImage { Name = "Bronco3302.jpg" },
                        new GalleryImage { Name = "Bronco3440.jpg" },
                        new GalleryImage { Name = "Bronco3442.jpg" },
                        new GalleryImage { Name = "Bronco3446.jpg" },
                        new GalleryImage { Name = "Bronco3461.jpg" },
                        new GalleryImage { Name = "Bronco3462.jpg" },
                        new GalleryImage { Name = "Bronco3470.jpg" },
                        new GalleryImage { Name = "Bronco3471.jpg" },
                        new GalleryImage { Name = "Bronco3475.jpg" },
                        new GalleryImage { Name = "Bronco041.jpg" },

                    },
                    CategoryId = categoryId
                },
                new Gallery {
                    Name = "Avatar",
                    Image = "Ava7165.jpg",
                    AdditionalImages = new List<GalleryImage>()
                    {
                        new GalleryImage { Name = "Ava7166.jpg" },
                        new GalleryImage { Name = "Ava7171.jpg" }
                    },
                    CategoryId = categoryId
                },
                new Gallery {
                    Name = "Farseer & Warlocks",
                    Image = "Warlock7111.jpg",
                    AdditionalImages = new List<GalleryImage>()
                    {
                        new GalleryImage { Name = "Warlock044.jpg" },
                        new GalleryImage { Name = "Warlock7112.jpg" },
                        new GalleryImage { Name = "Warlock7113.jpg" },
                        new GalleryImage { Name = "Warlock7116.jpg" },
                        new GalleryImage { Name = "Warlock7158.jpg" },
                        new GalleryImage { Name = "WarLock7384.jpg" },
                        new GalleryImage { Name = "WarLock7388.jpg" }
                    },
                    CategoryId = categoryId
                },
                new Gallery {
                    Name = "Striking Scorpions",
                    Image = "Scorp047.jpg",
                    AdditionalImages = new List<GalleryImage>()
                    {
                        new GalleryImage { Name = "Scorp048.jpg" },
                        new GalleryImage { Name = "Scorp7432.jpg" }
                    },
                    CategoryId = categoryId
                },
                new Gallery {
                    Name = "Banshees and Exarch",
                    Image = "BanEx7173.jpg",
                    AdditionalImages = new List<GalleryImage>()
                    {
                        new GalleryImage { Name = "BanEx7175.jpg" },
                        new GalleryImage { Name = "Ban7509.jpg" },
                        new GalleryImage { Name = "Ban7512.jpg" }
                    },
                    CategoryId = categoryId
                },
                new Gallery {
                    Name = "Dire Avengers",
                    Image = "Dire7494.jpg",
                    AdditionalImages = new List<GalleryImage>()
                    {
                        new GalleryImage { Name = "Dire7498.jpg" }
                    },
                    CategoryId = categoryId
                },
                new Gallery {
                    Name = "Swooping Hawks and Exarch",
                    Image = "Hawk7505.jpg",
                    AdditionalImages = new List<GalleryImage>()
                    {
                        new GalleryImage { Name = "Hawk7506.jpg" },
                        new GalleryImage { Name = "HawkEx7118.jpg" }
                    },
                    CategoryId = categoryId
                },
                new Gallery {
                    Name = "Fire Dragons",
                    Image = "FD7485.jpg",
                    AdditionalImages = new List<GalleryImage>()
                    {
                        new GalleryImage { Name = "FD7491.jpg" }
                    },
                    CategoryId = categoryId
                },
                new Gallery {
                    Name = "Dark Reapers and Exarch",
                    Image = "ReapEx7142.jpg",
                    AdditionalImages = new List<GalleryImage>()
                    {
                        new GalleryImage { Name = "ReapEx7150.jpg" },
                        new GalleryImage { Name = "Reap7479.jpg" },
                        new GalleryImage { Name = "Reap7481.jpg" }
                    },
                    CategoryId = categoryId
                },
                new Gallery {
                    Name = "Warp Spiders",
                    Image = "WS7419.jpg",
                    AdditionalImages = new List<GalleryImage>()
                    {
                        new GalleryImage { Name = "WS7423.jpg" }
                    },
                    CategoryId = categoryId
                },
                new Gallery {
                    Name = "War Walker Conversion",
                    Image = "WarWalker1.jpg",
                    AdditionalImages = new List<GalleryImage>()
                    {
                        new GalleryImage { Name = "WarWalker2.jpg" },
                        new GalleryImage { Name = "WarWalker3.jpg" },
                        new GalleryImage { Name = "WarWalker4.jpg" },
                        new GalleryImage { Name = "WarWalker5.jpg" },
                        new GalleryImage { Name = "WarWalker6.jpg" },
                        new GalleryImage { Name = "WarWalker7.jpg" },
                        new GalleryImage { Name = "WarWalker8.jpg" },
                        new GalleryImage { Name = "WarWalker9.jpg" },
                        new GalleryImage { Name = "WarWalker10.jpg" },
                        new GalleryImage { Name = "WarWalker11.jpg" },
                        new GalleryImage { Name = "WarWalker12.jpg" },
                        new GalleryImage { Name = "WarWalker13.jpg" },
                        new GalleryImage { Name = "WarWalker14.jpg" },
                        new GalleryImage { Name = "WarWalker15.jpg" },
                        new GalleryImage { Name = "WarWalker18.jpg" },
                        new GalleryImage { Name = "WarWalker19.jpg" },
                        new GalleryImage { Name = "WarWalker20.jpg" }
                    },
                    CategoryId = categoryId
                },
                new Gallery {
                    Name = "Wraith Guard",
                    Image = "WraithG7176.jpg",
                    AdditionalImages = new List<GalleryImage>()
                    {
                        new GalleryImage { Name = "WraithG7178.jpg" }
                    },
                    CategoryId = categoryId
                },
                new Gallery {
                    Name = "Weapon Platform Crew (Guardians)",
                    Image = "WPC7413.jpg",
                    AdditionalImages = new List<GalleryImage>()
                    {
                        new GalleryImage { Name = "WPC7415.jpg" }
                    },
                    CategoryId = categoryId
                },
                new Gallery {
                    Name = "Guardians",
                    Image = "Gaurd7405.jpg",
                    AdditionalImages = new List<GalleryImage>()
                    {
                        new GalleryImage { Name = "Gaurd7410.jpg" },
                        new GalleryImage { Name = "Gaurd7735.jpg" },
                        new GalleryImage { Name = "Gaurd7737.jpg" },
                        new GalleryImage { Name = "Gaurd7738.jpg" },
                        new GalleryImage { Name = "Gaurd7739.jpg" },
                        new GalleryImage { Name = "Gaurd7745.jpg" },
                        new GalleryImage { Name = "Gaurd7748.jpg" },
                        new GalleryImage { Name = "Gaurd7855.jpg" }
                    },
                    CategoryId = categoryId
                },
                new Gallery {
                    Name = "Jet Bikes",
                    Image = "Jet7680.jpg",
                    AdditionalImages = new List<GalleryImage>()
                    {
                        new GalleryImage { Name = "Jet7685.jpg" },
                        new GalleryImage { Name = "Jet7695.jpg" }
                    },
                    CategoryId = categoryId
                },
                new Gallery {
                    Name = "Vipers",
                    Image = "Vip7700.jpg",
                    AdditionalImages = new List<GalleryImage>()
                    {
                        new GalleryImage { Name = "Vip7704.jpg" },
                        new GalleryImage { Name = "Vip7709.jpg" },
                        new GalleryImage { Name = "Vip7712.jpg" }
                    },
                    CategoryId = categoryId
                }
            };

            // Architectural.
            categoryId = context.Category.Where(x => x.Name == "Architectural" && x.Route == "Gallery").FirstOrDefault().Id;
            var architectural = new List<Gallery> {
                new Gallery {
                    Name = "Spiral Stairs",
                    Image = "spir1867.jpg",
                    AdditionalImages = new List<GalleryImage>()
                    {
                        new GalleryImage { Name = "spir1970.jpg" },
                        new GalleryImage { Name = "spir1971.jpg" },
                        new GalleryImage { Name = "spir1996.jpg" },
                        new GalleryImage { Name = "spir1999.jpg" },
                        new GalleryImage { Name = "spir2253.jpg" },
                        new GalleryImage { Name = "spir2256.jpg" },
                        new GalleryImage { Name = "spir2258.jpg" },
                        new GalleryImage { Name = "spir2263.jpg" },
                        new GalleryImage { Name = "spir2264.jpg" }
                    },
                    CategoryId = categoryId
                },
                new Gallery {
                    Name = "Wall Hole",
                    Image = "HW1207.jpg",
                    AdditionalImages = new List<GalleryImage>()
                    {
                        new GalleryImage { Name = "HW2800.jpg" },
                        new GalleryImage { Name = "HW2829.jpg" },
                        new GalleryImage { Name = "HW2830.jpg" },
                        new GalleryImage { Name = "HW2856.jpg" },
                        new GalleryImage { Name = "WallComp.jpg" },
                        new GalleryImage { Name = "WallHole7740.jpg" },
                        new GalleryImage { Name = "WallHole7742.jpg" }
                    },
                    CategoryId = categoryId
                },
                new Gallery {
                    Name = "Mansion House",
                    Image = "Mansion1.jpg",
                    AdditionalImages = new List<GalleryImage>()
                    {
                        new GalleryImage { Name = "Mansion2.jpg" },
                        new GalleryImage { Name = "Mansion3.jpg" },
                        new GalleryImage { Name = "Mansion4.jpg" },
                        new GalleryImage { Name = "Mansion5.jpg" },
                        new GalleryImage { Name = "Mansion6.jpg" },
                        new GalleryImage { Name = "Mansion7.jpg" },
                        new GalleryImage { Name = "Mansion8.jpg" },
                        new GalleryImage { Name = "Mansion9.jpg" },
                        new GalleryImage { Name = "Mansion10.jpg" },
                        new GalleryImage { Name = "Mansion11.jpg" },
                        new GalleryImage { Name = "Mansion12.jpg" },
                        new GalleryImage { Name = "Mansion13.jpg" },
                        new GalleryImage { Name = "Mansion14.jpg" },
                        new GalleryImage { Name = "Mansion15.jpg" }
                    },
                    CategoryId = categoryId
                },
                new Gallery {
                    Name = "Death Pit",
                    Image = "Dpit3604.jpg",
                    AdditionalImages = new List<GalleryImage>()
                    {
                        new GalleryImage { Name = "DPit3605.jpg" },
                        new GalleryImage { Name = "DPit3613.jpg" },
                        new GalleryImage { Name = "DPit3614.jpg" },
                        new GalleryImage { Name = "DPit3615.jpg" },
                        new GalleryImage { Name = "DPit3617.jpg" },
                        new GalleryImage { Name = "DPit3619.jpg" },
                        new GalleryImage { Name = "DPit3626.jpg" },
                        new GalleryImage { Name = "DPit3640.jpg" },
                        new GalleryImage { Name = "Dpit3695.jpg" },
                        new GalleryImage { Name = "Dpit3697.jpg" },
                        new GalleryImage { Name = "Dpit3705.jpg" },
                    },
                    CategoryId = categoryId,
                },
                new Gallery {
                    Name = "Insulin Stand",
                    Image = "InsulinStand1.jpg",
                    AdditionalImages = new List<GalleryImage>()
                    {
                        new GalleryImage { Name = "InsulinStand2.jpg" },
                        new GalleryImage { Name = "InsulinStand3.jpg" },
                        new GalleryImage { Name = "InsulinStand4a.jpg" },
                        new GalleryImage { Name = "InsulinStand5.jpg" },
                        new GalleryImage { Name = "InsulinStand6.jpg" },
                        new GalleryImage { Name = "InsulinStand7.jpg" },
                        new GalleryImage { Name = "InsulinStand8.jpg" },
                        new GalleryImage { Name = "InsulinStand9.jpg" },
                        new GalleryImage { Name = "InsulinStand10.jpg" }
                    },
                    CategoryId = categoryId
                },
                new Gallery {
                    Name = "Chain Fence",
                    Image = "ChainFence1.jpg",
                    AdditionalImages = new List<GalleryImage>()
                    {
                        new GalleryImage { Name = "ChainFence2.jpg" },
                        new GalleryImage { Name = "ChainFence3.jpg" },
                        new GalleryImage { Name = "ChainFence4.jpg" }
                    },
                    CategoryId = categoryId
                },
                new Gallery {
                    Name = "Wooden Fences",
                    Image = "Fences1.jpg",
                    AdditionalImages = new List<GalleryImage>()
                    {
                        new GalleryImage { Name = "Fences2.jpg" },
                        new GalleryImage { Name = "Fences3.jpg" },
                        new GalleryImage { Name = "Fences4.jpg" },
                        new GalleryImage { Name = "Fences5.jpg" },
                        new GalleryImage { Name = "Fences6.jpg" }
                    },
                    CategoryId = categoryId
                },
                new Gallery {
                    Name = "Wall Pipe",
                    Image = "WallPipe1.jpg",
                    AdditionalImages = new List<GalleryImage>()
                    {
                        new GalleryImage { Name = "WallPipe2.jpg" },
                        new GalleryImage { Name = "WallPipe3.jpg" }
                    },
                    CategoryId = categoryId
                },
                new Gallery {
                    Name = "Skull Tomb Rack",
                    Image = "Skulltomb5.jpg",
                    AdditionalImages = new List<GalleryImage>()
                    {
                        new GalleryImage { Name = "Skulltomb1.jpg" },
                        new GalleryImage { Name = "Skulltomb2.jpg" },
                        new GalleryImage { Name = "Skulltomb3.jpg" },
                        new GalleryImage { Name = "Skulltomb4.jpg" }
                    },
                    CategoryId = categoryId
                },
                new Gallery {
                    Name = "Bird Cage",
                    Image = "Birdcage2.jpg",
                    AdditionalImages = new List<GalleryImage>()
                    {
                        new GalleryImage { Name = "Birdcage1.jpg" },
                        new GalleryImage { Name = "Birdcage3.jpg" },
                        new GalleryImage { Name = "Birdcage4.jpg" }
                    },
                    CategoryId = categoryId
                }
            };

            // Sketches.
            categoryId = context.Category.Where(x => x.Name == "Sketches" && x.Route == "Gallery").FirstOrDefault().Id;
            var sketches = new List<Gallery>() {
                new Gallery {
                    Name = "Skulls (Pencil)",
                    Image = "SKULLSpage.jpg",
                    CategoryId = categoryId
                },
                new Gallery {
                    Name = "Dark Angel",
                    Image = "angelsketch.jpg",
                    CategoryId = categoryId
                },
                new Gallery {
                    Name = "Grimdust",
                    Image = "GrimDust.jpg",
                    CategoryId = categoryId
                },
                new Gallery {
                    Name = "SpaceLoonz (Comic)",
                    Image = "SpaceLoonz.jpg",
                    CategoryId = categoryId
                },
                new Gallery {
                    Name = "Night Pigeon",
                    Image = "NPDetailBack3.jpg",
                    AdditionalImages = new List<GalleryImage>()
                    {
                        new GalleryImage { Name = "FeathersGroup.jpg" },
                        new GalleryImage { Name = "NPHero.jpg" },
                    },
                    CategoryId = categoryId
                },
                new Gallery {
                    Name = "Chess",
                    Image = "ChessCastle1.jpg",
                    AdditionalImages = new List<GalleryImage>()
                    {
                        new GalleryImage { Name = "ChessCastle.jpg" },
                    },
                    CategoryId = categoryId
                },
                new Gallery {
                    Name = "Dolphin",
                    Image = "Canvas1.jpg",
                    AdditionalImages = new List<GalleryImage>()
                    {
                        new GalleryImage { Name = "Canvas2.jpg" },
                        new GalleryImage { Name = "Canvas3.jpg" },
                    },
                    CategoryId = categoryId
                },
                new Gallery {
                    Name = "Earthtrace",
                    Image = "Canvas5.jpg",
                    AdditionalImages = new List<GalleryImage>()
                    {
                        new GalleryImage { Name = "Canvas6.jpg" },
                    },
                    CategoryId = categoryId
                }
            };

            var gallery = new List<Gallery>();

            gallery.AddRange(sculptures);
            gallery.AddRange(models);
            gallery.AddRange(architectural);
            gallery.AddRange(sketches);

            int order = 1;
            int imgOrder = 1;
            foreach (var item in gallery)
            {
                if (item.AdditionalImages != null)
                {
                    foreach (var img in item.AdditionalImages)
                    {
                        img.Order = imgOrder;
                        imgOrder++;
                    }
                }
                imgOrder = 1;


                item.Order = order;
                order++;
            }

            return gallery;
        }

        public static List<SocialMedia> GetSocialMedia()
        {
            return new List<SocialMedia>() {
                new SocialMedia {
                    Facebook = "https://www.facebook.com/DustysCorner",
                    Twitter = "https://twitter.com/Dustys_Corner",
                    TwitterEmbed = "<a class='twitter-timeline' data-height='250' href='https://twitter.com/Dustys_Corner' data-chrome='nofooter noborders transparent'>Tweets by Dustys_Corner</a>" +
                    "<script async src='https://platform.twitter.com/widgets.js' charset='utf-8'></script>",
                }
            };
        }
    }
}