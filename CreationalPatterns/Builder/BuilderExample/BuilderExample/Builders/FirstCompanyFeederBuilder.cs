using DesignPatterns.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderExample.Builders
{
    /// <summary>
    /// Builds the first feeder ship.
    /// </summary>
    internal class FirstCompanyFeederBuilder : ShipBuilder
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
                new StakeholderCabin(),
                new CaptainsCabin(),
                new CaptainsCabin(),
                new Cabin(5),
                new Cabin(5),
                new Cabin(5),
                new Cabin(5),
            };

            workInProgress.SetRooms(new Rooms(rooms));
        }

        /// <inheritdoc/>
        public override void BuildShipmentSpace()
        {
            workInProgress.SetShipmentSpace(new ShipmentSpace(10000));
        }
    }
}
