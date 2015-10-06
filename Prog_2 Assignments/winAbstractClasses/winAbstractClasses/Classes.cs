namespace winAbstractClasses
{
    enum Gender
    {
        Male, Female, Other
    }

    abstract class Person
    {
        public string IdNo { get; set; }
        public string FirstName { get; set; }
        public Gender Gender { get; set; }
    }

    class Student : Person
    {
        public string Class { get; set; }
    }


}