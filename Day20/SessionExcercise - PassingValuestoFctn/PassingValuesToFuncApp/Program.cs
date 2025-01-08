

using System;

class Program
{


    static void Main()
    {

        CaseStudy1();


        CaseStudy2();

        CaseStudy3();


    }

    private static void CaseStudy3()
    {
        int age = 40;
        UpdateAgeListItemsToZero(ref age);
        Console.WriteLine("age value is " + age);

    }
    static void UpdateAgeListItemsToZero(ref int myage)
    {
        myage = 0;
    }

    private static void CaseStudy2()
    {
        int[] ageList = { 40, 50, 60, 70 };//agelist is a pointer to the array object

        Console.WriteLine($"hashcode of ageList is  {ageList.GetHashCode()} ");
        UpdateAgeListItemsToZero(ageList);
        // UpdateAgeListItemsToZero((int[])ageList.Clone());
        foreach (var age in ageList)
        {
            Console.WriteLine("Age after calling UpdateAgeListItemsToZero: " + age);
        }
    }
    static void UpdateAgeListItemsToZero(int[] myageList)
    {

        Console.WriteLine($"hashcode of myageList is  {myageList.GetHashCode()} ");

        for (int i = 0; i < myageList.Length; i++)
        {
            myageList[i] = 0;
        }
    }

    static void CaseStudy1()
    {
        int age = 30;
        UpdateAgeToZero(age);
        Console.WriteLine("Age after calling UpdateAgeToZero: " + age);
    }

    static void UpdateAgeToZero(int agePassed)
    {
        agePassed = 0;
    }
}