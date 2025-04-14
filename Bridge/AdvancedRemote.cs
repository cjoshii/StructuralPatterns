namespace Bridge;

public class AdvancedRemote(IDevice device) : Remote(device)
{
    private readonly IDevice _device = device;

    public void Mute()
    {
        _device.SetVolume(0);
        Console.WriteLine("Device is muted.");
    }

    public void SetChannel(int channel)
    {
        try
        {
            _device.SetChannel(channel);
        }
        catch (NotImplementedException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}