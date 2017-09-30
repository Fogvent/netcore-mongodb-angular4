using System.Collections.Generic;
using Fogvent.Models.Entities;

namespace Fogvent.Data.Repositories.Interfaces
{
    public interface IEventsRepository
    {
        IEnumerable<Event> GetAllEvents();
        Event GetEvent();
    }
}
