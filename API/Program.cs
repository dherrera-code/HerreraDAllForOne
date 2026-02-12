using API.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<HelloWorldService>();
builder.Services.AddScoped<AskingQuestionsService>();
builder.Services.AddScoped<AddingTwoNumberService>();
builder.Services.AddScoped<MadLibService>();
builder.Services.AddScoped<OddOrEvenService>();
builder.Services.AddScoped<ReverseItAlphaService>();
builder.Services.AddScoped<ReverseItNumService>();
builder.Services.AddScoped<Magic8BallService>();
builder.Services.AddScoped<RestaurantPickerService>();
builder.Services.AddScoped<GuessItService>();
builder.Services.AddScoped<GreaterOrLessService>();
builder.Services.AddScoped<MadLibShortService>();

builder.Services.AddCors(options =>
{
    options.AddPolicy("Client", policy =>
    {
        policy.WithOrigins("http://localhost:5500","http://127.0.0.1:5500","http://localhost:5173","https://white-island-0ac32031e.1.azurestaticapps.net/")
        .AllowAnyHeader().AllowAnyMethod();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("Client");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();