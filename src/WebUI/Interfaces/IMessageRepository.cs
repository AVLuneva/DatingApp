using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.DTOs;
using WebUI.Entities;
using WebUI.Helpers;

namespace WebUI.Interfaces
{
    public interface IMessageRepository
    {
        void AddMessage(Message message);
        void DeleteMessage(Message message);
        Task<Message> GetMessage(int id);
        Task<PagedList<MessageDto>> GetMessagesForUser(MessageParams messageParams);
        Task<IEnumerable<MessageDto>> GetMessageThread(int currentUserId, int recipientId);
        Task<bool> SaveAllAsync();
    }
}