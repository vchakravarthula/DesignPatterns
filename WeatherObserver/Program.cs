namespace WeatherObserver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World! Welcome to weather report");

            var weatherData = new Subject.WeatherData();

            var currentCondition = new Observer.CurrentCondition(weatherData);
            var statisticsDisplay = new Observer.WeatherStatistics(weatherData);

            weatherData.SetMeasurements(80, 65, 30.4f);
            weatherData.SetMeasurements(82, 70, 29.2f);
            weatherData.SetMeasurements(78, 90, 29.2f);
        }
    }
}
