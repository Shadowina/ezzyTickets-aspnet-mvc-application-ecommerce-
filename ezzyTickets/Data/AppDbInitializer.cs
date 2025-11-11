using ezzyTickets.Data.Enums;
using ezzyTickets.Data.Static;
using ezzyTickets.Models;
using Microsoft.AspNetCore.Identity;

namespace ezzyTickets.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                if (context != null)
                {
                    context.Database.EnsureCreated();

                    // Update existing movie dates to ensure they are current
                    UpdateMovieDates(context);

                    //Cinema
                    if (!context.Cinemas.Any())
                    {
                        context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Name = "Cinema 1",
                            Logo = "https://placehold.co/400x400?text=Cinema+1",
                            Description = "This is the description of the first cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 2",
                            Logo = "https://placehold.co/400x400?text=Cinema+2",
                            Description = "This is the description of the first cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 3",
                            Logo = "https://placehold.co/400x400?text=Cinema+3",
                            Description = "This is the description of the first cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 4",
                            Logo = "https://placehold.co/400x400?text=Cinema+4",
                            Description = "This is the description of the first cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 5",
                            Logo = "https://placehold.co/400x400?text=Cinema+5",
                            Description = "This is the description of the first cinema"
                        },
                    });

                        context.SaveChanges();

                    }

                    //Actors 
                    if (!context.Actors.Any())
                    {
                        context.Actors.AddRange(new List<Actor>()
                    {
                         new Actor()
                        {
                            FullName = "Actor 1",
                            Bio = "This is the Bio of the first actor",
                            ProfilePictureURL = "https://placehold.co/400x400?text=Actor+1"

                        },
                        new Actor()
                        {
                            FullName = "Actor 2",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "https://placehold.co/400x400?text=Actor+2"
                        },
                        new Actor()
                        {
                            FullName = "Actor 3",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "https://placehold.co/400x400?text=Actor+3"
                        },
                        new Actor()
                        {
                            FullName = "Actor 4",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "https://placehold.co/400x400?text=Actor+4"
                        },
                        new Actor()
                        {
                            FullName = "Actor 5",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "https://placehold.co/400x400?text=Actor+5"
                        }
                    });

                        context.SaveChanges();
                    }

                    //Producers
                    if (!context.Producers.Any())
                    {
                        context.Producers.AddRange(new List<Producer>()
                    {
                         new Producer()
                        {
                            FullName = "Producer 1",
                            Bio = "This is the Bio of the first actor",
                            ProfilePictureURL = "https://placehold.co/400x400?text=Producer+1"

                        },
                        new Producer()
                        {
                            FullName = "Producer 2",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "https://placehold.co/400x400?text=Producer+2"
                        },
                        new Producer()
                        {
                            FullName = "Producer 3",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "https://placehold.co/400x400?text=Producer+3"
                        },
                        new Producer()
                        {
                            FullName = "Producer 4",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "https://placehold.co/400x400?text=Producer+4"
                        },
                        new Producer()
                        {
                            FullName = "Producer 5",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "https://placehold.co/400x400?text=Producer+5"
                        }
                    });
                        context.SaveChanges();
                    }

                    //Movies
                    if (!context.Movies.Any())
                    {
                        context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Name = "Life",
                            Description = "This is the Life movie description",
                            Price = 39.50,
                            ImageURL = "https://placehold.co/600x900?text=Life",
                            StartDate = DateTime.Now.AddDays(-5),
                            EndDate = DateTime.Now.AddDays(15),
                            CinemaId = 3,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Documentary
                        },
                        new Movie()
                        {
                            Name = "The Shawshank Redemption",
                            Description = "This is the Shawshank Redemption description",
                            Price = 29.50,
                            ImageURL = "https://placehold.co/600x900?text=Shawshank",
                            StartDate = DateTime.Now.AddDays(-2),
                            EndDate = DateTime.Now.AddDays(8),
                            CinemaId = 1,
                            ProducerId = 1,
                            MovieCategory = MovieCategory.Action
                        },
                        new Movie()
                        {
                            Name = "Ghost",
                            Description = "This is the Ghost movie description",
                            Price = 39.50,
                            ImageURL = "https://placehold.co/600x900?text=Ghost",
                            StartDate = DateTime.Now.AddDays(-1),
                            EndDate = DateTime.Now.AddDays(12),
                            CinemaId = 4,
                            ProducerId = 4,
                            MovieCategory = MovieCategory.Horror
                        },
                        new Movie()
                        {
                            Name = "Race",
                            Description = "This is the Race movie description",
                            Price = 39.50,
                            ImageURL = "https://placehold.co/600x900?text=Race",
                            StartDate = DateTime.Now.AddDays(-3),
                            EndDate = DateTime.Now.AddDays(5),
                            CinemaId = 1,
                            ProducerId = 2,
                            MovieCategory = MovieCategory.Documentary
                        },
                        new Movie()
                        {
                            Name = "Scoob",
                            Description = "This is the Scoob movie description",
                            Price = 39.50,
                            ImageURL = "https://placehold.co/600x900?text=Scoob",
                            StartDate = DateTime.Now.AddDays(-2),
                            EndDate = DateTime.Now.AddDays(10),
                            CinemaId = 1,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Cartoon
                        },
                        new Movie()
                        {
                            Name = "Cold Soles",
                            Description = "This is the Cold Soles movie description",
                            Price = 39.50,
                            ImageURL = "https://placehold.co/600x900?text=Cold+Soles",
                            StartDate = DateTime.Now.AddDays(1),
                            EndDate = DateTime.Now.AddDays(25),
                            CinemaId = 1,
                            ProducerId = 5,
                            MovieCategory = MovieCategory.Drama
                        }

                    });

                        context.SaveChanges();
                    }

                    //Actors & Movies
                    if (!context.Actors_Movies.Any())
                    {
                        context.Actors_Movies.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 1
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 1
                        },

                         new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 2
                        },
                         new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 2
                        },

                         new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 3
                        },
                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 3
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 3
                        },

                         new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 4
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 4
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 4
                        },

                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 5
                        },


                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 6
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 6
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 6
                        },
                    });

                        context.SaveChanges();

                    }
                }
            }
        }

        private static void UpdateMovieDates(AppDbContext context)
        {
            var movies = context.Movies.ToList();
            if (movies.Any())
            {
                // Update movie dates to ensure they are current
                var movieUpdates = new Dictionary<string, (DateTime startDate, DateTime endDate)>
                {
                    { "Life", (DateTime.Now.AddDays(-5), DateTime.Now.AddDays(15)) },
                    { "The Shawshank Redemption", (DateTime.Now.AddDays(-2), DateTime.Now.AddDays(8)) },
                    { "Ghost", (DateTime.Now.AddDays(-1), DateTime.Now.AddDays(12)) },
                    { "Race", (DateTime.Now.AddDays(-3), DateTime.Now.AddDays(5)) },
                    { "Scoob", (DateTime.Now.AddDays(-2), DateTime.Now.AddDays(10)) },
                    { "Cold Soles", (DateTime.Now.AddDays(1), DateTime.Now.AddDays(25)) }
                };

                foreach (var movie in movies)
                {
                    if (movieUpdates.ContainsKey(movie.Name))
                    {
                        var (startDate, endDate) = movieUpdates[movie.Name];
                        movie.StartDate = startDate;
                        movie.EndDate = endDate;
                    }
                }

                context.SaveChanges();
            }
        }

        public static async Task SeedUsersAndRolesAsync(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {

                //Roles
                var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

                if (!await roleManager.RoleExistsAsync(UserRoles.Admin))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
                if (!await roleManager.RoleExistsAsync(UserRoles.User))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.User));

                //Users
                var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
                string adminUserEmail = "admin@etickets.com";

                var adminUser = await userManager.FindByEmailAsync(adminUserEmail);
                if (adminUser == null)
                {
                    var newAdminUser = new ApplicationUser()
                    {
                        FullName = "Admin User",
                        UserName = "admin-user",
                        Email = adminUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAdminUser, "Coding@1234?");
                    await userManager.AddToRoleAsync(newAdminUser, UserRoles.Admin);
                }


                string appUserEmail = "user@etickets.com";

                var appUser = await userManager.FindByEmailAsync(appUserEmail);
                if (appUser == null)
                {
                    var newAppUser = new ApplicationUser()
                    {
                        FullName = "Application User",
                        UserName = "app-user",
                        Email = appUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAppUser, "Coding@1234?");
                    await userManager.AddToRoleAsync(newAppUser, UserRoles.User);
                }
            }
        }
    }
}
