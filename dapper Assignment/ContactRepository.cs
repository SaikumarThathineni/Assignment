using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace dapper_Assignment
{
    public class ContactRepository : IContactRepository
    {
        private IDbConnection db;
        public ContactRepository(string connstr)
        {
            this.db = new SqlConnection(connstr);
        }

        public Trains Add(Trains contact)
        {
            throw new NotImplementedException();
        }

        public Trains Find(int id)
        {
            throw new NotImplementedException();
        }

        public List<Trains> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public Trains Update(Trains contact)
        {
            throw new NotImplementedException();
        }
    }
}
