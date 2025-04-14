namespace Bridge;

public interface IDevice
{
    void TurnOn();
    void TurnOff();
    void SetVolume(int volume);
    void SetChannel(int channel);
}