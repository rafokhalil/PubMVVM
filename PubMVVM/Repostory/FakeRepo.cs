using PubMVVM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PubMVVM.Repostory
{
    public class FakeRepo
    {
        public List<Pub> GetAll()
        {
            return new List<Pub>
            {
                new Pub
                {
                    Name="NZS",
                    Price=1,
                    Volume=0.4,
                    ImagePath="../Images/NZS.png"
                },
                new Pub
                {
                    Name="Blanche",
                    Price=6.5,
                    Volume=0.5,
                    ImagePath="../Images/Blanche.png"
                },
                new Pub
                {
                    Name="Erdinger",
                    Price=7,
                    Volume=0.5,
                    ImagePath="../Images/Erdinger.png"
                },
                new Pub
                {
                    Name="Weisbier",
                    Price=9,
                    Volume=0.5,
                    ImagePath="../Images/Weisbier.png"
                }
            };
        }
    }
}
