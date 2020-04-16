using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TgSharp.TL;

namespace TgSharp.TL
{
    [TLObject(-1895328189)]
    public class TLChannelAdminLogEventActionStopPoll : TLAbsChannelAdminLogEventAction
    {
        public override int Constructor
        {
            get
            {
                return -1895328189;
            }
        }

        public TLAbsMessage Message { get; set; }

        public void ComputeFlags()
        {
            // do nothing
        }

        public override void DeserializeBody(BinaryReader br)
        {
            Message = (TLAbsMessage)ObjectUtils.DeserializeObject(br);
        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            ObjectUtils.SerializeObject(Message, bw);
        }
    }
}
