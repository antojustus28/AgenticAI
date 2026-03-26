using AgenticAI.Core.Models;
using AgenticAI.Infrastructure;
using AgenticAI.Infrastructure.AI;
using AgenticAI.Infrastructure.Memory;
using AgenticAI.Infrastructure.RAG;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace AgenticAI.Agents.Shared
{
    public class IntelligentAgent
    {
        private readonly MemoryService _memory;
        private readonly RagService _rag;
        private readonly LlmService _llm;

        public IntelligentAgent(MemoryService memory, RagService rag, LlmService llm)
        {
            _memory = memory;
            _rag = rag;
            _llm = llm;
        }

        public async Task<string> RunAsync(string sessionId, string input)
        {
            var history = await _memory.GetAsync(sessionId);
            var knowledge = await _rag.SearchAsync(input);

            var context = $"History: {history}\nKnowledge: {knowledge}\nInput: {input}";

            var decisionJson = await _llm.GetDecisionAsync(context);
            var decision = JsonSerializer.Deserialize<AgentDecision>(decisionJson);

            await _memory.SaveAsync(sessionId, context);

            return decision?.FinalAnswer ?? "No response";
        }
    }
}
