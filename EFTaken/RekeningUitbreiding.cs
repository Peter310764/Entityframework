﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTaken
{
    public partial class Rekening
    {
        public void Storten (decimal bedrag)
        {
            this.Saldo += bedrag; 
        }

    }
}
