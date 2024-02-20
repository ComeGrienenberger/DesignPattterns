using Model;

namespace AbstractFactoryImplementatino
{
    /// <summary>
    /// Selects the factory to use for a given style.
    /// </summary>
    public class FurnitureStyleSelector
    {
        /// <summary>
        /// Furniture factory to use.
        /// </summary>
        public IFurnitureStyleAbstractFactory? FurnitureAbstractFactory { get; private set; }

        /// <summary>
        /// Returns the current furniture style factory.
        /// </summary>
        /// <returns> The current furniture style factory. </returns>
        /// <exception cref="Exception"> If the factory is not set. </exception>
        public IFurnitureStyleAbstractFactory GetFurnitureStyleFactory()
        {
            if(FurnitureAbstractFactory is null)
            {
                throw new Exception("Factory not initialized?");
            }

            return FurnitureAbstractFactory;
        }

        /// <summary>
        /// Sets the furniture style factory.
        /// </summary>
        /// <param name="style"> Style to set. </param>
        /// <exception cref="Exception">  If the style is not known by the selector. </exception>
        public void SetFurnitureStyleFactory(FurnitureStyle style)
        {
            switch (style)
            {
                case FurnitureStyle.Classical:
                    FurnitureAbstractFactory = new ClassicalFurntitureAbstractFactory();
                    return;
                case FurnitureStyle.Modern:
                    FurnitureAbstractFactory = new ModernFurnitureAbstractFactory();
                    return;
            }

            throw new Exception("Selector does not know furniture style.");
        }

    }
}
