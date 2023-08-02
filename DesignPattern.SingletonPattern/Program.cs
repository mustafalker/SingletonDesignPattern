using DesignPattern.SingletonPattern;


Console.WriteLine(DateTime.Now.ToLongTimeString());
var countries = await CountryProvider.Instance.GetCountries();

foreach (var country in countries)
{
    Console.WriteLine(country.Name);
}

// Another Service ...

//var countryProvider1 = new CountryProvider(); //burda bize kızıyor çünki private yaptık ctor unu bir kez daha create edemezsin diyor bize 

Console.WriteLine(DateTime.Now.ToLongTimeString());
var countries1 = await CountryProvider.Instance.GetCountries();