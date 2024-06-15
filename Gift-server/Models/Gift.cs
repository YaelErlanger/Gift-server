namespace Gift_server.Models
{
    public  enum Donators {Baiden,Trump,Obama,Klinton };
    public class Gift
    {
        public Gift(int id, string name, Donators donator, string image, int ticketCost)
        {
            Id = id;
            Name = name;
            Donator = donator;
            Image = image;
            TicketCost = ticketCost;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public Donators Donator { get; set; }
        public string Image { get; set; }

        public int TicketCost { get; set; }



    }
}
