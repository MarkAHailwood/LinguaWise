using System.Collections.Generic;
using System.Threading.Tasks;
using VideoChat.Models;

namespace VideoChat.Services
{
    public interface IVideoService
    {
        string GetTwilioJwt(string identity);
        Task<IEnumerable<RoomDetails>> GetAllRoomsAsync();
    }
}
