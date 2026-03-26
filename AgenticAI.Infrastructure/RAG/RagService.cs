using System;
using System.Collections.Generic;
using System.Text;

namespace AgenticAI.Infrastructure.RAG
{
    public class RagService
    {
        public Task<string> SearchAsync(string query)
        {
            return Task.FromResult($"[RAG Knowledge for: {query}]");
        }
    }
}
