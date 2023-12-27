namespace GenericExample
{
    public class MaximumFinder
    {
        // Generic method to find the maximum of two values
        // Ensures that the type T must implement the IComparable<T> interface,
        // allowing us to use the CompareTo method for comparison.
        public T FindMaximum<T>(T first, T second) where T : IComparable<T>
        {
            return first.CompareTo(second) > 0 ? first : second;
        }
    }
}

