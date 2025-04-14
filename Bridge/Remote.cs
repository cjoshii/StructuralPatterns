namespace Bridge;

public class Remote(IDevice device)
{
    private readonly IDevice _device = device;

    public void TurnOn()
    {
        _device.TurnOn();
    }

    public void TurnOff()
    {
        _device.TurnOff();
    }

    public void SetVolume(int volume)
    {
        _device.SetVolume(volume);
    }
}