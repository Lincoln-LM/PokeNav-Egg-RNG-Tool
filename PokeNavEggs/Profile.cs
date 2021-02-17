using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeNavEggs
{
    public class Profile
    {
        public string Name
        {
            get;
            set;
        }
        public bool HasLightningRod
        {
            get;
            set;
        }
        public bool IsRoaming
        {
            get;
            set;
        }
        public uint TID
        {
            get;
            set;
        }
        public uint SID
        {
            get;
            set;
        }
        public List<int> TrainersChecked
        {
            get;
            set;
        }
        public List<string> Trainers
        {
            get;
            set;
        }
    }
}
