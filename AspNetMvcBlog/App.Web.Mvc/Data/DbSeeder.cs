using App.Web.Mvc.Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace App.Web.Mvc.Data
{
    public class DbSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            //Category
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    CategoryName = "Technology"
                },
                new Category
                {
                    Id = 2,
                    CategoryName = "Nature"
                }
                );
            //User
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    UserName = "Oğuzkağan",
                    UserSurname = "Fındık",
                    UserNick = "Ogz",
                    UserEmail = "oguzkagan@xyz.com",
                    UserPassword = "123456"
                },
                new User
                {
                    Id = 2,
                    UserName = "Sebnem",
                    UserSurname = "Ferah",
                    UserNick = "Sebo",
                    UserEmail = "sebnem@xyz.com",
                    UserPassword = "123456"
                }
                );
            //Post
            modelBuilder.Entity<Post>().HasData(
                new Post
                {
                    Id = 1,
                    PostTitle = "Lorem ipsum dolor sit amet.",
                    PostContext = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce elementum, enim et dapibus efficitur, augue augue blandit ex, et scelerisque orci felis quis massa. Donec viverra risus augue, ac auctor nisl ultrices id. Aliquam luctus mauris vitae laoreet ullamcorper. Mauris suscipit nisl sapien, sed auctor arcu feugiat vel. Integer rhoncus, diam sed consectetur dignissim, elit nibh eleifend eros, et eleifend risus augue id ante. Aenean eu risus scelerisque, mollis nulla at, finibus felis. Nulla blandit ipsum eget leo eleifend lobortis. Nulla in fringilla sem. Phasellus accumsan vitae tortor non tincidunt. Sed convallis, augue sit amet aliquet tempor, eros eros fringilla libero, ultrices placerat urna augue eu nisl. Praesent suscipit viverra nulla, sed condimentum ante iaculis eget. Nam auctor faucibus metus, non gravida leo pellentesque et.",
                    UserId = 1
                },
                 new Post
                 {
                     Id = 2,
                     PostTitle = "Consectetur adipiscing.",
                     PostContext = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin vulputate id nisi tristique ullamcorper. Vestibulum aliquam ipsum ac diam lacinia, vitae posuere urna efficitur. Cras tempus quam ut condimentum iaculis. Donec euismod enim et tristique feugiat. Suspendisse non malesuada eros. Nulla id enim sit amet orci fringilla interdum. Etiam ultricies pharetra elit, eget vulputate odio. Fusce facilisis in lacus id lacinia. In ex lacus, convallis nec sapien non, placerat consectetur ipsum. Quisque cursus ligula id ullamcorper sagittis. Vivamus ultricies mollis augue. Nunc vel erat vitae purus vestibulum egestas.",
                     UserId = 2
                 }
                );

        }
    }
}
