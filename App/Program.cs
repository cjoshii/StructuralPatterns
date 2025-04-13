using Adapter;

Console.WriteLine("Hello, World!");
var hole = new RoundHole(5);
var smallCylinder = new Cylinder(5);
var largeCylinder = new Cylinder(10);
Console.WriteLine(hole.CanFit(smallCylinder)); // True
Console.WriteLine(hole.CanFit(largeCylinder)); // False

var smallCube = new Cube(5);
var largeCube = new Cube(9);


Console.WriteLine(hole.CanFit(new CubeAdapter(smallCube))); // True
Console.WriteLine(hole.CanFit(new CubeAdapter(largeCube))); // False