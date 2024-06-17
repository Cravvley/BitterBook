using Domain;
using MediatR;
using Persistence;

namespace Application.Posts
{
    public class Create
    {
        public class Commands:IRequest{
            public Post Post {get;set;}
        }
        public class Handler : IRequestHandler<Commands>
        {

            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;
            }
        
            public async Task Handle(Commands request, CancellationToken cancellationToken)
            {
                _context.Add(request.Post);

                await _context.SaveChangesAsync();
            }
        }
    }
}