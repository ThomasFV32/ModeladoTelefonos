namespace Entity
{
    public class Contact
    {
        private int id;
        private int number;
        private string name;
        private string email;
        private  string address;

        public Contact(int number, string name)
        {
            this.Number = number;
            this.Name = name;
        }

        public Contact(int id,int number, string name, string email, string address)
        {
            this.id = id;
            this.number = number;
            this.name = name;
            this.email = email;
            this.address = address;
        }

        public int Id { get => number; protected set => number = value; }
        public int Number { get => number; protected set => number = value; }
        public string Name { get => name; protected set => name = value; }
        public string Email { get => email; protected set => email = value; }
        public string Address { get => address; protected set => address = value; }
    }
}