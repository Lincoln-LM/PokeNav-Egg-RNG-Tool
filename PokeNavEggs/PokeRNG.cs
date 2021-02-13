using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeNavEggs
{
    internal class PokeRNG
    {
        public uint seed;
        public PokeRNG(uint seedInput)
        {
            this.seed = seedInput;
        }

        public uint nextUInt()
        {
            seed = seed * 0x41c64e6d + 0x6073;
            return seed;
        }
        public uint nextUShort()
        {
            return nextUInt() >> 16;
        }
        public void advance(uint advances)
        {
            for (uint advance = 0; advance < advances; advance++)
            {
                nextUInt();
            }
        }
    }
}
