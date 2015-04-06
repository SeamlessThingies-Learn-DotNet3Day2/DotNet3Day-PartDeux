using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace St.Eg.M1.Ex1.OOP.Model6
{
    public interface IValidator<T> where T : EntityBase
    {
        void Validate(T theItem);
    }
}
