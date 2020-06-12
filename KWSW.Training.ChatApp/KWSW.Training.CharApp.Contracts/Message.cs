using System;
using System.Collections.Generic;
using System.Text;

namespace KWSW.Training.CharApp.Contracts
{
    public class Message : BaseEntity
    {
        public string Text { get; set; }
        public DateTime TimePosted { get; set; }
        public string AuthorName { get; set; }
    }
}
