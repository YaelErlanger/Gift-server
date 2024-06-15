using Gift_server.Models;
using System.Linq;

namespace Gift_server
{
    public static class GiftsList
    {
       static List<Gift> gifts = new List<Gift>()
        {
            new Gift(1,"volvo car",Donators.Baiden,"car.JPG",75),
            new Gift(2,"Wig",Donators.Klinton,"wig.JPG",60)  
        };
        public static List<Gift> getGifts()
        {
            return gifts;
        }
        public static Gift getGiftById(int Id)
        {
            return gifts.Find(p => p.Id == Id);
        }
        public static void addGift(Gift g)
        {
            gifts.Add(g);
        }
        public static void updateGift(Gift g)
        {
            Gift gift = getGiftById(g.Id);
            gift.Id = g.Id;
            gift.Name = g.Name;
            gift.Image = g.Image;
            gift.Donator = g.Donator;
            gift.TicketCost = g.TicketCost;

        }
        public static void deleteGift(int Id)
        {
            Gift gift = getGiftById(Id);
            gifts.Remove(gift);
        }
    }
}
