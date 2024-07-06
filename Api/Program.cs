using Api.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.AddRegistrationService();
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
   {
       c.ConfigObject.AdditionalItems.Add("persistAuthorization", true);
   });
}

app.UseAuthentication();
app.UseRouting();
app.UseCors("AllowAllOrigins");
app.UseAuthorization();
app.MapControllers();
app.UseAntiforgery();

app.UseHttpsRedirection();

app.Run();