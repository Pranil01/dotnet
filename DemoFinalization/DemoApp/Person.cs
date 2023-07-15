namespace HR;

public class Person:IDisposable//Interface
  {
public Person(){}


  public string FirstName{get;set;}
  public string LastName{get;set;}


  public override  string ToString () {

   return base.ToString()+" "+FirstName+" "+LastName;


  }

  public void Dispose(){

   Console.WriteLine("Resources are relased instantly....");
        GC.SuppressFinalize(this);
  }


  ~Person (){


 //Releasing resources which have been allocated
        //during lifetime of this object

  }




 











  }