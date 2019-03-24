using System;
namespace Library
{
    public class Hello
    {
        private string name;
        public Hello()
        {
        }

        public string Name
        { get => name; set => name = value ?? String.Empty; }
    }
}
