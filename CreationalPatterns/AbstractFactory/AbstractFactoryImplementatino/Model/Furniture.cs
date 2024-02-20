using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// A piece of furniture.
    /// </summary>
    public abstract class Furniture
    {
        /// <summary>
        /// Furniture price.
        /// </summary>
        public float Price { get; set; }

        /// <summary>
        /// Furniture name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="price"> The furniture's price. </param>
        /// <param name="name"> The furniture's name. </param>
        public Furniture(float price, string name)
        {
            Price = price;
            Name = name;
        }


        /// <inheritdoc/>
        public override string ToString()
        {
            return Name + " : " + Price + "\n";
        }
    }
}
