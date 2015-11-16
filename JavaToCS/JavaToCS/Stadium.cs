using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaToCS
{
    struct Stadium
    {
        private string name { get; set; }
        private string country { get; set; }
        private string city { get; set; }
        private long capacity { get; set; }

        public void CreateStadium()
        {
            Input input = new Input();
            this.name = input.GetText("Enter Stadiums name: ");
            this.country = input.GetText("Enter Stadiums country name: ");
            this.city = input.GetText("Enter Stadiums city name: ");
            this.capacity = input.GetNumber("Enter Stadiums capacity", 0, 999999);
        }
    }
}
