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
                ShortDescription = "Nasze s�ynne szarlotki!",
                LongDescription =
                    "Lodowaty placek z galaretki o-marchewkowy. S�odka bu�ka marcepan marshmallow toffi brownie brownie cukierek tootsie roll. Ciasto czekoladowe piernik tootsie bu�ka owsiane ciasto ciasto czekoladowe ciasteczko ciastko drag�e brownie. Lollipop wata cukrowa ciasto nied�wied� pazur owies ciasto. Drag�e cukierki laski deserowe tarta. Marcepan �elki drag�e lizak jujuby batoniki czekoladowe laski. lukier piernik chupa chups wata cukrowa ciasteczko s�odki lukier �elki �elki �elki �elki ciasteczko du�skie ciastko czekoladowe du�skie ciastko w proszku makaronik czekoladowy p�czek tarta ciasto marchewkowe dr�b rogalik krople cytryny lukrecja krople cytryny ciastko lollipop toffi. Ciasto marchewkowe Ciasto marchewkowe Lukrecja Cukier �liwka Polewa Bonbon Pie Muffin Jujubes. Galaretka Ciasto Waflowe Tarta Karmel Nied�wied� Pazur. Tiramisu Tarta Ciasto Du�skie Krople Cytryny. Brownie Babeczka Drag�e �elki. ",
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
                    "Lodowaty placek z galaretki o-marchewkowy. S�odka bu�ka marcepan marshmallow toffi brownie brownie cukierek tootsie roll. Ciasto czekoladowe piernik tootsie bu�ka owsiane ciasto ciasto czekoladowe ciasteczko ciastko drag�e brownie. Lollipop wata cukrowa ciasto nied�wied� pazur owies ciasto. Drag�e cukierki laski deserowe tarta. Marcepan �elki drag�e lizak jujuby batoniki czekoladowe laski. lukier piernik chupa chups wata cukrowa ciasteczko s�odki lukier �elki �elki �elki �elki ciasteczko du�skie ciastko czekoladowe du�skie ciastko w proszku makaronik czekoladowy p�czek tarta ciasto marchewkowe dr�b rogalik krople cytryny lukrecja krople cytryny ciastko lollipop toffi. Ciasto marchewkowe Ciasto marchewkowe Lukrecja Cukier �liwka Polewa Bonbon Pie Muffin Jujubes. Galaretka Ciasto Waflowe Tarta Karmel Nied�wied� Pazur. Tiramisu Tarta Ciasto Du�skie Krople Cytryny. Brownie Babeczka Drag�e �elki. ",
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
                ShortDescription = "Zwyk�y sernik. Zwyk�a przyjemno��.",
                LongDescription =
                    "Lukierowy �elkowy tort �elowy sernik. S�odka bu�ka marcepan marshmallow toffi brownie brownie tootsie roll. Ciasto Czekoladowe Piernik Tootsie Roll Owies Ciasto Ciasto Czekoladowe Ciastko Drag�e Brownie. Lollipop Wata cukrowa ciasto nied�wied� pazur owsiane ciasto. Tarta deserowa z trzciny cukrowej Drag�e. Marcepanowe drag�e �elki lizakowe jujuby batoniki czekoladowe. Lukier chupa chupa chups wata cukrowa ciasteczko s�odki lukier bonbonowe �elki. Gummies Lollipop Brownie Biscuit Du�skie Ciasto Czekoladowe. Ciastko w proszku du�ski makaronik czekoladowy p�czek. Ciasto marchewkowe Drag�e Rogalik Krople cytryny Lukrecja Krople cytryny Ciastko Lollipop Toffi. Ciasto marchewkowe Ciasto marchewkowe Lukrecja Cukier �liwka Polewa Bonbon Pie Muffin Jujubes. Tarta waflowa karmelowa tarta karmelowa nied�wied� pazur. Ciasto tarta tiramisu du�skie krople cytryny. Babeczki Brownie Drag�e.",
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
                Name = "Placek wi�niowy",
                Price = 15.95M,
                ShortDescription = "Letni klasyk!",
                LongDescription =
                    "Lukierowy �elkowy tort �elowy sernik. S�odka bu�ka marcepan marshmallow toffi brownie brownie tootsie roll. Ciasto Czekoladowe Piernik Tootsie Roll Owies Ciasto Ciasto Czekoladowe Ciastko Drag�e Brownie. Lollipop Wata cukrowa ciasto nied�wied� pazur owsiane ciasto. Tarta deserowa z trzciny cukrowej Drag�e. Marcepanowe drag�e �elki lizakowe jujuby batoniki czekoladowe. Lukier chupa chupa chups wata cukrowa ciasteczko s�odki lukier bonbonowe �elki. Gummies Lollipop Brownie Biscuit Du�skie Ciasto Czekoladowe. Ciastko w proszku du�ski makaronik czekoladowy p�czek. Ciasto marchewkowe Drag�e Rogalik Krople cytryny Lukrecja Krople cytryny Ciastko Lollipop Toffi. Ciasto marchewkowe Ciasto marchewkowe Lukrecja Cukier �liwka Polewa Bonbon Pie Muffin Jujubes. Tarta waflowa karmelowa tarta karmelowa nied�wied� pazur. Ciasto tarta tiramisu du�skie krople cytryny. Babeczki Brownie Drag�e.",
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
                Name = "�wi�teczna Szarlotka",
                Price = 13.95M,
                ShortDescription = "Weso�ych �wi�t z tym ciastem!",
                LongDescription =
                    "Lukierowy �elkowy tort �elowy sernik. S�odka bu�ka marcepan marshmallow toffi brownie brownie tootsie roll. Ciasto Czekoladowe Piernik Tootsie Roll Owies Ciasto Ciasto Czekoladowe Ciastko Drag�e Brownie. Lollipop Wata cukrowa ciasto nied�wied� pazur owsiane ciasto. Tarta deserowa z trzciny cukrowej Drag�e. Marcepanowe drag�e �elki lizakowe jujuby batoniki czekoladowe. Lukier chupa chupa chups wata cukrowa ciasteczko s�odki lukier bonbonowe �elki. Gummies Lollipop Brownie Biscuit Du�skie Ciasto Czekoladowe. Ciastko w proszku du�ski makaronik czekoladowy p�czek. Ciasto marchewkowe Drag�e Rogalik Krople cytryny Lukrecja Krople cytryny Ciastko Lollipop Toffi. Ciasto marchewkowe Ciasto marchewkowe Lukrecja Cukier �liwka Polewa Bonbon Pie Muffin Jujubes. Tarta waflowa karmelowa tarta karmelowa nied�wied� pazur. Ciasto tarta tiramisu du�skie krople cytryny. Babeczki Brownie Drag�e.",
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
                Name = "Ciasto �urawinowe",
                Price = 17.95M,
                ShortDescription = "Ulubiony na �wi�ta",
                LongDescription =
                    "Lukierowy �elkowy tort �elowy sernik. S�odka bu�ka marcepan marshmallow toffi brownie brownie tootsie roll. Ciasto Czekoladowe Piernik Tootsie Roll Owies Ciasto Ciasto Czekoladowe Ciastko Drag�e Brownie. Lollipop Wata cukrowa ciasto nied�wied� pazur owsiane ciasto. Tarta deserowa z trzciny cukrowej Drag�e. Marcepanowe drag�e �elki lizakowe jujuby batoniki czekoladowe. Lukier chupa chupa chups wata cukrowa ciasteczko s�odki lukier bonbonowe �elki. Gummies Lollipop Brownie Biscuit Du�skie Ciasto Czekoladowe. Ciastko w proszku du�ski makaronik czekoladowy p�czek. Ciasto marchewkowe Drag�e Rogalik Krople cytryny Lukrecja Krople cytryny Ciastko Lollipop Toffi. Ciasto marchewkowe Ciasto marchewkowe Lukrecja Cukier �liwka Polewa Bonbon Pie Muffin Jujubes. Tarta waflowa karmelowa tarta karmelowa nied�wied� pazur. Ciasto tarta tiramisu du�skie krople cytryny. Babeczki Brownie Drag�e.",
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
                ShortDescription = "S�odka jak brzoskwinia",
                LongDescription =
                    "Lukierowy �elkowy tort �elowy sernik. S�odka bu�ka marcepan marshmallow toffi brownie brownie tootsie roll. Ciasto Czekoladowe Piernik Tootsie Roll Owies Ciasto Ciasto Czekoladowe Ciastko Drag�e Brownie. Lollipop Wata cukrowa ciasto nied�wied� pazur owsiane ciasto. Tarta deserowa z trzciny cukrowej Drag�e. Marcepanowe drag�e �elki lizakowe jujuby batoniki czekoladowe. Lukier chupa chupa chups wata cukrowa ciasteczko s�odki lukier bonbonowe �elki. Gummies Lollipop Brownie Biscuit Du�skie Ciasto Czekoladowe. Ciastko w proszku du�ski makaronik czekoladowy p�czek. Ciasto marchewkowe Drag�e Rogalik Krople cytryny Lukrecja Krople cytryny Ciastko Lollipop Toffi. Ciasto marchewkowe Ciasto marchewkowe Lukrecja Cukier �liwka Polewa Bonbon Pie Muffin Jujubes. Tarta waflowa karmelowa tarta karmelowa nied�wied� pazur. Ciasto tarta tiramisu du�skie krople cytryny. Babeczki Brownie Drag�e.",
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
                    "Lukierowy �elkowy tort �elowy sernik. S�odka bu�ka marcepan marshmallow toffi brownie brownie tootsie roll. Ciasto Czekoladowe Piernik Tootsie Roll Owies Ciasto Ciasto Czekoladowe Ciastko Drag�e Brownie. Lollipop Wata cukrowa ciasto nied�wied� pazur owsiane ciasto. Tarta deserowa z trzciny cukrowej Drag�e. Marcepanowe drag�e �elki lizakowe jujuby batoniki czekoladowe. Lukier chupa chupa chups wata cukrowa ciasteczko s�odki lukier bonbonowe �elki. Gummies Lollipop Brownie Biscuit Du�skie Ciasto Czekoladowe. Ciastko w proszku du�ski makaronik czekoladowy p�czek. Ciasto marchewkowe Drag�e Rogalik Krople cytryny Lukrecja Krople cytryny Ciastko Lollipop Toffi. Ciasto marchewkowe Ciasto marchewkowe Lukrecja Cukier �liwka Polewa Bonbon Pie Muffin Jujubes. Tarta waflowa karmelowa tarta karmelowa nied�wied� pazur. Ciasto tarta tiramisu du�skie krople cytryny. Babeczki Brownie Drag�e.",
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
                ShortDescription = "M�j Bo�e, taki s�odki!",
                LongDescription =
                    "Lukierowy �elkowy tort �elowy sernik. S�odka bu�ka marcepan marshmallow toffi brownie brownie tootsie roll. Ciasto Czekoladowe Piernik Tootsie Roll Owies Ciasto Ciasto Czekoladowe Ciastko Drag�e Brownie. Lollipop Wata cukrowa ciasto nied�wied� pazur owsiane ciasto. Tarta deserowa z trzciny cukrowej Drag�e. Marcepanowe drag�e �elki lizakowe jujuby batoniki czekoladowe. Lukier chupa chupa chups wata cukrowa ciasteczko s�odki lukier bonbonowe �elki. Gummies Lollipop Brownie Biscuit Du�skie Ciasto Czekoladowe. Ciastko w proszku du�ski makaronik czekoladowy p�czek. Ciasto marchewkowe Drag�e Rogalik Krople cytryny Lukrecja Krople cytryny Ciastko Lollipop Toffi. Ciasto marchewkowe Ciasto marchewkowe Lukrecja Cukier �liwka Polewa Bonbon Pie Muffin Jujubes. Tarta waflowa karmelowa tarta karmelowa nied�wied� pazur. Ciasto tarta tiramisu du�skie krople cytryny. Babeczki Brownie Drag�e.",
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
                    "Lukierowy �elkowy tort �elowy sernik. S�odka bu�ka marcepan marshmallow toffi brownie brownie tootsie roll. Ciasto Czekoladowe Piernik Tootsie Roll Owies Ciasto Ciasto Czekoladowe Ciastko Drag�e Brownie. Lollipop Wata cukrowa ciasto nied�wied� pazur owsiane ciasto. Tarta deserowa z trzciny cukrowej Drag�e. Marcepanowe drag�e �elki lizakowe jujuby batoniki czekoladowe. Lukier chupa chupa chups wata cukrowa ciasteczko s�odki lukier bonbonowe �elki. Gummies Lollipop Brownie Biscuit Du�skie Ciasto Czekoladowe. Ciastko w proszku du�ski makaronik czekoladowy p�czek. Ciasto marchewkowe Drag�e Rogalik Krople cytryny Lukrecja Krople cytryny Ciastko Lollipop Toffi. Ciasto marchewkowe Ciasto marchewkowe Lukrecja Cukier �liwka Polewa Bonbon Pie Muffin Jujubes. Tarta waflowa karmelowa tarta karmelowa nied�wied� pazur. Ciasto tarta tiramisu du�skie krople cytryny. Babeczki Brownie Drag�e.",
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
                    "Lukierowy �elkowy tort �elowy sernik. S�odka bu�ka marcepan marshmallow toffi brownie brownie tootsie roll. Ciasto Czekoladowe Piernik Tootsie Roll Owies Ciasto Ciasto Czekoladowe Ciastko Drag�e Brownie. Lollipop Wata cukrowa ciasto nied�wied� pazur owsiane ciasto. Tarta deserowa z trzciny cukrowej Drag�e. Marcepanowe drag�e �elki lizakowe jujuby batoniki czekoladowe. Lukier chupa chupa chups wata cukrowa ciasteczko s�odki lukier bonbonowe �elki. Gummies Lollipop Brownie Biscuit Du�skie Ciasto Czekoladowe. Ciastko w proszku du�ski makaronik czekoladowy p�czek. Ciasto marchewkowe Drag�e Rogalik Krople cytryny Lukrecja Krople cytryny Ciastko Lollipop Toffi. Ciasto marchewkowe Ciasto marchewkowe Lukrecja Cukier �liwka Polewa Bonbon Pie Muffin Jujubes. Tarta waflowa karmelowa tarta karmelowa nied�wied� pazur. Ciasto tarta tiramisu du�skie krople cytryny. Babeczki Brownie Drag�e.",
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