using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.SeedWork
{
    public interface IBusinessRulee
    {
        bool IsBroken();

        string Message { get; }
    }
}