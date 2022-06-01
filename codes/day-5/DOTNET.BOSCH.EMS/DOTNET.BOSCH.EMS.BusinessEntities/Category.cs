using System;
using System.Collections.Generic;

namespace DOTNET.BOSCH.EMS.BusinessEntities
{
    public class Category
    {
        #region Constructors
        public Category()
        {

        }
        public Category(int id, string name, HashSet<Product> products = null)
        {
            Id = id;
            Name = name;
            Products = products;
        }
        #endregion

        #region Properties
        public int Id { get; set; }
        public string Name { get; set; }

        //navigation
        public HashSet<Product> Products { get; set; }
        #endregion

        #region Object class methods
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException("Null arguemnet has been passed");
            }

            if (!(obj is Category))
                throw new ArgumentException("arguemnet is not of type Category");

            Category other = obj as Category;

            if (this == other)
                return true;

            if (!this.Id.Equals(other.Id))
                return false;

            if (!this.Name.Equals(other.Name))
                return false;

            return true;
        }

        public override int GetHashCode()
        {
            const int randomVal = 31;
            return this.Id.GetHashCode() * randomVal;
        }

        public override string ToString()
        {
            return $"{Id}, {Name}";
        }
        #endregion
    }
}
