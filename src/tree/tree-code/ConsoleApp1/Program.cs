using TreeAPI;

using (var tree = new Tree())
{
    tree.Connect("localhost", 3000, "TreeSocket");
    tree.Send("/TreeSocket");
    Console.ReadKey();
}