using Application.Posts;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class PostsController:BaseApiController
    {

        [HttpGet]
        public async Task<ActionResult<List<Post>>> GetPosts() => await Mediator.Send(new List.Query());

        [HttpGet("{id}")]
        public async Task<ActionResult<Post>> GetPost(Guid id) => await Mediator.Send(new Details.Query{Id=id});
    } 
}   