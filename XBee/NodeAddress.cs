﻿using System;
using System.Runtime.Remoting.Messaging;

namespace XBee
{
    public class NodeAddress : IEquatable<NodeAddress>
    {
        public NodeAddress()
        {
        }

        public NodeAddress(LongAddress longAddress, ShortAddress shortAddress)
        {
            LongAddress = longAddress;
            ShortAddress = shortAddress;
        }

        public NodeAddress(LongAddress longAddress) : this(longAddress, ShortAddress.Broadcast)
        {
        }

        public NodeAddress(ShortAddress shortAddress) : this(LongAddress.Broadcast, shortAddress)
        {
        }

        public LongAddress LongAddress { get; set; }

        public ShortAddress ShortAddress { get; set; }

        public bool Equals(NodeAddress other)
        {
            if (ShortAddress.Equals(ShortAddress.Broadcast) || ShortAddress.Equals(ShortAddress.Disabled))
                return LongAddress.Equals(other.LongAddress);

            if (LongAddress.Equals(LongAddress.Broadcast))
                return ShortAddress.Equals(other.ShortAddress);

            return LongAddress.Equals(other.LongAddress) && ShortAddress.Equals(other.ShortAddress);
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}", LongAddress, ShortAddress);
        }
    }
}
