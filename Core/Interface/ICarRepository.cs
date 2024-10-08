﻿using Core.Entities;
using Core.Entities.Consts;
using Core.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interface
{
    public interface ICarRepository
    {
        Task<Car> GetCarByIdAsync(int id);
        Task<IReadOnlyList<Car>> GetCarsAsync();

        Task<int> CountAsync();
        Task<IReadOnlyList<Car>> GetCarsWithSpecificationsAsync(CarSpecParams carParams);




    }
}
