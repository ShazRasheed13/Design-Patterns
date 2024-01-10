using ObserverPattern;

WeatherStation weatherStation = new WeatherStation();
WeatherDisplay weatherDisplay1 = new WeatherDisplay();
WeatherDisplay weatherDisplay2 = new WeatherDisplay();

weatherStation.AddObserver(weatherDisplay1);
weatherStation.AddObserver(weatherDisplay2);


weatherStation.SetMeasurements(20, 50, 1000);
weatherStation.SetMeasurements(21, 55, 1005);
weatherStation.SetMeasurements(22, 60, 1010);
