using AgenticAI.Core.Interfaces;
using AgenticAI.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AgenticAI.Orchestration.Routers
{
    public class AgentRouter
    {
        private readonly Dictionary<string, IAgent> _agents;

        public AgentRouter()
        {
            _agents = new Dictionary<string, IAgent>
            {
                { "customer", new Agents.Customer.CustomerAgent() },
                { "order", new Agents.Order.OrderAgent() }
            };
        }

        public Task<string> RouteAsync(string agent, AgentContext context)
        {
            return _agents.ContainsKey(agent)
                ? _agents[agent].ExecuteAsync(context)
                : Task.FromResult("Unknown agent");
        }
    }
}
