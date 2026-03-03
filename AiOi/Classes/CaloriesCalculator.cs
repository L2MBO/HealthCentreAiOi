using AiOi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AiOi.Classes
{
    internal class CaloriesCalculator
    {
        /// <summary>
        /// Расчет безопасного количества калорий по формуле Маффина-Джеора
        /// </summary>
        /// <param name="PatientId">Пациент</param>
        /// <param name="activityCoefficient">Коэффициент физической активности</param>
        /// <returns>Количество калорий в день</returns>
        public static double CalculateSafeCalories(int PatientId, double activityCoefficient)
        {
            var currentPatient = Program.context.Patients.FirstOrDefault(p => p.IdPatient == PatientId);

            double bmr = 9.99 * currentPatient.Weight + 6.25 * currentPatient.Height - 4.92 * GetAge(currentPatient.BirthdayDate);

            // 1 = мужской, 2 = женский
            bmr += (currentPatient.GenderId == 1) ? 5 : -161;

            return bmr * activityCoefficient;
        }

        private static double GetAge(DateTime birthdayDate)
        {
            var today = DateTime.Today;
            var age = today.Year - birthdayDate.Year;
            if (birthdayDate.Date > today.AddYears(-age)) age--;
            return age;
        }
    }
}
