

namespace Model.Models
{
    public class Currency
    {
        public string Name { get; set; }

        public string Buy { get; set; }

        public string Sell { get; set; }

        public string Categori { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}

