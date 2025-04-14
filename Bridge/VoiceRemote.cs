namespace Bridge;

public class VoiceRemote(IDevice device) : AdvancedRemote(device)
{
    public void ExecuteCommand(string command)
    {
        switch (command.ToLower())
        {
            case "turn on":
                TurnOn();
                break;
            case "turn off":
                TurnOff();
                break;
            case "mute":
                Mute();
                break;
            default:
            
                if (command.StartsWith("set volume"))
                {
                    var volume = int.Parse(command.Split(' ')[2]);
                    SetVolume(volume);
                }
                else if (command.StartsWith("set channel"))
                {
                    var channel = int.Parse(command.Split(' ')[2]);
                    SetChannel(channel);
                }
                else
                {
                    Console.WriteLine("Unknown command.");
                }
                break;
        }
    }
}