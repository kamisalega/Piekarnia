﻿using PieShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShop.Data
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
    }
}
