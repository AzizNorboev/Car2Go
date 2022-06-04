using System;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Car2Go.Data.Common.Models;
using Car2Go.Data.Models;
using Microsoft.AspNetCore.Identity;

namespace Car2Go.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        private static readonly MethodInfo SetIsDeletedQueryFilterMethod =
            typeof(ApplicationDbContext).GetMethod(
                nameof(SetIsDeletedQueryFilter),
                BindingFlags.NonPublic | BindingFlags.Static);

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Car> Cars { get; set; }

        public DbSet<Location> Locations { get; set; }

        public DbSet<Review> Reviews { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<CarRentDays> CarRentDays { get; set; }

        public DbSet<Dealer> Dealers { get; set; }

        public override int SaveChanges() => this.SaveChanges(true);

        public override int SaveChanges(bool acceptAllChangesOnSuccess)
        {
            this.ApplyAuditInfoRules();
            return base.SaveChanges(acceptAllChangesOnSuccess);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default) =>
            this.SaveChangesAsync(true, cancellationToken);

        public override Task<int> SaveChangesAsync(
            bool acceptAllChangesOnSuccess,
            CancellationToken cancellationToken = default)
        {
            this.ApplyAuditInfoRules();
            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            // Needed for Identity models configuration
            base.OnModelCreating(builder);

            builder.Entity<Dealer>()
                 .HasOne<ApplicationUser>()
                 .WithOne()
                 .HasForeignKey<Dealer>(d => d.UserId)
                 .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Car>().
               HasMany(x => x.RentDays).
               WithOne(x => x.Car).
               HasForeignKey(k => k.CarId);

            builder.Entity<ApplicationUser>().
               HasMany(x => x.Orders).
               WithOne(x => x.User).
               HasForeignKey(k => k.ApplicationUserId).
               OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Car>().
             HasMany(x => x.RentDays).
             WithOne(x => x.Car).
             HasForeignKey(k => k.CarId).
             OnDelete(DeleteBehavior.Restrict);

            PasswordHasher<ApplicationUser> passwordHasher = new PasswordHasher<ApplicationUser>();
            ApplicationUser user = new ApplicationUser()
            {
                UserName = "Admin@gmail.com",
                NormalizedUserName = "ADMIN@GMAIL.COM",
                NormalizedEmail = "ADMIN@GMAIL.COM",
                Email = "Admin@gmail.com",
            };
            
            var hash = passwordHasher.HashPassword(user, "P@ssword");
            user.PasswordHash = hash;

            builder.Entity<ApplicationUser>().HasData(user);

            builder.Entity<Location>().HasData(new Location { Id = 1, Name = "Tashkent International Airport" });
            builder.Entity<Location>().HasData(new Location { Id = 2, Name = "Chilanzar Subway Station" });
            builder.Entity<Location>().HasData(new Location { Id = 3, Name = "Hilton Hotel" });
            builder.Entity<Location>().HasData(new Location { Id = 4, Name = "Mega Planet" });
            builder.Entity<Location>().HasData(new Location { Id = 5, Name = "North Train Station" });
            builder.Entity<Location>().HasData(new Location { Id = 6, Name = "South Train Station" });
            builder.Entity<Location>().HasData(new Location { Id = 7, Name = "Bunyodkor Stadium" });
            builder.Entity<Location>().HasData(new Location { Id = 8, Name = "Oybek Subway Station" });
            builder.Entity<Location>().HasData(new Location { Id = 9, Name = "Park Amir Temur" });
            builder.Entity<Location>().HasData(new Location { Id = 10, Name = "Buyuk Ipak Yoli Subway Station" });
            builder.Entity<Car>().HasData(new Car
            {
                Id = 1,
                InUse = false,
                Model = "Cobalt",
                Description = "Chevrolet Cobalt is a family sedan created by the designers of the Brazilian division of the GM Corporation using standard GM global development processes. Cobalt was developed by GM's global team to become the world benchmark in its segment and the leader in sales in growing markets. Chevrolet Cobalt combines comfort, sophistication and high dynamic qualities, as well as timeless traditional classic design. To ensure better safety, the Chevrolet Cobalt, manufactured from high-strength steel, is equipped with ABS (anti-lock braking system) and driver and front passenger airbags",
                GearType = Models.Enums.GearType.Automatic, 
                PricePerDay = 180000,
                Image = "https://uzautomotors.com/images/uploads/ca519572d01038ee51311f82f9384204.jpg",
                Year = 2020,
                Speed = 200,
            });
            builder.Entity<Car>().HasData(new Car
            {
                Id = 12,
                InUse = false,
                Model = "Cobalt",
                Description = "",
                PricePerDay = 170000,
                Image = "https://tasinha-photos-kluz.kcdn.online/webp/79/79646cb0-2e11-49b9-ae7a-50454c50b56c/1-160x120.jpg",
                Year = 2019,
                Speed = 200,
            });

            builder.Entity<Car>().HasData(new Car
            {
                Id = 2,
                InUse = false,
                Model = "Nexia 3",
                Description = "The Nexia is one of the most compact, stylish and popular cars in the world, combining a sporty look and a spacious, comfortable interior. It is easy to operate and has a high-tech security system. Quality interior decoration materials are carefully thought out to the smallest detail. The large luggage allows you to take everything you need with you on the trip without sacrificing anything.",
                GearType = Models.Enums.GearType.Manual,
                PricePerDay = 150000,
                Image = "https://uzautomotors.com/images/uploads/e2d6a236bd002eb0ce3b4b7613f009c7.jpg",
                Year = 2020,
                Speed = 180,
            });
            builder.Entity<Car>().HasData(new Car
            {
                Id = 13,
                InUse = true,
                Model = "Nexia 3",
                Description = "good",
                PricePerDay = 170000,
                Image = "https://tasinha-photos-kluz.kcdn.online/webp/04/04f10e23-aff0-4388-86d0-62bd87f06ad5/1-160x120.jpg",
                Year = 2020,
                Speed = 200,
            });
            builder.Entity<Car>().HasData(new Car
            {
                Id = 3,
                InUse = true,
                Model = "Malibu",
                Description = "Designers, working on a new generation of Chevrolet Malibu, tried to give the model more aggressiveness in the exterior. The novelty, unlike the previous generation, has a completely different exterior design. The presence of broken lines and bends gives the sedan a dynamic and makes it particularly attractive. The dual easy-to-recognize branded Malibu radiator grille is now equipped with a narrower head LED optics. The relief impressions on the sides of the body together with the rear part are similar in many respects to the Impala sedan, but in general the majority of the body elements are similar to the legendary Camaro, but it is only externally. At the same time, due to careful study of individual body parts, it was possible to achieve excellent aerodynamic performance. In the Uzbek market the car will be presented in 4 colors (pearl white, white-smoky, dark gray and black).",
                GearType = Models.Enums.GearType.Automatic,
                PricePerDay = 300000,
                Image = "https://uzautomotors.com/images/uploads/60e102ca38452ea6ba25541824d9d045.jpg",
                Year = 2020,
                Speed = 220,
            });
            builder.Entity<Car>().HasData(new Car
            {
                Id = 14,
                InUse = true,
                Model = "Malibu",
                Description = "",
                PricePerDay = 280000,
                Image = "https://tasinha-photos-kluz.kcdn.online/webp/2f/2fcac581-4e12-4d0c-b062-84db5ecadf37/5-160x120.jpg",
                Year = 2020,
                Speed = 200,
            });

            builder.Entity<Car>().HasData(new Car
            {
                Id = 4,
                InUse = false,
                Model = "Chevrolet Tracker 2",
                Description = "The Chevrolet Tracker is an automotive nameplate that has been used by Chevrolet for two different vehicle lines. Chevrolet Tracker (Americas): since 1988 for the 1989 model year, spanning two generations, Chevrolet has rebadged a version of the Suzuki Escudo as the Tracker.",
                GearType = Models.Enums.GearType.Automatic,
                PricePerDay = 310000,
                Image = "https://i.ibb.co/PF4pxf1/52.jpg",
                Year = 2019,
                Speed = 245,
            });
            builder.Entity<Car>().HasData(new Car
            {
                Id = 15,
                InUse = true,
                Model = "Chevrolet Tracker 2",
                Description = "",
                PricePerDay = 300000,
                Image = "https://www.autostrada.uz/wp-content/uploads/2020/12/20210115_123901-001.jpg",
                Year = 2020,
                Speed = 200,
            });
            builder.Entity<Car>().HasData(new Car
            {
                Id = 5,
                InUse = false,
                Model = "Chevrolet Tracker",
                Description = "The Chevrolet Tracker is an automotive nameplate that has been used by Chevrolet for two different vehicle lines. Chevrolet Tracker (Americas): since 1988 for the 1989 model year, spanning two generations, Chevrolet has rebadged a version of the Suzuki Escudo as the Tracker.",
                GearType = Models.Enums.GearType.Automatic,
                PricePerDay = 310000,
                Image = "https://uzautomotors.com/images/uploads/c892a6c45990f70c4531efb3b1c95a68.jpg",
                Year = 2020,
                Speed = 220,
            });
            builder.Entity<Car>().HasData(new Car
            {
                Id = 16,
                InUse = true,
                Model = "Chevrolet Tracker",
                Description = "",
                PricePerDay = 350000,
                Image = "https://auto.ironhorse.ru/wp-content/uploads/2017/06/Tracker-New.jpg",
                Year = 2020,
                Speed = 200,
            });
            builder.Entity<Car>().HasData(new Car
            {
                Id = 6,
                InUse = true,
                Model = "Kia Optima",
                Description = "The Optima is a vehicle that delivers all of these virtues in a stylish, value-laden package that’s filled with features usually found on pricier cars. With outstanding reliability and extensive warranty coverage, savvy sedan shoppers should take this recently redesigned car for a test drive.",
                GearType = Models.Enums.GearType.Automatic,
                PricePerDay = 350000,
                Image = "https://i.dir-i.net/CMS/2019/12/28/k/5f_kzmt31.jpg",
                Year = 2020,
                Speed = 200,
            });
            builder.Entity<Car>().HasData(new Car
            {
                Id = 17,
                InUse = true,
                Model = "Kia Optima",
                Description = "",
                PricePerDay = 260000,
                Image = "https://www.motortrend.com/uploads/sites/5/2018/10/2019-Kia-Optima-SX-front-three-quarter-in-motion-3.jpg",
                Year = 2020,
                Speed = 200,
            });
            builder.Entity<Car>().HasData(new Car
            {
                Id = 7,
                InUse = false,
                Model = "CHEVROLET EQUINOX",
                Description = "And the most interesting is the motor range. The two-liter car is equipped with a nine-speed automatic, and the other two with a six-speed automatic. Drive - front or full. The fuel tank has a volume of 55 l, a 2.0 Turbo engine, consumption starts from 8.2 l / 100 km in the urban cycle. Acceleration time of the Chevrolet Equinox is 7.8 s to 100 km / h.",
                GearType = Models.Enums.GearType.Manual,
                PricePerDay = 320000,
                Image = "https://uzautomotors.com/images/uploads/2c2252e409368d0d3549beaa3e0651a4.jpg",
                Year = 2020,
                Speed = 230,
            });
            builder.Entity<Car>().HasData(new Car
            {
                Id = 8,
                InUse = false,
                Model = "CHEVROLET TRAVERSE",
                Description = "The new Chevrolet Traverse has everything to make every kilometer special for you and your family. Up to 8 passenger seats and the most spacious luggage space in the class, the function of choosing a driving mode and an advanced all-wheel drive system, a solid appearance and a well-designed interior - this car is able to adapt to any task. Add to this the latest security technology, as well as additional features for your comfort, and you will understand why Traverse is worthy of your choice.",
                GearType = Models.Enums.GearType.Manual,
                PricePerDay = 315000,
                Image = "https://blogmedia.dealerfire.com/wp-content/uploads/sites/1074/2019/12/2020-Honda-Ridgeline-exterior-side-shot-with-Obsidian-Blue-Pearl-paint-color-parked-on-a-beach-line-of-gravel-and-sand-next-to-the-ocean_o.jpg",
                Year = 2020,
                Speed = 220,
            });
            builder.Entity<Car>().HasData(new Car
            {
                Id = 18,
                InUse = true,
                Model = "CHEVROLET TRAVERSE",
                Description = "",
                PricePerDay = 280000,
                Image = "https://fichasmotor.com/images/chevrolet/chevrolet-traverse-i-3-6-v6-281-cv-awd-automatico.webp",
                Year = 2020,
                Speed = 200,
            });
            builder.Entity<Car>().HasData(new Car
            {
                Id = 9,
                InUse = false,
                Model = "CHEVROLET TRAILBLAZER",
                Description = "A full-size SUV that combines technology, performance, design and safety is all about it - the Chevrolet Trailblazer. If you need a car with a powerful engine for both travel and everyday life, then Trailblazer is a great choice",
                GearType = Models.Enums.GearType.Manual,
                PricePerDay = 300000,
                Image = "https://uzautomotors.com/images/uploads/6be5fb769c9b8ef6509eb3f3a1fc497a.jpg",
                Year = 2020,
                Speed = 200,
            });
            builder.Entity<Car>().HasData(new Car
            {
                Id = 19,
                InUse = false,
                Model = "CHEVROLET TRAILBLAZER",
                Description = "",
                PricePerDay = 390000,
                Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQzsEfyLUAVg2o3cjhWRZ4el8z6T6dCU7SzmA&usqp=CAU",
                Year = 2020,
                Speed = 200,
            });
            builder.Entity<Car>().HasData(new Car
            {
                Id = 10,
                InUse = false,
                Model = "Chevrolet Impala",
                Description = "The Impala continues to reign as the leading large sedan. Slide behind the wheel and you can see why. Roomy, supportive seats put you in the perfect position to access the intuitive controls. Despite its prodigious size, the Impala’s handling is responsive and secure.",
                GearType = Models.Enums.GearType.Automatic,
                PricePerDay = 300000,
                Image = "https://banner2.cleanpng.com/20180410/xrw/kisspng-2017-chevrolet-impala-2018-chevrolet-impala-chevro-chevrolet-5accd70885ac83.6020416415233738325475.jpg",
                Year = 2020,
                Speed = 200,
            });
            builder.Entity<Car>().HasData(new Car
            {
                Id = 20,
                InUse = false,
                Model = "Chevrolet Impala",
                Description = "",
                PricePerDay = 280000,
                Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQW3yA6kh0qsD_IP65A3K9Ibsbkm1k8x2gaEQ&usqp=CAU",
                Year = 2018,
                Speed = 200,
            });
            builder.Entity<Car>().HasData(new Car
            {
                Id = 11,
                InUse = false,
                Model = "CHEVROLET LACETTI",
                Description = "If appearance is important, then Lacetti is for you. Correct proportions, streamlined shapes, relief lines harmoniously combined in this car, which has a respectable interior and exterior. Lacetti comfortably accommodates five people in a modern laconic salon. The instrument panel features a sense of proportion and variety of options. The arrangement of the instruments with chrome elements is carefully thought out. Its driving qualities are thoroughly tested and perfected.",
                GearType = Models.Enums.GearType.Automatic,
                PricePerDay = 200000,
                Image = "https://uzautomotors.com/images/uploads/8c8ad114c16e10db77c7953a2afc5b62.jpg",
                Year = 2020,
                Speed = 280,
            });
            builder.Entity<Car>().HasData(new Car
            {
                Id = 21,
                InUse = false,
                Model = "CHEVROLET LACETTI",
                Description = "in good condition",
                PricePerDay = 180000,
                Image = "https://uzautomotors.com/images/uploads/ca519572d01038ee51311f82f9384204.jpg",
                Year = 2020,
                Speed = 200,
            });
            this.ConfigureUserIdentityRelations(builder);

            EntityIndexesConfiguration.Configure(builder);

            var entityTypes = builder.Model.GetEntityTypes().ToList();

            // Set global query filter for not deleted entities only
            var deletableEntityTypes = entityTypes
                .Where(et => et.ClrType != null && typeof(IDeletableEntity).IsAssignableFrom(et.ClrType));
            foreach (var deletableEntityType in deletableEntityTypes)
            {
                var method = SetIsDeletedQueryFilterMethod.MakeGenericMethod(deletableEntityType.ClrType);
                method.Invoke(null, new object[] { builder });
            }

            // Disable cascade delete
            var foreignKeys = entityTypes
                .SelectMany(e => e.GetForeignKeys().Where(f => f.DeleteBehavior == DeleteBehavior.Cascade));
            foreach (var foreignKey in foreignKeys)
            {
                foreignKey.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }

        private static void SetIsDeletedQueryFilter<T>(ModelBuilder builder)
            where T : class, IDeletableEntity
        {
            builder.Entity<T>().HasQueryFilter(e => !e.IsDeleted);
        }

        // Applies configurations
        private void ConfigureUserIdentityRelations(ModelBuilder builder)
             => builder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);

        private void ApplyAuditInfoRules()
        {
            var changedEntries = this.ChangeTracker
                .Entries()
                .Where(e =>
                    e.Entity is IAuditInfo &&
                    (e.State == EntityState.Added || e.State == EntityState.Modified));

            foreach (var entry in changedEntries)
            {
                var entity = (IAuditInfo)entry.Entity;
                if (entry.State == EntityState.Added && entity.CreatedOn == default)
                {
                    entity.CreatedOn = DateTime.UtcNow;
                }
                else
                {
                    entity.ModifiedOn = DateTime.UtcNow;
                }
            }
        }
    }
}
