using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ClientZakaz.Models
{
    public class ZakazModel
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Profession { get; set; }
        public string Text { get; set; }
        public int Price { get; set; }
        public bool IsActive { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Flat { get; set; }

        public ZakazModel (int id, string username = "default", string profession = "<?>", string text = "<?>", int price = 0, bool isActive = false, string city = "<?>", string street = "<?>", string flat = "<?>")
        {
            Id = id;
            Username = username;
            Profession = profession;
            Text = text;
            Price = price;
            IsActive = isActive;
            Street=street;
            Flat=flat;
            City = city;
            Id=id;
        }

        public static ZakazModel GetClone(ZakazModel zakaz)
        {
            if (zakaz is null)
                throw new ArgumentNullException(nameof(zakaz));

            return new ZakazModel(zakaz.Id)
            {
                Username = zakaz.Username,
                Profession = zakaz.Profession,
                Text = zakaz.Text,
                Price = zakaz.Price,
                IsActive = zakaz.IsActive,
                Street=zakaz.Street,
                Flat=zakaz.Flat,
                City=zakaz.City
            };
        }
    }
}

