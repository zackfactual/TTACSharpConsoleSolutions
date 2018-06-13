namespace p111_Additional_Features
{
    class Introduction
    {
        // 3. Chain two constructors together.
        public Introduction(string name) : this(name, 20)
        {

        }
        public Introduction(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public int Age { get; set; }
        public string Name { get; set; }

    }
}
