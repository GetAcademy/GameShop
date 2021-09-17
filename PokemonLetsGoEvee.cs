using System;
using System.Collections.Generic;
using System.Text;

namespace GameShop
{
    public class PokemonLetsGoEvee : GameItem, IPhysicalCopy
    {
        public PokemonLetsGoEvee()
        {
            this.GameName = "Pokemon Let`s GO Evee";
            this.Price = 400;
            this.Id = "3";
        }
    }
}
