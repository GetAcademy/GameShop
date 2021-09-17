using System;
using System.Collections.Generic;
using System.Text;

namespace GameShop
{
    public class PUBG : GameItem, IDownloadable, IPhysicalCopy
    {
        public PUBG()
        {
            this.GameName = "Player Unknown BattleGround";
            this.Price = 100;
            this.Id = "4";
        }
    }
}
