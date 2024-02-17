using BuilderExample;

var myDirector = new ShipBuilderDirector();

myDirector.BuildShip(ShipType.FirstFeeder);
var feeder = myDirector.GetShip();

myDirector.BuildShip(ShipType.SecondFeed);
var secondFeeder = myDirector.GetShip();

myDirector.BuildShip(ShipType.FirstVessel);
var firstVessel = myDirector.GetShip();

Console.WriteLine(feeder);

Console.WriteLine(secondFeeder);

Console.WriteLine(firstVessel);

