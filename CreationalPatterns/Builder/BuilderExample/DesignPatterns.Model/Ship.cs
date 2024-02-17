namespace DesignPatterns.Model
{
    /// <summary>
    /// Ship representation.
    /// </summary>
    public class Ship
    {
        #region attributes
        private string? Name { get; set; }

        private Rooms? Rooms { get; set; }

        private ShipmentSpace? ShipmentSpace { get; set; } 

        private Engine? Engine { get; set; }
        #endregion

        #region getters and setters
        public string GetName()
        {
            if(String.IsNullOrWhiteSpace(Name))
            {
                throw new Exception("Not initialized");
            }

            return Name;
        }

        public bool SetName(string name)
        {
            if (String.IsNullOrWhiteSpace(Name))
            {
                return false;
            }

            Name = name;
            return true;
        }

        public Rooms GetRooms()
        {
            if (Rooms == null)
            {
                throw new Exception("Not initialized");
            }

            return Rooms;
        }

        public bool SetRooms(Rooms rooms)
        {
            Rooms = rooms;

            return true;
        }

        public ShipmentSpace GetShipmentSpace()
        {
            if(ShipmentSpace == null)
            {
                throw new Exception("Not initialized");
            }

            return ShipmentSpace;
        }

        public bool SetShipmentSpace(ShipmentSpace shipmentSpace)
        {
            ShipmentSpace = shipmentSpace;
            return true;
        }

        public Engine GetEngine()
        {
            if (Engine == null)
            {
                throw new Exception("Not initialized");
            }

            return Engine;
        }

        public bool SetEngine(Engine engine)
        {
            Engine = engine;
            return true;
        }
        #endregion
    }
}
