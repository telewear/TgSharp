using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TgSharp.TL;

namespace TgSharp.TL
{
    [TLObject(-1132882121)]
    public class TLBoolFalse : TLAbsBool
    {
        public override int Constructor
        {
            get
            {
                return -1132882121;
            }
        }

        // no fields

        public void ComputeFlags()
        {
            // do nothing
        }

        public override void DeserializeBody(BinaryReader br)
        {
            // do nothing
        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            // do nothing
        }
    }
}