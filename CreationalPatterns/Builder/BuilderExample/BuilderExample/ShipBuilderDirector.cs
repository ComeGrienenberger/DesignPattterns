using BuilderExample.Builders;
using DesignPatterns.Model;

namespace BuilderExample
{
    /// <summary>
    /// Directs the building of a ship.
    /// </summary>
    public class ShipBuilderDirector
    {
        /// <summary>
        /// The current shipBuilder.
        /// </summary>
        private ShipBuilder shipBuilder { get; set; }

        /// <summary>
        /// Builds the ship for a given shipType.
        /// </summary>
        /// <param name="shipType"> The ship type to build. </param>
        public void BuildShip(ShipType shipType, string name)
        {
            SetBuilder(shipType);

            shipBuilder.BuildName(name);
            shipBuilder.BuildEngine();
            shipBuilder.BuildRooms();
            shipBuilder.BuildShipmentSpace();
        }

        /// <summary>
        /// Returns teh built ship.
        /// </summary>
        /// <returns> The built ship. </returns>
        public Ship GetShip()
        {
            return shipBuilder.GetShip();
        }

        /// <summary>
        /// Associates a builder for a ship type.
        /// </summary>
        /// <param name="shipType"> Type of ship. </param>
        /// <exception cref="Exception"> If ship type is not know by director. </exception>
        private void SetBuilder(ShipType shipType)
        {
            switch(shipType)
            {
                case ShipType.FirstFeeder:
                    shipBuilder = new FirstCompanyFeederBuilder();
                    return;
                case ShipType.SecondFeed:
                    shipBuilder = new SecondCompanyFeederBuilder();
                    return;
                case ShipType.FirstVessel:
                    shipBuilder = new FirstCompanyVesselBuilder();
                    return;
            }

            throw new Exception("Ship type not supported by director.");
        }
    }
}
