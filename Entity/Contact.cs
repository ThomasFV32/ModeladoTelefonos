namespace Entity
{
    public class Contact
    {
        private int number;
        private string name;

        public Contact(int number, string name)
        {
            this.Number = number;
            this.Name = name;
        }

        public int Number { get => number; set => number = value; }
        public string Name { get => name; set => name = value; }
    }
}