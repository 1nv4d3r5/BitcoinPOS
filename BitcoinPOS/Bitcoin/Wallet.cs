using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bitcoin
{
    public class Wallet
    {

        public ulong GetBalance()
        {
            var bs = new BitCoinSharp.Wallet(BitCoinSharp.NetworkParameters.ProdNet());
            return bs.GetBalance();
        }
    }
}
