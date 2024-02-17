namespace DesignPatterns.Model
{
    /// <summary>
    /// Class representing a ship's room.
    /// </summary>
    public abstract class Room
    {
        /// <summary>
        /// Capacity of the room.
        /// </summary>
        public int Capacity { get; set; }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="capacity"> Room capacity. </param>
        protected Room(int capacity)
        {
            Capacity = capacity;
        }

        /// <summary>
        /// Method to know if the room has a shower.
        /// </summary>
        /// <returns> True if the room has a shower, false otherwise. </returns>
        public abstract bool HasShower();

        /// <summary>
        /// Method to know if the room has a desk.
        /// </summary>
        /// <returns> True if the room has a desk false otherwise. </returns>
        public abstract bool HasDesk();

        public override string ToString()
        {
            return "Room Capacity : " + Capacity;
        }
    }
}
