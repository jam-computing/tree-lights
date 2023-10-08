using TreeAPI.Types;

namespace TreeAPI;

internal static class TreeHelper
{
    internal static List<Coordinate> GetCoordinates(this IEnumerable<Coordinate> coords)
    {
        // Query socket
        return coords.ToList();
    }
}