namespace CourseManagement
{
    internal static class Utils
    {
        public static int CalculateAttendancePercentageFromStart(int numberAttendance, int numberOfClasses)
        {

            int percentage = (numberAttendance * 100) / numberOfClasses;
            return percentage;
        } // Desde o início do curso

        public static int CalculatePercentageOfAttendanceSinceJoined(int numberAttendance, int numberLack)
        {
            int numberOfClasses = numberAttendance + numberLack;
            int percentage = (numberAttendance * 100) / numberOfClasses;
            return percentage;
        } // Desde que entrou
    }
}
