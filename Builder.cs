using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    interface Builder
    {
        void setType(string type);
        void setName(string name);
        void setPrice(string price);
        void setVolume(int volume);
    }
}
