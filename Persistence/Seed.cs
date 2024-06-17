using Domain;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context){
            if(context.Posts.Any()) return;

            var posts = new List<Post>
            {
                new Post
                {
                   Title="xd",
                   Content = "xd"
                },
                new Post
                {
                   Title="xd2",
                   Content = "xd2"
                }
            };

            await context.Posts.AddRangeAsync(posts);
            await context.SaveChangesAsync();
        }
    }
}