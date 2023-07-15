// See https://aka.ms/new-console-template for more information

using HR;
Console.WriteLine("Before Person object is created");


using (Person p1 = new Person{FirstName ="Raje" ,LastName="Shinde"} )
{



    Console.WriteLine(p1);
}


    Console.WriteLine("After Person work is finished");






    GC.Collect();