namespace Model.Desks
{
    /// <summary>
    /// A desk.
    /// </summary>
    public class Desk : Furniture
    {
        /// <inheritdoc/>
        public Desk(float price, string name) : base(price, name)
        {
        }
    }
}
