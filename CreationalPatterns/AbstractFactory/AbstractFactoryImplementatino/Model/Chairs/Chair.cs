namespace Model.Chairs
{
    /// <summary>
    /// A chair.
    /// </summary>
    public class Chair : Furniture
    {
        /// <inheritdoc/>
        public Chair(float price, string name) : base(price, name)
        {
        }
    }
}
