using TreeAPI.Types;

namespace TreeAPI;

// Belongs to ISendable
public class Setup : ISendable
{
    // The name of the Tree
    public string Name { get; set; } = String.Empty;
    // The Sender, used so it can store all the related logs and LED locations
    public string Sender { get; init; } = String.Empty;

    // -1 means a setup request, else turn the corresponding light on
    public int index { get; init; } = -1;
    
    // How many LEDs there are. Typically imported from the ClientConfig
    public int LedCount { get; init; } = 0;
}
