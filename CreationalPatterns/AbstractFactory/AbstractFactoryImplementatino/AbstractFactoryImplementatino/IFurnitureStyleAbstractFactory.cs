using Model.Beds;
using Model.Chairs;
using Model.Desks;
namespace AbstractFactoryImplementatino
{
    /// <summary>
    /// Abstract factory interface for furniture styles.
    /// </summary>
    public interface IFurnitureStyleAbstractFactory
    {
        /// <summary>
        /// Returns chairs from a certain style.
        /// </summary>
        /// <returns> The chairs with a certain style. </returns>
        List<Chair> GetChairs();

        /// <summary>
        /// Returns beds from a certain style.
        /// </summary>
        /// <returns> The beds from a certain style. </returns>
        List<Bed> GetBeds();

        /// <summary>
        /// Returns desks from a certain style.
        /// </summary>
        /// <returns> The desks from a certain style. /returns>
        List<Desk> GetDesks();
    }
}
