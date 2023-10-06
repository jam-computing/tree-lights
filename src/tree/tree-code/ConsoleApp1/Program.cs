using TreeAPI;
using TreeAPI.Types;
using System.Linq;

var rng = new Random();

List<(int, int, int)> pixels = Enumerable.Range(0, 300).
    Select(x => (rng.Next(0,255), rng.Next(0,255), rng.Next(0,255)))
    .ToList();

Frame data = new Frame(pixels, "Laptop One");

using (var tree = new Tree())
{
    tree.Connect(new IpAddr() {Address = "localhost", Port = 3000, Path = "Frame"});
    tree.Send(data);
    Console.ReadKey();
}
