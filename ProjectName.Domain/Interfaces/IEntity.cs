using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectName.Domain.Interfaces
{
    public interface IEntity<T>
    {
        T Id { get; set; }
    }
}
