using AgenticAI.Core.Interfaces;
using AgenticAI.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AgenticAI.Agents.Order
{
    public class OrderAgent : IAgent
    {
        public Task<string> ExecuteAsync(AgentContext context)
            => Task.FromResult("Order Agent Response");
    }
}
