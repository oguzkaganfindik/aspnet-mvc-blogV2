using App.Web.Mvc.Data.Entity;
using App.Web.Mvc.Models;
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
					UserName = "Teoman",
					UserSurname = "Yakupoğlu",
					UserEmail = "Teo@xyz.com",
					UserPassword = "123456"
				},
				new User
				{
					Id = 2,
					UserName = "Sebnem",
					UserSurname = "Ferah",
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

			////Post Image
			//modelBuilder.Entity<PostImage>().HasData(
			//		new PostImage
			//		{
			//			Id = 1,
			//			PostId = 1,
			//			ImageUrl = "../images/slider/slider1.jpg",

			//		},
			//		new PostImage
			//		{
			//			Id = 2,
			//			PostId = 2,
			//			ImageUrl = "../images/slider/slider2.jpg",
			//		}
			//		);

		}
	}

    public class DataBase
    {
        public List<SliderViewModel> SliderItems { get; set; }

        public List<PostItemViewModel> PostItem { get; set; }

        public DataBase()
        {
            SliderItems = new List<SliderViewModel>()
            {
                new SliderViewModel()
                {
                    Name = "Trip to California",
                    Title= "Travel",
                    ImageUrl= "dist/images/slider/slider1.jpg",
                    Date = "January 2, 2023"
                },

                new SliderViewModel()
                {
                    Name = "Our Favorite Weekend Getaways",
                    Title= "Weekends",
                    ImageUrl= "dist/images/slider/slider2.jpg",
                    Date = "September 15, 2019"
                },
                new SliderViewModel()
                {
                    Name = "Tips for Taking a Long-term Trip",
                    Title= "LifeStyle",
                    ImageUrl= "dist/images/slider/slider3.jpg",
                    Date = "June 12, 2019"
                },

                new SliderViewModel()
                {
                    Name = "Tips for Taking a Long-term Trip",
                    Title= "LifeStyle",
                    ImageUrl= "dist/images/slider/slider1.jpg",
                    Date = "September 18, 2022"
                },
                new SliderViewModel()
                {
                    Name = "Tips for Taking a Long-term Trip",
                    Title= "LifeStyle",
                    ImageUrl= "dist/images/slider/slider2.jpg",
                    Date = "September 21, 2023"
                },
            };
            PostItem = new List<PostItemViewModel>()
            {
                new PostItemViewModel(){Title="Explore" ,Name="The best place to explore to enjoy",Date="June 15, 2019" ,ImageUrl="dist/images/news/f1.jpg" },
                new PostItemViewModel(){Title="Lifestyle" ,Name="How to Make list for travelling alone",Date="September 15, 2019" ,ImageUrl="dist/images/news/f2.jpg" },
                new PostItemViewModel(){Title="Food" ,Name="5 ingredient cilantro vinaigrette",Date="September 15, 2019"  ,ImageUrl="dist/images/news/f3.jpg"},
                new PostItemViewModel(){Title="Explore" ,Name="A Simple Way to Feel Like Home When You Travel",Date="March 20, 2019"  ,ImageUrl="dist/images/news/f4.jpg"},
                new PostItemViewModel(){Title="March 20, 2019" ,Name="What Type of Traveller Are You?",Date="September 15, 2019" ,ImageUrl="dist/images/news/f5.jpg"},
                new PostItemViewModel(){Title="Experience" ,Name="A Road Trip Review of the 2018",Date="July 10, 2019" ,ImageUrl="dist/images/news/f6.jpg" },
                new PostItemViewModel(){Title="music" ,Name="Portugal’s Sunset summer vission",Date="September 15, 2019" ,ImageUrl="dist/images/news/f7.jpg" },
                new PostItemViewModel(){Title="beauty" ,Name="The best soft Tropical Getaway",Date="March 12, 2019"  ,ImageUrl="dist/images/news/f8.jpg"},
                new PostItemViewModel(){Title="Travel" ,Name="Memoriable Paris Girls Trip",Date="April 19, 2019"  ,ImageUrl="dist/images/news/f9.jpg"},
                new PostItemViewModel(){Title="Experience" ,Name="How to Plan your Trip the Right Way" ,Date="February 15, 2019",ImageUrl="dist/images/news/f5.jpg"},
                new PostItemViewModel(){Title="Travel" ,Name="8 Powerful Ways to Add Vibrant Colour to Your Life" ,Date="April 19, 2019"  ,ImageUrl="dist/images/news/f7.jpg"},
                new PostItemViewModel(){Title="Lifestyle" ,Name="The best to-do list to help boost your productivity" ,Date="October 2, 2019",ImageUrl="dist/images/news/f2.jpg"}
            };

        }
    }

}
