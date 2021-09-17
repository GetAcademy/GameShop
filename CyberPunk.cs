using System;
using System.Collections.Generic;
using System.Text;

namespace GameShop
{
    public class CyberPunk : GameItem, IPhysicalCopy, IDownloadable
    {
        public CyberPunk()
        {
            this.GameName = "CyberPunk";
            this.Price = 250;
            this.Id = "2";
        }
        
    }
}
