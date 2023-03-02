using ChatApplication.Interfaces;
using ChatData.Models;
using MediatR;

namespace ChatApplication.Common.Messages.Command.CreateMessageCommand
{
    public class CreateMessageCommandHandler : IRequestHandler<CreateMessageCommand, Guid>
    {
        private readonly IMessageDbContext _dbContext;

        public CreateMessageCommandHandler(IMessageDbContext context)
        {
            _dbContext = context;
        }

        public async Task<Guid> Handle(CreateMessageCommand request, CancellationToken cancellationToken)
        {
            var message = new Message
            {
                UserId = request.UserId,
                Content = request.Content,
                Id = Guid.NewGuid(),
                Created = DateTime.Now
            };

            await _dbContext.Message.AddAsync(message);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return message.Id;
        }
    }
}
