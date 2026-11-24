var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => Results.Content("""
    <!DOCTYPE html>
    <html lang="en">
    <head>
        <meta charset="utf-8">
        <meta name="viewport" content="width=device-width, initial-scale=1">
        <title>AspTestApp</title>
        <style>
            body { font-family: system-ui, sans-serif; max-width: 760px; margin: 12vh auto; padding: 0 24px; }
            h1 { color: #1769aa; }
            .card { padding: 24px; border: 1px solid #ddd; border-radius: 12px; }
        </style>
    </head>
    <body>
        <div class="card">
            <h1>Hello World from ASP.NET Core!</h1>
            <p>Your .NET web application is running successfully.</p>
            <p>Next step: deploy this app to Azure App Service.</p>
        </div>
    </body>
    </html>
    """, "text/html"));

app.MapGet("/health", () => Results.Ok(new { status = "Healthy" }));

app.Run();
