using System;


namespace CircleAbstractionApp.Models
{
     class Circle
    {
        public float Radious;

        public float CalculateArea()
        {
            return (float)(Math.PI * Math.Pow(Radious,2));
        }
    }
}
