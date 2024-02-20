using AbstractFactoryImplementatino;
using Model;

namespace Client
{
    /// <summary>
    /// Handles displaying lists of furnitures for a given style.
    /// </summary>
    internal class MyClient
    {
        /// <summary>
        /// The style selector.
        /// </summary>
        private FurnitureStyleSelector furnitureStyleSelector;

        /// <summary>
        /// Basic constructor.
        /// </summary>
        public MyClient()
        {
            furnitureStyleSelector = new FurnitureStyleSelector();
        }

        /// <summary>
        /// Displays the list of furniture for a given furniture style.
        /// </summary>
        /// <param name="style"> The style of furniture to display. </param>
        public void DisplatList(FurnitureStyle style)
        {
            try
            {
                furnitureStyleSelector.SetFurnitureStyleFactory(style);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Could not display wanted style.");
                Console.WriteLine(ex.ToString());
            }

            Console.WriteLine(style.ToString() + " furniture list : ");

            var chairs = furnitureStyleSelector.GetFurnitureStyleFactory().GetChairs();
            var beds = furnitureStyleSelector.GetFurnitureStyleFactory().GetBeds();
            var desks = furnitureStyleSelector.GetFurnitureStyleFactory().GetDesks();

            Console.WriteLine("Chairs : ");
            DisplayFurnitureList(chairs.Cast<Furniture>().ToList());

            Console.WriteLine("Chairs : ");
            DisplayFurnitureList(beds.Cast<Furniture>().ToList());

            Console.WriteLine("Chairs : ");
            DisplayFurnitureList(desks.Cast<Furniture>().ToList());
        }

        /// <summary>
        /// Displays one list of furniture.
        /// </summary>
        /// <param name="furnitures"> Furnitures to display. </param>
        private void DisplayFurnitureList(List<Furniture> furnitures)
        {
            foreach(var furniture in furnitures)
            {
                Console.WriteLine(furniture);
            }
        }
    }
}
