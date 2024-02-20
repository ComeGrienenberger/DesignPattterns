namespace Model.Beds
{
    /// <summary>
    /// A bed.
    /// </summary>
    public abstract class Bed : Furniture
    {
        /// <inheritdoc/>
        protected Bed(float price, string name) : base(price, name)
        {
        }
    }
}
