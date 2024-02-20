using lab3.Interfaces;

namespace lab3.Services
{
    class DayStateService: IDayStateService
    {
        public string GetDayState()
        {
            int hour = DateTime.Now.Hour;
            if (hour >= 12 && hour < 18)
            {
                return "day";
            }
            if (hour >= 18 && hour < 24)
            {
                return "evening";
            }
            if (hour >= 0 && hour < 6)
            {
                return "night";
            }
            else
            {
                return "morning";
            }
        }
    }
}