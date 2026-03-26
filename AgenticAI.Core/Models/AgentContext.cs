using System;
using System.Collections.Generic;
using System.Text;

namespace AgenticAI.Core.Models
{
    public class AgentContext
    {
        public string SessionId { get; set; } = Guid.NewGuid().ToString();
        public string Input { get; set; }
        public List<string> History { get; set; } = new();
    }
}
