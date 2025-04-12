namespace API;

public class WeatherForecast
{
    public DateOnly Date { get; set; }

    public int TemperatureC { get; set; }

    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

    public string? Summary { get; set; }
}
//nice-gnu-62172.upstash.io:6379,password=AfLcAAIjcDFkYzYzNDU3Njc4ZTI0YjE1OTgxNDVlNmViNzMzOGY0NXAxMA,ssl=true,abortConnection=False