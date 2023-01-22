using CSharpPractice;

var vehicleList = new List<Vehicle>();

var car = new Car() { HasTrunk = true, Make = "Ford", Model = "Mustang", Year = "2010" };
var motorcycle = new Motorcycle() { HasSideCart = true, Make = "Harley Davidson", Model = "HD", Year = "2020" };
Vehicle vehicle1 = new Car() { HasTrunk = true, Make = "Dodge", Model = "Dodgeball", Year = "2011" };
Vehicle motorcycle2 = new Motorcycle() { HasSideCart = true, Make = "HD", Model = "HDModel", Year = "2000" };

vehicleList.Add(car);
vehicleList.Add(motorcycle);
vehicleList.Add(vehicle1);
vehicleList.Add(motorcycle2);

foreach (var item in vehicleList)
{
    Console.WriteLine(item);
}
