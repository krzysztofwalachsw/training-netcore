using System;
using System.Collections.Generic;

namespace KWSW.Training.CharApp.Contracts
{
    public class Room : BaseEntity
    {
        public string Name { get; set; }

        public IEnumerable<Message> Messages { get; set; }
    }
}
