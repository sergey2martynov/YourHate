using MediatR;

namespace ChatApplication.Common.Messages.Command.CreateMessageCommand
{
    public class CreateMessageCommand : IRequest<Guid>
    {
        public Guid UserId { get; set; }
        public string Content { get; set; }

    }
}
