using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueApp.Interfaces
{
    internal interface IBaseService<T>
    {
        void Save(T model);
        void Update(T model);
        void Remove(T model);
    }
}
