using System;

namespace WebServicesDemo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGetWeather_Click(object sender, EventArgs e)
        {
            WeatherService.WeatherSoapClient client = new WeatherService.WeatherSoapClient("WeatherSoap");
            WeatherService.WeatherReturn result = client.GetCityWeatherByZIP(txtZip.Text);

            if (result.Success)
            {
                lblError.Text = string.Empty;
                lblCity.Text = result.City;
                lblState.Text = result.State;
                lblTemperature.Text = result.Temperature;
                lblWeatherStationCity.Text = result.WeatherStationCity;
                lblWind.Text = result.Wind;
            }
            else
            {
                lblError.Text = result.ResponseText;
                lblCity.Text = string.Empty;
                lblState.Text = string.Empty;
                lblTemperature.Text = string.Empty;
                lblWeatherStationCity.Text = string.Empty;
                lblWind.Text = string.Empty;
            }
        }
    }
}