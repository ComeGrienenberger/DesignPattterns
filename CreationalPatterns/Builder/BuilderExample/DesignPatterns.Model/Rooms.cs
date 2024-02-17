namespace DesignPatterns.Model
{
    /// <summary>
    /// Model of the rooms in a ship.
    /// </summary>
    public class Rooms
    {
        /// <summary>
        /// Collection of rooms.
        /// </summary>
        public IEnumerable<Room> ContainedRooms { get; private set; }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="rooms"> Rooms. </param>
        public Rooms(IEnumerable<Room> rooms)
        {
            ContainedRooms = rooms;
        }

        /// <summary>
        /// Returns the total personnel capacity of the ship.
        /// </summary>
        /// <returns> The total capcity of the ship. </returns>
        public int GetTotalCapacity()
        {
            var tt = 0;

            foreach(Room room in ContainedRooms)
            {
                tt += room.Capacity;
            }

            return tt;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
