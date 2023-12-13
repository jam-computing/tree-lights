using TreeAPI.Types;

namespace TreeAPI.Misc;

// Non-exposed class with some simple helper methods 
internal static class TreeHelper
{
    // Return all the coordinates of the current Tree
    // Used to send to server.
    internal static List<Coordinate> GetCoordinates(this IEnumerable<Coordinate> coords)
    {
        // Query socket
        return coords.ToList();
    }
}