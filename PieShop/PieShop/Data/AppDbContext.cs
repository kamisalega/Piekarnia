using Microsoft.EntityFrameworkCore;
using PieShop.Models;

namespace PieShop.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        
        public DbSet<Pie> Pies { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Ciasto owocowe" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Sernik" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "sezonowe ciasta" });

            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                PieId = 1,
                Name = "Szarlotka",
                Price = 12.95M,
                ShortDescription = "Nasze s³ynne szarlotki!",
                LongDescription =
                    "Lodowaty placek z galaretki o-marchewkowy. S³odka bu³ka marcepan marshmallow toffi brownie brownie cukierek tootsie roll. Ciasto czekoladowe piernik tootsie bu³ka owsiane ciasto ciasto czekoladowe ciasteczko ciastko dragée brownie. Lollipop wata cukrowa ciasto niedŸwiedŸ pazur owies ciasto. Dragée cukierki laski deserowe tarta. Marcepan ¿elki dragée lizak jujuby batoniki czekoladowe laski. lukier piernik chupa chups wata cukrowa ciasteczko s³odki lukier ¿elki ¿elki ¿elki ¿elki ciasteczko duñskie ciastko czekoladowe duñskie ciastko w proszku makaronik czekoladowy p¹czek tarta ciasto marchewkowe drób rogalik krople cytryny lukrecja krople cytryny ciastko lollipop toffi. Ciasto marchewkowe Ciasto marchewkowe Lukrecja Cukier Œliwka Polewa Bonbon Pie Muffin Jujubes. Galaretka Ciasto Waflowe Tarta Karmel NiedŸwiedŸ Pazur. Tiramisu Tarta Ciasto Duñskie Krople Cytryny. Brownie Babeczka Dragée ¿elki. ",
                CategoryId = 1,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg",
                InStock = true,
                IsPieOfTheWeek = true,
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg",
                AllergyInformation = ""
            }) ;

            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                PieId = 2,
                Name = "Sernik jagodowy",
                Price = 18.95M,
                ShortDescription = "Pokochasz to!",
                LongDescription =
                    "Lodowaty placek z galaretki o-marchewkowy. S³odka bu³ka marcepan marshmallow toffi brownie brownie cukierek tootsie roll. Ciasto czekoladowe piernik tootsie bu³ka owsiane ciasto ciasto czekoladowe ciasteczko ciastko dragée brownie. Lollipop wata cukrowa ciasto niedŸwiedŸ pazur owies ciasto. Dragée cukierki laski deserowe tarta. Marcepan ¿elki dragée lizak jujuby batoniki czekoladowe laski. lukier piernik chupa chups wata cukrowa ciasteczko s³odki lukier ¿elki ¿elki ¿elki ¿elki ciasteczko duñskie ciastko czekoladowe duñskie ciastko w proszku makaronik czekoladowy p¹czek tarta ciasto marchewkowe drób rogalik krople cytryny lukrecja krople cytryny ciastko lollipop toffi. Ciasto marchewkowe Ciasto marchewkowe Lukrecja Cukier Œliwka Polewa Bonbon Pie Muffin Jujubes. Galaretka Ciasto Waflowe Tarta Karmel NiedŸwiedŸ Pazur. Tiramisu Tarta Ciasto Duñskie Krople Cytryny. Brownie Babeczka Dragée ¿elki. ",
                CategoryId = 2,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecake.jpg",
                InStock = true,
                IsPieOfTheWeek = false,
                ImageThumbnailUrl =
                    "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecakesmall.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                PieId = 3,
                Name = "Sernik",
                Price = 18.95M,
                ShortDescription = "Zwyk³y sernik. Zwyk³a przyjemnoœæ.",
                LongDescription =
                    "Lukierowy ¿elkowy tort ¿elowy sernik. S³odka bu³ka marcepan marshmallow toffi brownie brownie tootsie roll. Ciasto Czekoladowe Piernik Tootsie Roll Owies Ciasto Ciasto Czekoladowe Ciastko Dragée Brownie. Lollipop Wata cukrowa ciasto niedŸwiedŸ pazur owsiane ciasto. Tarta deserowa z trzciny cukrowej Dragée. Marcepanowe dragée ¿elki lizakowe jujuby batoniki czekoladowe. Lukier chupa chupa chups wata cukrowa ciasteczko s³odki lukier bonbonowe ¿elki. Gummies Lollipop Brownie Biscuit Duñskie Ciasto Czekoladowe. Ciastko w proszku duñski makaronik czekoladowy p¹czek. Ciasto marchewkowe Dragée Rogalik Krople cytryny Lukrecja Krople cytryny Ciastko Lollipop Toffi. Ciasto marchewkowe Ciasto marchewkowe Lukrecja Cukier Œliwka Polewa Bonbon Pie Muffin Jujubes. Tarta waflowa karmelowa tarta karmelowa niedŸwiedŸ pazur. Ciasto tarta tiramisu duñskie krople cytryny. Babeczki Brownie Dragée.",
                CategoryId = 2,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecake.jpg",
                InStock = true,
                IsPieOfTheWeek = false,
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecakesmall.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                PieId = 4,
                Name = "Placek wiœniowy",
                Price = 15.95M,
                ShortDescription = "Letni klasyk!",
                LongDescription =
                    "Lukierowy ¿elkowy tort ¿elowy sernik. S³odka bu³ka marcepan marshmallow toffi brownie brownie tootsie roll. Ciasto Czekoladowe Piernik Tootsie Roll Owies Ciasto Ciasto Czekoladowe Ciastko Dragée Brownie. Lollipop Wata cukrowa ciasto niedŸwiedŸ pazur owsiane ciasto. Tarta deserowa z trzciny cukrowej Dragée. Marcepanowe dragée ¿elki lizakowe jujuby batoniki czekoladowe. Lukier chupa chupa chups wata cukrowa ciasteczko s³odki lukier bonbonowe ¿elki. Gummies Lollipop Brownie Biscuit Duñskie Ciasto Czekoladowe. Ciastko w proszku duñski makaronik czekoladowy p¹czek. Ciasto marchewkowe Dragée Rogalik Krople cytryny Lukrecja Krople cytryny Ciastko Lollipop Toffi. Ciasto marchewkowe Ciasto marchewkowe Lukrecja Cukier Œliwka Polewa Bonbon Pie Muffin Jujubes. Tarta waflowa karmelowa tarta karmelowa niedŸwiedŸ pazur. Ciasto tarta tiramisu duñskie krople cytryny. Babeczki Brownie Dragée.",
                CategoryId = 1,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cherrypie.jpg",
                InStock = true,
                IsPieOfTheWeek = false,
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cherrypiesmall.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                PieId = 5,
                Name = "Œwi¹teczna Szarlotka",
                Price = 13.95M,
                ShortDescription = "Weso³ych œwi¹t z tym ciastem!",
                LongDescription =
                    "Lukierowy ¿elkowy tort ¿elowy sernik. S³odka bu³ka marcepan marshmallow toffi brownie brownie tootsie roll. Ciasto Czekoladowe Piernik Tootsie Roll Owies Ciasto Ciasto Czekoladowe Ciastko Dragée Brownie. Lollipop Wata cukrowa ciasto niedŸwiedŸ pazur owsiane ciasto. Tarta deserowa z trzciny cukrowej Dragée. Marcepanowe dragée ¿elki lizakowe jujuby batoniki czekoladowe. Lukier chupa chupa chups wata cukrowa ciasteczko s³odki lukier bonbonowe ¿elki. Gummies Lollipop Brownie Biscuit Duñskie Ciasto Czekoladowe. Ciastko w proszku duñski makaronik czekoladowy p¹czek. Ciasto marchewkowe Dragée Rogalik Krople cytryny Lukrecja Krople cytryny Ciastko Lollipop Toffi. Ciasto marchewkowe Ciasto marchewkowe Lukrecja Cukier Œliwka Polewa Bonbon Pie Muffin Jujubes. Tarta waflowa karmelowa tarta karmelowa niedŸwiedŸ pazur. Ciasto tarta tiramisu duñskie krople cytryny. Babeczki Brownie Dragée.",
                CategoryId = 3,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/christmasapplepie.jpg",
                InStock = true,
                IsPieOfTheWeek = false,
                ImageThumbnailUrl =
                    "https://gillcleerenpluralsight.blob.core.windows.net/files/christmasapplepiesmall.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                PieId = 6,
                Name = "Ciasto ¿urawinowe",
                Price = 17.95M,
                ShortDescription = "Ulubiony na œwiêta",
                LongDescription =
                    "Lukierowy ¿elkowy tort ¿elowy sernik. S³odka bu³ka marcepan marshmallow toffi brownie brownie tootsie roll. Ciasto Czekoladowe Piernik Tootsie Roll Owies Ciasto Ciasto Czekoladowe Ciastko Dragée Brownie. Lollipop Wata cukrowa ciasto niedŸwiedŸ pazur owsiane ciasto. Tarta deserowa z trzciny cukrowej Dragée. Marcepanowe dragée ¿elki lizakowe jujuby batoniki czekoladowe. Lukier chupa chupa chups wata cukrowa ciasteczko s³odki lukier bonbonowe ¿elki. Gummies Lollipop Brownie Biscuit Duñskie Ciasto Czekoladowe. Ciastko w proszku duñski makaronik czekoladowy p¹czek. Ciasto marchewkowe Dragée Rogalik Krople cytryny Lukrecja Krople cytryny Ciastko Lollipop Toffi. Ciasto marchewkowe Ciasto marchewkowe Lukrecja Cukier Œliwka Polewa Bonbon Pie Muffin Jujubes. Tarta waflowa karmelowa tarta karmelowa niedŸwiedŸ pazur. Ciasto tarta tiramisu duñskie krople cytryny. Babeczki Brownie Dragée.",
                CategoryId = 3,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cranberrypie.jpg",
                InStock = true,
                IsPieOfTheWeek = false,
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cranberrypiesmall.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                PieId = 7,
                Name = "Ciasto brzoskwiniowe",
                Price = 15.95M,
                ShortDescription = "S³odka jak brzoskwinia",
                LongDescription =
                    "Lukierowy ¿elkowy tort ¿elowy sernik. S³odka bu³ka marcepan marshmallow toffi brownie brownie tootsie roll. Ciasto Czekoladowe Piernik Tootsie Roll Owies Ciasto Ciasto Czekoladowe Ciastko Dragée Brownie. Lollipop Wata cukrowa ciasto niedŸwiedŸ pazur owsiane ciasto. Tarta deserowa z trzciny cukrowej Dragée. Marcepanowe dragée ¿elki lizakowe jujuby batoniki czekoladowe. Lukier chupa chupa chups wata cukrowa ciasteczko s³odki lukier bonbonowe ¿elki. Gummies Lollipop Brownie Biscuit Duñskie Ciasto Czekoladowe. Ciastko w proszku duñski makaronik czekoladowy p¹czek. Ciasto marchewkowe Dragée Rogalik Krople cytryny Lukrecja Krople cytryny Ciastko Lollipop Toffi. Ciasto marchewkowe Ciasto marchewkowe Lukrecja Cukier Œliwka Polewa Bonbon Pie Muffin Jujubes. Tarta waflowa karmelowa tarta karmelowa niedŸwiedŸ pazur. Ciasto tarta tiramisu duñskie krople cytryny. Babeczki Brownie Dragée.",
                CategoryId = 1,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/peachpie.jpg",
                InStock = false,
                IsPieOfTheWeek = false,
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/peachpiesmall.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                PieId = 8,
                Name = "Ciasto dyniowe",
                Price = 12.95M,
                ShortDescription = "Nasz ulubiony Halloween",
                LongDescription =
                    "Lukierowy ¿elkowy tort ¿elowy sernik. S³odka bu³ka marcepan marshmallow toffi brownie brownie tootsie roll. Ciasto Czekoladowe Piernik Tootsie Roll Owies Ciasto Ciasto Czekoladowe Ciastko Dragée Brownie. Lollipop Wata cukrowa ciasto niedŸwiedŸ pazur owsiane ciasto. Tarta deserowa z trzciny cukrowej Dragée. Marcepanowe dragée ¿elki lizakowe jujuby batoniki czekoladowe. Lukier chupa chupa chups wata cukrowa ciasteczko s³odki lukier bonbonowe ¿elki. Gummies Lollipop Brownie Biscuit Duñskie Ciasto Czekoladowe. Ciastko w proszku duñski makaronik czekoladowy p¹czek. Ciasto marchewkowe Dragée Rogalik Krople cytryny Lukrecja Krople cytryny Ciastko Lollipop Toffi. Ciasto marchewkowe Ciasto marchewkowe Lukrecja Cukier Œliwka Polewa Bonbon Pie Muffin Jujubes. Tarta waflowa karmelowa tarta karmelowa niedŸwiedŸ pazur. Ciasto tarta tiramisu duñskie krople cytryny. Babeczki Brownie Dragée.",
                CategoryId = 3,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpie.jpg",
                InStock = true,
                IsPieOfTheWeek = true,
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpiesmall.jpg",
                AllergyInformation = ""
            });


            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                PieId = 9,
                Name = "ciasto rabarbarowe",
                Price = 15.95M,
                ShortDescription = "Mój Bo¿e, taki s³odki!",
                LongDescription =
                    "Lukierowy ¿elkowy tort ¿elowy sernik. S³odka bu³ka marcepan marshmallow toffi brownie brownie tootsie roll. Ciasto Czekoladowe Piernik Tootsie Roll Owies Ciasto Ciasto Czekoladowe Ciastko Dragée Brownie. Lollipop Wata cukrowa ciasto niedŸwiedŸ pazur owsiane ciasto. Tarta deserowa z trzciny cukrowej Dragée. Marcepanowe dragée ¿elki lizakowe jujuby batoniki czekoladowe. Lukier chupa chupa chups wata cukrowa ciasteczko s³odki lukier bonbonowe ¿elki. Gummies Lollipop Brownie Biscuit Duñskie Ciasto Czekoladowe. Ciastko w proszku duñski makaronik czekoladowy p¹czek. Ciasto marchewkowe Dragée Rogalik Krople cytryny Lukrecja Krople cytryny Ciastko Lollipop Toffi. Ciasto marchewkowe Ciasto marchewkowe Lukrecja Cukier Œliwka Polewa Bonbon Pie Muffin Jujubes. Tarta waflowa karmelowa tarta karmelowa niedŸwiedŸ pazur. Ciasto tarta tiramisu duñskie krople cytryny. Babeczki Brownie Dragée.",
                CategoryId = 1,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpie.jpg",
                InStock = true,
                IsPieOfTheWeek = true,
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpiesmall.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                PieId = 10,
                Name = "Ciasto truskawkowe",
                Price = 15.95M,
                ShortDescription = "Nasze pyszne ciasto truskawkowe!",
                LongDescription =
                    "Lukierowy ¿elkowy tort ¿elowy sernik. S³odka bu³ka marcepan marshmallow toffi brownie brownie tootsie roll. Ciasto Czekoladowe Piernik Tootsie Roll Owies Ciasto Ciasto Czekoladowe Ciastko Dragée Brownie. Lollipop Wata cukrowa ciasto niedŸwiedŸ pazur owsiane ciasto. Tarta deserowa z trzciny cukrowej Dragée. Marcepanowe dragée ¿elki lizakowe jujuby batoniki czekoladowe. Lukier chupa chupa chups wata cukrowa ciasteczko s³odki lukier bonbonowe ¿elki. Gummies Lollipop Brownie Biscuit Duñskie Ciasto Czekoladowe. Ciastko w proszku duñski makaronik czekoladowy p¹czek. Ciasto marchewkowe Dragée Rogalik Krople cytryny Lukrecja Krople cytryny Ciastko Lollipop Toffi. Ciasto marchewkowe Ciasto marchewkowe Lukrecja Cukier Œliwka Polewa Bonbon Pie Muffin Jujubes. Tarta waflowa karmelowa tarta karmelowa niedŸwiedŸ pazur. Ciasto tarta tiramisu duñskie krople cytryny. Babeczki Brownie Dragée.",
                CategoryId = 1,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypie.jpg",
                InStock = true,
                IsPieOfTheWeek = false,
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypiesmall.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                PieId = 11,
                Name = "Sernik truskawkowy",
                Price = 18.95M,
                ShortDescription = "Pokochasz to!",
                LongDescription =
                    "Lukierowy ¿elkowy tort ¿elowy sernik. S³odka bu³ka marcepan marshmallow toffi brownie brownie tootsie roll. Ciasto Czekoladowe Piernik Tootsie Roll Owies Ciasto Ciasto Czekoladowe Ciastko Dragée Brownie. Lollipop Wata cukrowa ciasto niedŸwiedŸ pazur owsiane ciasto. Tarta deserowa z trzciny cukrowej Dragée. Marcepanowe dragée ¿elki lizakowe jujuby batoniki czekoladowe. Lukier chupa chupa chups wata cukrowa ciasteczko s³odki lukier bonbonowe ¿elki. Gummies Lollipop Brownie Biscuit Duñskie Ciasto Czekoladowe. Ciastko w proszku duñski makaronik czekoladowy p¹czek. Ciasto marchewkowe Dragée Rogalik Krople cytryny Lukrecja Krople cytryny Ciastko Lollipop Toffi. Ciasto marchewkowe Ciasto marchewkowe Lukrecja Cukier Œliwka Polewa Bonbon Pie Muffin Jujubes. Tarta waflowa karmelowa tarta karmelowa niedŸwiedŸ pazur. Ciasto tarta tiramisu duñskie krople cytryny. Babeczki Brownie Dragée.",
                CategoryId = 2,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrycheesecake.jpg",
                InStock = false,
                IsPieOfTheWeek = false,
                ImageThumbnailUrl =
                    "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrycheesecakesmall.jpg",
                AllergyInformation = ""
            });
        }
        
    }
}