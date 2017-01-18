using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Moonie.Helpers
{
    public class HelperFunctions
    {
        public static int AgeCalculation(DateTime birthDate)
        {
            // Save today's date.
            var today = DateTime.Today;

            // Calculate the age.
            var age = today.Year - birthDate.Year;

            // Do stuff with it.
            if (birthDate > today.AddYears(-age)) age--;

            return age;
        }

    }
}
