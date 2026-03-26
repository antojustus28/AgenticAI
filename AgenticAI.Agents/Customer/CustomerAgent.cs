using System;
using System.Collections.Generic;
using System.Text;
using AgenticAI.Core.Interfaces;
using AgenticAI.Core.Models;

namespace AgenticAI.Agents.Customer
{
    public class CustomerAgent : IAgent
    {
        public Task<string> ExecuteAsync(AgentContext context)
            => Task.FromResult("Customer Agent Response");
    }
}
