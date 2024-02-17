namespace DesignPatterns.Model
{

    /// <summary>
    /// Space available for products in a ship.
    /// </summary>
    public class ShipmentSpace
    {
        /// <summary>
        /// Space in m3.
        /// </summary>
        int Space { get; set; }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="space"> Space in m3. </param>
        public ShipmentSpace(int space)
        {
            Space = space;
        }
    }
}
