using Adapter;
using Bridge;

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