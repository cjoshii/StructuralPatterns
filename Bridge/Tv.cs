namespace Bridge;

public class Tv : IDevice
{
    public void TurnOn()
    {
        Console.WriteLine("TV is turned on.");
    }

    public void TurnOff()
    {
        Console.WriteLine("TV is turned off.");
    }

    public void SetVolume(int volume)
    {
        Console.WriteLine($"TV volume set to {volume}.");
    }

    public void SetChannel(int channel)
    {
        Console.WriteLine($"TV channel set to {channel}.");
    }
}