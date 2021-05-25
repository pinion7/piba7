namespace Lab4
{
    public static class Calendar
    {
        public static bool IsLeapYear(uint year)
        {
            if (year % 4 == 0)
            {
                if (year % 400 == 0)
                {
                    return true;
                }
                else if (year % 100 == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            return false;
        }

        public static int GetDaysInMonth(uint year, uint month)
        {
            if (year <= 9999 && month > 0 && month <= 12)
            {
                if (month == 2 && IsLeapYear(year) == true)
                {
                    return 29;
                }
                else if (month == 2 && IsLeapYear(year) == false)
                {
                    return 28;
                }

                if (month == 4 || month == 6 || month == 9 || month == 11)
                {
                    return 30;
                }
                return 31;
            }
            return -1;
        }
    }
}
