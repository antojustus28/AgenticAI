using System;
using System.Collections.Generic;
using System.Text;

namespace AgenticAI.Core.Interfaces
{
    public interface IAgent
    {
        Task<string> ExecuteAsync(Models.AgentContext context);
    }
}
