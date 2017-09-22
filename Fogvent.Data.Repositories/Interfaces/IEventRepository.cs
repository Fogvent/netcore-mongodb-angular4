using System.Collections.Generic;
using Fogvent.Data.Common;
using Fogvent.Models.Entities;

namespace Fogvent.Data.Repositories.Interfaces
{
    public interface IEventRepository
    {
        IEnumerable<Event> GetAllEvents();
        Event GetEvent();
    }
}
