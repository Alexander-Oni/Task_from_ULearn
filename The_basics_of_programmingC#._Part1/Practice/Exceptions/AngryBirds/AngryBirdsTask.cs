using System;

namespace AngryBirds;

public static class AngryBirdsTask
{
    public static double FindSightAngle(double v, double distance)
    {    
        const double G = 9.8;

        return 0.5 * Math.Asin((distance * G) / Math.Pow(v, 2));
    }
}