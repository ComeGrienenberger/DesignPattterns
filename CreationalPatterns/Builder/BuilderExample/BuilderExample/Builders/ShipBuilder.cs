using DesignPatterns.Model;

namespace BuilderExample.Builders
{
    /// <summary>
    /// Abstract ship builder, defines the interface for building ships.
    /// </summary>
    public abstract class ShipBuilder
    {
        /// <summary>
        /// The current ship being built.
        /// </summary>
        protected Ship workInProgress = new Ship();

        /// <summary>
        /// Returns the built ship.
        /// </summary>
        /// <returns> The built ship. </returns>
        public Ship GetShip()
        {
            return workInProgress;
        }

        /// <summary>
        /// Method to build the ship's rooms.
        /// </summary>
        public abstract void BuildRooms();

        /// <summary>
        /// Method to build the ship's shipment space.
        /// </summary>
        public abstract void BuildShipmentSpace();

        /// <summary>
        /// Method to build the ship's engine.
        /// </summary>
        public abstract void BuildEngine();
    }
}
