using System;
using System.Collections.Generic;
using System.Text;

namespace dapper_Assignment
{
   public interface IContactRepository
   {
        Trains Find(int id);
        List<Trains> GetAll();
        Trains Add(Trains contact);
        Trains Update(Trains contact);
        void Remove(int id);
   }
}
