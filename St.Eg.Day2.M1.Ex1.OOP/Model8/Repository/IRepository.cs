﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace St.Eg.M1.Ex1.OOP.Model8
{
    public interface IRepository 
    {
        T Retrieve<T>(string id) where T : EntityBase;
        void Save<T>(T theItem) where T : EntityBase;

        IEnumerable<Order> GetOrdersForCustomer(string customerID);
    }
}
