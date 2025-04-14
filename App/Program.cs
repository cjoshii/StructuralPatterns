using Adapter;
using Bridge;
using Composite;
using Decorator;

Console.WriteLine("Adapter Pattern Example");
Console.WriteLine("=====================================");
var hole = new RoundHole(5);
var smallCylinder = new Cylinder(5);
var largeCylinder = new Cylinder(10);
Console.WriteLine(hole.CanFit(smallCylinder)); // True
Console.WriteLine(hole.CanFit(largeCylinder)); // False

var smallCube = new Cube(5);
var largeCube = new Cube(9);

Console.WriteLine(hole.CanFit(new CubeAdapter(smallCube))); // True
Console.WriteLine(hole.CanFit(new CubeAdapter(largeCube))); // False

Console.WriteLine("=====================================");

Console.WriteLine("Bridge Pattern Example");
Console.WriteLine("=====================================");
var tv = new Tv();
var soundbar = new Soundbar();

var remote = new VoiceRemote(tv);
remote.ExecuteCommand("turn on");
remote.ExecuteCommand("mute");
remote.ExecuteCommand("set channel 5");
remote.ExecuteCommand("set volume 10");
remote.ExecuteCommand("turn off");

var advancedRemote = new AdvancedRemote(soundbar);
advancedRemote.TurnOn();
advancedRemote.Mute();
advancedRemote.SetChannel(5);
advancedRemote.SetVolume(10);
advancedRemote.TurnOff();

Console.WriteLine("=====================================");

Console.WriteLine("Composite Pattern Example");
Console.WriteLine("=====================================");
var file1 = new Composite.File("file1-level2.txt");
var file2 = new Composite.File("file2-level2.txt");
var file3 = new Composite.File("file3-level2.txt");
var directory1 = new Composite.Directory("directory-level1.txt");

directory1.Add(file1);
directory1.Add(file2);
directory1.Add(file3);

var file4 = new Composite.File("file1-level1.txt");
var file5 = new Composite.File("file2-level1.txt");

var root = new Composite.Directory("Root");
root.Add(directory1);
root.Add(file4);
root.Add(file5);

root.ShowInfo();
Console.WriteLine("=====================================");

Console.WriteLine("Decorator Pattern Example");
Console.WriteLine("=====================================");
var message = "Hello, this is a test message!";

INotifier notifier = new EmailNotifier();

Console.WriteLine("Do you want to also send a push notification? (y/n)");
var input = Console.ReadLine();

if (input?.ToLower() == "y")
{
    notifier = new PushDecorator(notifier);
}

Console.WriteLine("Do you want to also send an SMS notification? (y/n)");
input = Console.ReadLine();
if (input?.ToLower() == "y")
{
    notifier = new SMSDecorator(notifier);
}

notifier.Notify(message);


//Let's test the coffee shop example
Console.WriteLine("Welcome to the Coffee Shop!");

ICoffee coffee = new BlackCoffe();

Console.WriteLine($"Your order: {coffee.GetDescription()} - Cost: {coffee.GetCost()}$");

Console.WriteLine("Do you want to add milk? (y/n)");
input = Console.ReadLine();

if (input?.ToLower() == "y")
{
    coffee = new MilkDecorator(coffee);
}
Console.WriteLine($"Your order: {coffee.GetDescription()} - Cost: {coffee.GetCost()}$");

Console.WriteLine("Do you want to add sugar? (y/n)");
input = Console.ReadLine();

if (input?.ToLower() == "y")
{
    coffee = new SugarDecorator(coffee);
}
Console.WriteLine($"Your order: {coffee.GetDescription()} - Cost: {coffee.GetCost()}$");

Console.WriteLine("Do you want to add caramel? (y/n)");
input = Console.ReadLine();

if (input?.ToLower() == "y")
{
    coffee = new CaramelDecorator(coffee);
}
Console.WriteLine($"Your order: {coffee.GetDescription()} - Cost: {coffee.GetCost()}$");

Console.WriteLine("Do you want to add extra shot? (y/n)");
input = Console.ReadLine();

if (input?.ToLower() == "y")
{
    coffee = new ExtraShotDecorator(coffee);
}
Console.WriteLine($"Your order: {coffee.GetDescription()} - Cost: {coffee.GetCost()}$");

Console.WriteLine("Thank you for your order! Enjoy your coffee!");
Console.WriteLine("=====================================");