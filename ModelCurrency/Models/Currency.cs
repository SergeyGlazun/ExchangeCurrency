

namespace Model.Models
{
    public class Currency
    {
        public string Cur_Name { get; set; }

        public string Buy { get; set; }

        public string Cur_OfficialRate { get; set; }

        public string Cur_Scale { get; set; }

        public override string ToString()
        {
            return Cur_Name;
        }
    }
}

