namespace TreeGUI;
internal static class DataManger
{
    public static List<Point> TreeCorners { get; set; } = new List<Point>();
    public static List<Point> LightPositions { get; set; } = new List<Point>();

    public static void PrintDataToFile()
    {
        File.WriteAllText(Application.StartupPath + "Data", FormatData());
    }

    private static string FormatData()
    {
        string data = string.Empty;
        data += "Tree corners\n";
        data += string.Join("\n", TreeCorners);
        data += "\nLight positions\n";
        data += string.Join("\n", LightPositions);
        return data;
    }
}