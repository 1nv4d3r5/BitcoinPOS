using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BitCoinSharp;
using Bitcoin.Properties;

namespace Bitcoin
{
    public class Wallet
    {
        public NetworkParameters network;
        public Wallet()
        {
            var defSettings = Properties.Settings.Default;
            network = defSettings.UseMainNet ? BitCoinSharp.NetworkParameters.ProdNet() : BitCoinSharp.NetworkParameters.TestNet();
        }

        public ulong GetBalance()
        {
            var bs = new BitCoinSharp.Wallet(network);
            return bs.GetBalance();
        }
    }

}
