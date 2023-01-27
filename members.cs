class Members
{
    // member - private field
    private string memberName;
    private string jobTitle;
    private int salary = 20000;

    // member - public field
    public int age;

    // member - property - exposes jobTitle safely - properties start with a capital letter
    public string JobTitle 
    { 
        get 
        {
            return JobTitle;
        } 
        set 
        {
            JobTitle = value;
        }
    }

    // public member Method - can be called from other classes
    public void Introducing(bool isFriend)
    {
        if (isFriend)
        {
           SharingPrivateInfo(); 
        }
        else
        {
            System.Console.WriteLine($"Hi, my name is {memberName}, my job titles is {jobTitle}, and my age is {age}.");
        }
    }

    private void SharingPrivateInfo()
    {
        System.Console.WriteLine($"My salary is {salary}");
    }

    // member constructor
    public Members()
    {
        age = 30;
        memberName = "Zee";
        salary = 60000;
        jobTitle = "Developer";
        System.Console.WriteLine("Ojbect Created");
    }

    // member - finalizer - destructor
    ~Members()
    {
        // cleanup statements
        System.Console.WriteLine("Deconstruction of Members object");
        System.Diagnostics.Debug.WriteLine("Deconstruction of Members objects");
    }
}