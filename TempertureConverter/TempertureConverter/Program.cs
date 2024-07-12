
Console.WriteLine("Witaj w konwerterze stopni temperatury!");
Console.WriteLine();

while (true)
{
    Console.WriteLine("Wybierz 1 jeśli chcesz FnaC lub wybierz 2 jeśli chcesz CnaF");
    var input = Console.ReadLine();
    if (input == "1")
    {
        Console.WriteLine("Podaj wartość stopni F do konwersji na C");
        string inputTemperatureF = Console.ReadLine();
        if (float.TryParse(inputTemperatureF, out float temperatureF) && temperatureF >= -459.67)
        {
            float degreeC = (temperatureF - 32) * 5 / 9;
            Console.WriteLine($"{inputTemperatureF} stopni F jest równe {Math.Round(degreeC, 2)} stopni C");
        }
        else if (temperatureF < -459.67)
        {
            Console.WriteLine($"{inputTemperatureF} jest nieprawdziwa, najniższa wartośc temperatury wynosi -459,67 stopni");
        }
        else
        {
            Console.WriteLine($"{inputTemperatureF} niepoprawna wartość temperatury");
        }
    }
    else if (input == "2")
    {
        Console.WriteLine("Podaj wartość stopni C do konwersji na F");
        string inputTemperatureC = Console.ReadLine();
        if (float.TryParse(inputTemperatureC, out float temperatureC) && temperatureC >= -273.15)
        {
            float degreeF = (temperatureC * 9 / 5) + 32;
            Console.WriteLine($"{inputTemperatureC} stopni C jest równe {degreeF} stopni F");
        }
        else if(temperatureC < -273.15 )
        {
            Console.WriteLine($"{inputTemperatureC} jest nieprawdziwa, najniższa wartośc temperatury wynosi -273,15 stopni");
        }
        else
        {
            Console.WriteLine($"{inputTemperatureC} niepoprawna wartość temperatury");
        }
    }
    Console.WriteLine();
}


