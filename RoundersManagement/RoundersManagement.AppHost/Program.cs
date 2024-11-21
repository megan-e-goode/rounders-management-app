var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.RoundersManagement>("roundersmanagement");

builder.Build().Run();
