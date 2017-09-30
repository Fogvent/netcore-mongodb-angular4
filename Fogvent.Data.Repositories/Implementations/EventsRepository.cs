using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Fogvent.Data.Common;
using Fogvent.Data.Repositories.Interfaces;
using Fogvent.Models.Entities;

namespace Fogvent.Data.Repositories.Implementations
{
    public class EventsRepository:IEventsRepository
    {
        private IUnitOfWork _unitOfWork;
        public EventsRepository(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        public IEnumerable<Event> GetAllEvents()
        {
            throw new NotImplementedException();
        }

        public Event GetEvent()
        {
            throw new NotImplementedException();
        }
    }
}
