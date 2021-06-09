using System;

namespace API.Extensions
{
    public static class DateTimeExtensions
    {
        public static int CalculateAge(this DateTime dob)
        {
           int age = DateTime.Today.Year - dob.Year;
           return dob.Date > DateTime.Today.AddYears(-age) 
                   ? age-- : age;
        }
    }
}