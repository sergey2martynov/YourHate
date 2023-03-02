using AutoMapper;
using ChatData.Models;

namespace ChatApplication.Common.Messages.Queries.GetMessage
{
    public class MessageViewModel
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public DateTime Created { get; set; }
        public int LikeCount { get; set; }
        public string Content { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Message, MessageViewModel>()
                .ForMember(messageVm => messageVm.Id,
                opt => opt.MapFrom(message => message.Id))
                .ForMember(messageVm => messageVm.Content,
                opt => opt.MapFrom(message => message.Content))
                .ForMember(messageVm => messageVm.UserId,
                opt => opt.MapFrom(message => message.UserId))
                .ForMember(messageVm => messageVm.Created,
                opt => opt.MapFrom(message => message.Created))
                .ForMember(messageVm => messageVm.LikeCount,
                opt => opt.MapFrom(message => message.LikeCount));
        }
    }
}
