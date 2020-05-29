using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Interfaces
{
    public interface IRepositoryOnlyGet<TClass> where TClass : class
    {
        IEnumerable<TClass> GetALL();
    }
}
