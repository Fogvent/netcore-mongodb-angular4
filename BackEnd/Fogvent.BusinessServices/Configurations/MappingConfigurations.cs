using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fogvent.BusinessServices.Configurations
{
    public class MappingConfigurations
    {
        public static void Configure()
        {
            Mapper.Initialize(config =>
            {
                #region From Binding Models to Entity
                config.CreateMap<BindingModels.Customer, Entities.Customer>();
                config.CreateMap<BindingModels.Order, Entities.Order>();
                #endregion

                #region From Entity to View Model
                config.CreateMap<Entities.Customer, ViewModels.CustomerDetails>();
                config.CreateMap<Entities.Order, ViewModels.Order>()
                .ForMember(dest => dest.CustomerName, opts => opts.MapFrom(src => src.Customer.ContactName));
                #endregion

            });
        }
    }
}
