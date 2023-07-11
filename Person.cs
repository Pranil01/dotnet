namespace HR;//It is package
public class Person{
    //data members
    private string firstName;
	private String lastName;
    private string email;
	private string contactNumber;
	//DateTime is structure ;
    private DateTime birthDate;
	
	//getter method
    public void SetFirstName(string name)
		{
        this.firstName=name;
		}
	
	//setter method
    public string GetFirstName()
		{
        return this.firstName;
		}
 
    //Property LastName  VB syntax
    public string LastName
		{
        get{return this.lastName;}
        set{this.lastName=value;}   //By default we write value here.
		}

    public  string Email
		{
        get{return this.email;}
        set{this.email=value;}
		}
   


    //member functions
    //constructor overloading
    public Person()
{
        this.firstName="Pranil";
        this.lastName="Kalyani";
        this.birthDate=new DateTime(1999,8,9);//yyyy/mm/dd
        this.email="pranilkalyani@gmail.com";
        this.contactNumber="9881735801";
    }
    //here we using camelcase convection
    public Person(string fName, string lName, DateTime bDate, 
                  string contact, string email )
{
        this.firstName=fName;
        this.lastName=lName;
        this.birthDate=bDate;
        this.email=email;
        this.contactNumber=contact;
    }


    ~Person()
{
         //logic for releasing resources which are 
         //acquired during life time of object
        //it will be automatically called by Garbage Collector
    }

    public override string ToString()
    {
        return base.ToString() + " "+
          this.firstName + " "+ this.lastName;
    }
    

}