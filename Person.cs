class Person
{
    public string Name { get; set; }
    public override string ToString() => Name;

    public void ChangePerson(ref Person p)
    {
        p = new Person { Name = "New" };
    }

}