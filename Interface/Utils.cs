namespace Interface
{
    internal static class Utils
    {
        public static int CalculatePercentage(int numberAttendance, int numberLack)
        {
            int numberOfClasses = numberAttendance + numberLack;
            int percentage = (numberAttendance * 100) / numberOfClasses;
            return percentage;
        }
    }
}
