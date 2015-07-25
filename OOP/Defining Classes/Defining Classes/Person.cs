using System;

class Person
{

    private string name;
    private string email;
    private int age;

    public Person(string name, int age)
        : this(name, age, null)
    {
        this.Name = name;
        this.Age = age;
    }
    public Person(string name, int age, string email)
    {
        this.Name = name;
        this.Age = age;
        this.Email = email;
    }



    public string Name
    {
        get { return this.name; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("name cannot be empty!");
            }
            this.name = value;
        }
    }

    public int Age
    {
        get { return this.age; }
        set
        {
            if (value < 1 || value > 100)
            {
                throw new ArgumentException("age is incorrect");
            }
            this.age = value;
        }
    }


    public string Email
    {
        get { return this.email; }
        set
        {
            if (value != null && !value.Contains("@"))
            {
                throw new ArgumentException("Wrong Email");
            }
            this.email = value;
        }
    }

    public override string ToString()
    {
        string result = string.Format("name: {0}, age: {1}", this.Name, this.Age);
        if (this.Email != null)
        {
            result += ", email: " + this.Email;
        }
        return result;
    }
}