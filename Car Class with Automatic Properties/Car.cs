using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Class_with_Automatic_Properties;
internal class Car
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public int Mileage { get; set; }

    public void Drive(int distance)
    {
        Mileage+= distance;
    }

    public int Age
    { 
        get 
        {
            return DateTime.Now.Year-Year;
        }
    }
}
