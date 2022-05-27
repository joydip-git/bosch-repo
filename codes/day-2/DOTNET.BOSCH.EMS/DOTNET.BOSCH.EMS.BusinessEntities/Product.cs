using System;

namespace DOTNET.BOSCH.EMS.BusinessEntities
{
    public class Product
    {
        #region Cosntructors
        public Product()
        {

        }
        public Product(int id, string name, double price, string description, int? categoryId = null, Category category = null)
        {
            Id = id;
            Name = name;
            Price = price;
            Description = description;
            Category = category;
            CategoryId = categoryId;
        }
        #endregion

        #region Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public double? Price { get; set; }
        public string Description { get; set; }
        public int? CategoryId { get; set; }
        //navigation/association property
        public Category Category { get; set; }

        #endregion

        
        #region Object class methods

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException("Null arguemnet has been passed");
            }

            if (!(obj is Product))
                throw new ArgumentException("arguemnet is not of type Product");

            Product other = obj as Product;

            if (this == other)
                return true;

            if (!this.Id.Equals(other.Id))
                return false;

            if (!this.Name.Equals(other.Name))
                return false;

            if (!this.Price.Equals(other.Price))
                return false;

            if (!this.Description.Equals(other.Description))
                return false;

            if (this.Category != null)
                if (!this.Category.Equals(other.Category))
                    return false;

            return true;
        }

        public override int GetHashCode()
        {
            const int num = 34;
            return this.Id.GetHashCode() * num;
        }

        public override string ToString()
        {
            return $"{Id}, {Name}, {Price}, {Description}";
        }
        #endregion
        
    }
}
