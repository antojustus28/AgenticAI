using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace AgenticAI.Infrastructure.AI
{
    public class LlmService
    {
        public Task<string> GetDecisionAsync(string input)
        {
            var decision = new
            {
                action = "final",
                finalAnswer = $"Processed: {input}"
            };

            return Task.FromResult(JsonSerializer.Serialize(decision));
        }
    }
}
