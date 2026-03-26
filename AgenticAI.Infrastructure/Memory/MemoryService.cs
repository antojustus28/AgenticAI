using System;
using System.Collections.Generic;
using System.Text;

namespace AgenticAI.Infrastructure.Memory
{
    public class MemoryService
    {
        private static readonly Dictionary<string, string> _store = new();

        public Task SaveAsync(string sessionId, string context)
        {
            _store[sessionId] = context;
            return Task.CompletedTask;
        }

        public Task<string?> GetAsync(string sessionId)
        {
            _store.TryGetValue(sessionId, out var value);
            return Task.FromResult(value);
        }
    }
}
