using System;
using System.Collections.Generic;
using System.Text;

namespace AgenticAI.Core.Models
{
    public class AgentDecision
    {
        public string Action { get; set; }
        public string Agent { get; set; }
        public string Tool { get; set; }
        public string Input { get; set; }
        public string FinalAnswer { get; set; }
    }
}
