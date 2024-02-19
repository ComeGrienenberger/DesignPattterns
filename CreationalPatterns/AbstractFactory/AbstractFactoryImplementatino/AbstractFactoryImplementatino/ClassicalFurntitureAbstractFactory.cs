using Model.Beds;
using Model.Chairs;
using Model.Desks;

namespace AbstractFactoryImplementatino
{
    /// <summary>
    /// Abstract factory for the classical furniture style.
    /// </summary>
    public class ClassicalFurntitureAbstractFactory : IFurnitureStyleAbstractFactory
    {
        /// <inheritdoc/>
        public List<Bed> GetBeds()
        {
            return new List<Bed>()
            {
                new ClassicalBed(10000, "J.S. Bach bed.")
            };
        }

        /// <inheritdoc/>
        public List<Chair> GetChairs()
        {
            return new List<Chair>()
            {
                new ClassicalChair(100, "J.S. Bach chair.")
            };
        }

        /// <inheritdoc/>
        public List<Desk> GetDesks()
        {
            return new List<Desk>()
            {
                new ClassicalDesk(750000, "J.S. Bach desk.")
            };
        }
    }
}
