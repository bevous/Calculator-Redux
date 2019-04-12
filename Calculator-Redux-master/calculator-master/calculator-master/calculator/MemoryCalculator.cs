
namespace calculator_redux
{
    /// <summary>
    /// The memory calculator.
    /// </summary>
    class MemoryCalculator
    {

        /// <summary>
        /// Gets or sets the saved value.
        /// </summary>
        private double SavedValue { get; set; }

        /// <summary>
        /// Saves the current value for later use.
        /// </summary>
        public void MemoryStore(double value)
        {
            this.SavedValue = value;
        }

        /// <summary>
        /// The clear the saved value.
        /// </summary>
        public void MemoryClear()
        {
            this.SavedValue = 0.0;
        }

        /// <summary>
        /// Sets the calculator’s current value to the value stored in memory.
        /// </summary>
        /// <returns>
        /// The <see cref="double"/>.
        /// </returns>
        public double MemoryRecall()
        {
            return this.SavedValue;
        }

        /// <summary>
        /// The memory add.
        /// </summary>
        public void MemoryAdd(double value)
        {
            this.SavedValue += value;
        }
    }

}
