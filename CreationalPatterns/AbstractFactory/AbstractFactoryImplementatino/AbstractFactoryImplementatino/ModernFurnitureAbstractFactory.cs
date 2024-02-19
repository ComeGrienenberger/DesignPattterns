using Model.Beds;
using Model.Chairs;
using Model.Desks;

namespace AbstractFactoryImplementatino
{
    public class ModernFurnitureAbstractFactory : IFurnitureStyleAbstractFactory
    {
        /// <inheritdoc/>
        public List<Bed> GetBeds()
        {
            return new List<Bed>()
            {
                new ModernBed(10, "New wave bed.")
            };
        }

        /// <inheritdoc/>
        public List<Chair> GetChairs()
        {
            return new List<Chair>()
            {
                new ModernChair(100, "The wavy stuffy chair.")
            };
        }

        /// <inheritdoc/>
        public List<Desk> GetDesks()
        {
            return new List<Desk>()
            {
                new ModernDesk(1000, "Is that really a desk?")
            };
        }
    }
}
