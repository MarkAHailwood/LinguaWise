using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using VideoChat;

await WebHost.CreateDefaultBuilder(args)
    .UseStartup<Startup>()
    .Build()
    .RunAsync();
