using App1.DTOs;
using App1.Entities;
using App1.Helpers;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace App1.Interfaces
{
    public interface IMessageRepository
    {
        void AddMessage(Message message);
        void DeleteMessage(Message message);

        Task<Message> GetMessage(int id);
        Task<PagedList<MessageDto>> GetMessagesForUser(MessageParams messageParams);
        Task<IEnumerable<MessageDto>> GetmessageThread(string currentUserName, string recipientUserName);
        Task<bool> SaveAllAsync();


    }
}
