namespace Bridge;

public class Soundbar : IDevice
{
    public void TurnOn()
    {
        Console.WriteLine("Soundbar is turned on.");
    }

    public void TurnOff()
    {
        Console.WriteLine("Soundbar is turned off.");
    }

    public void SetVolume(int volume)
    {
        Console.WriteLine($"Soundbar volume set to {volume}.");
    }

    public void SetChannel(int channel)
    {
        throw new NotImplementedException("Soundbar does not support channel setting.");
    }
}