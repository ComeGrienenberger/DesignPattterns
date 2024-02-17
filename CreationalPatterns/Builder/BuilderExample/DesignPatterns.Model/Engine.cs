namespace DesignPatterns.Model
{
    /// <summary>
    /// Class reprenseting an engine.
    /// </summary>
    public abstract class Engine
    {
        /// <summary>
        /// Max engine speed.
        /// </summary>
        public double MaxSpeed { get ;set; }

        /// <summary>
        /// Average engine speed.
        /// </summary>
        public double AverageSpeed { get; set; }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="maxSpeed"> Max engine speed. </param>
        /// <param name="averageSpeed"> Average engine speed. </param>
        protected Engine(double maxSpeed, double averageSpeed)
        {
            MaxSpeed = maxSpeed;
            AverageSpeed = averageSpeed;
        }

        public override string ToString()
        {
            return "Engine max : " + MaxSpeed + ", Engine Avg : " + AverageSpeed;
        }
    }
}
