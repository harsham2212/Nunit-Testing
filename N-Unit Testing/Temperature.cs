using System;
using System.Collections.Generic;
using System.Text;

namespace N_Unit_Testing
{
    class Temperature
    {
            public void CeltoFah(float temp)
            {
                float value = ((temp * 9.0f / 5.0f) + 32.0f);
                Console.WriteLine("The Changed Value is:" + value);
            }
            public void FahToCel(float temp)
            {
                float value = (temp - 32.0f) * 5.0f / 9.0f;
                Console.WriteLine("The Changed Value is:" + value);
            }
        public void Calculate(float temp)
        {
            Console.WriteLine("Press 1 to convert Celsius to Fahrenheit\n Press 2 to convert Fahrenheit to Celsius");
            int check = Convert.ToInt32(Console.ReadLine());
            switch (check)
            {
                case 1:
                    Temperature tc = new Temperature();
                    tc.CeltoFah(temp);
                    break;
                case 2:
                    Temperature tc1 = new Temperature();
                    tc1.FahToCel(temp);
                    break;
            }

        }
    }
}
