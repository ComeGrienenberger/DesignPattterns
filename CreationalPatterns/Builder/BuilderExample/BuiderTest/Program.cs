using BuilderExample;

var myDirector = new ShipBuilderDirector();

myDirector.BuildShip(ShipType.FirstFeeder, "MyFeeder");
var feeder = myDirector.GetShip();

myDirector.BuildShip(ShipType.SecondFeed, "HeyJude");
var secondFeeder = myDirector.GetShip();

myDirector.BuildShip(ShipType.FirstVessel, "NotTitanic");
var firstVessel = myDirector.GetShip();

Console.WriteLine(feeder);

Console.WriteLine(secondFeeder);

Console.WriteLine(firstVessel);

