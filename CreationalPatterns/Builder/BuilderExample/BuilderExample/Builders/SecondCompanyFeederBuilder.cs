using DesignPatterns.Model;

namespace BuilderExample.Builders
{
    internal class SecondCompanyFeederBuilder : ShipBuilder
    {
        /// <inheritdoc/>
        public override void BuildEngine()
        {
            workInProgress.SetEngine(new XEngine());
        }

        /// <inheritdoc/>
        public override void BuildRooms()
        {
            List<Room> rooms = new List<Room>()
            {
                new CaptainsCabin(),
                new Cabin(5),
                new Cabin(5),
                new Cabin(2),
                new Cabin(1),
            };


            workInProgress.SetRooms(new Rooms(rooms));
        }

        /// <inheritdoc/>
        public override void BuildShipmentSpace()
        {
            workInProgress.SetShipmentSpace(new ShipmentSpace(5000));
        }
    }
}
