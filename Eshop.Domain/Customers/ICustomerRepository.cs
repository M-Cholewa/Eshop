﻿using Eshop.Domain.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop.Domain.Customers
{
    public interface ICustomerRepository
    {
        Task<Customer> GetByIdAsync(Guid id);

        void Add(Customer customer);
    }
}
