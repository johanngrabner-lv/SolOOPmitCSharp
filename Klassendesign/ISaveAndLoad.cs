using System;
using System.Collections.Generic;
using System.Text;

namespace Klassendesign
{
    interface ISaveAndLoad
    {
        //automatisch abstrakt und polymorph
        void Save();
        void Load(string filename);
    }
}
