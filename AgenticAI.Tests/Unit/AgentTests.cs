using Xunit;
using AgenticAI.Agents.Shared;
using AgenticAI.Infrastructure.AI;
using AgenticAI.Infrastructure.Memory;
using AgenticAI.Infrastructure.RAG;
using System;
using System.Collections.Generic;
using System.Text;

namespace AgenticAI.Tests.Unit
{
    public class AgentTests
    {
        [Fact]
        public async Task Should_Return_Response()
        {
            var agent = new IntelligentAgent(new MemoryService(), new RagService(), new LlmService());
            var result = await agent.RunAsync("test", "Hello");

            Assert.NotNull(result);
        }
    }
}
