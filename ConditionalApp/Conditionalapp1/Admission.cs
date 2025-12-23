//Admission Eligibility: Math ≥ 65, Phys ≥ 55, Chem ≥ 50 AND (Total ≥ 180 OR Math+Phys ≥ 140).

using System;

namespace Conditionalapp1;

public class Admission
{
    public static void AdmissionMain()
    {
        int MathMarks = Convert.ToInt32(Console.ReadLine());
        int PhysMarks = Convert.ToInt32(Console.ReadLine());
        int ChemMarks = Convert.ToInt32(Console.ReadLine());
        int Total = MathMarks + PhysMarks + ChemMarks;

        if(MathMarks >= 65 && PhysMarks >= 55 && ChemMarks >=50 && Total >= 180 || MathMarks+PhysMarks >= 140)
        {
            System.Console.WriteLine("You are eligible for admission");
        }
        else
        {
            System.Console.WriteLine("You are not eligible for admission");
        }
    }
}
