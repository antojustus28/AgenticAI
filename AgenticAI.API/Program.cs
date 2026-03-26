using AgenticAI.Agents.Shared;
using AgenticAI.Infrastructure.AI;
using AgenticAI.Infrastructure.Memory;
using AgenticAI.Infrastructure.RAG;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddSingleton<MemoryService>();
builder.Services.AddSingleton<RagService>();
builder.Services.AddSingleton<LlmService>();
builder.Services.AddSingleton<IntelligentAgent>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapPost("/agent", async (string input, IntelligentAgent agent) =>
{
    var result = await agent.RunAsync(Guid.NewGuid().ToString(), input);
    return Results.Ok(result);
});

await app.RunAsync();