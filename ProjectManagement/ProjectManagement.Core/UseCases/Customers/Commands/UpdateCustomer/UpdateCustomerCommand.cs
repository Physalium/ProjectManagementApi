﻿using Domain.Entities;
using MediatR;
using ProjectManagement.Core.Base.Mappings;

namespace ProjectManagement.Core.UseCases.Customers.Commands.UpdateCustomer
{
    public class UpdateCustomerCommand : IRequest<UpdateCustomerCommandResponse>, IMapFrom<Customer>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string PostCode { get; set; }
        public string Country { get; set; }

        public static void Mapping(MappingProfile profile)
        {
            profile.CreateMap<UpdateCustomerCommand, Customer>();
        }
    }
}