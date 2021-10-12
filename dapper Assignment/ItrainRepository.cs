using System;
using System.Collections.Generic;
using System.Text;

namespace dapper_Assignment
{
     public interface ItrainRepository
     {

        Trains Find(int id);
        List<Trains> GetAll();
        Trains Add(Trains trains);
        Trains Update(Trains trains);
        void Remove(int id);

    }
}
