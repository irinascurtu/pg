using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.ResidentsPersons
{
    internal class Citizen : IPerson, IResident
    {
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Age { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
      

        string IPerson.Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IPerson.Country { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void GetName(string name)
        {
            throw new NotImplementedException();
        }

        void IPerson.GetName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
