using System;
using System.Collections.Generic;
using System.Text;

namespace GameShop
{
    public class BattleField : GameItem, IDownloadable
    {
        public BattleField()
        {
            this.GameName = "BattleField";
            this.Price = 150;
            this.Id = "1";
        }
    }
}
