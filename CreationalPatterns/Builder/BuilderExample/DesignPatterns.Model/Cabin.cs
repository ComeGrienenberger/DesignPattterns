namespace DesignPatterns.Model
{
    /// <summary>
    /// One type of room : the cabin.
    /// </summary>
    public class Cabin : Room
    {
        /// <summary>
        /// A cabin can be of variable size.
        /// </summary>
        /// <param name="capacity"> Room capacity. </param>
        public Cabin(int capacity) : base(capacity)
        {
        }

        /// <summary>
        /// A cabin does not have a desk.
        /// </summary>
        /// <returns> False. </returns>
        public override bool HasDesk()
        {
            return false;
        }

        /// <summary>
        /// A cabin does not have a shower.
        /// </summary>
        /// <returns> False. </returns>
        public override bool HasShower()
        {
            return false;
        }
    }
}
