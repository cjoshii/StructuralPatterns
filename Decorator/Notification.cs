namespace Decorator;

public interface INotifier{
    void Notify(string message);
}

public class EmailNotifier : INotifier
{
    public void Notify(string message)
    {
        // Logic to send email notification
        Console.WriteLine($"Email sent with message: {message}");
    }
}

public class NotifierDecorator : INotifier
{
    protected INotifier _notifier;

    public NotifierDecorator(INotifier notifier)
    {
        this._notifier = notifier;
    }

    public virtual void Notify(string message)
    {
        // Call the base notifier to send the message
        _notifier.Notify(message); 
    }
}

public class SMSDecorator : NotifierDecorator
{

    public SMSDecorator(INotifier notifier) : base(notifier)
    {
    }
    public override void Notify(string message)
    {
        // Call the base notifier to send the message
        _notifier.Notify(message); 
        // Logic to send SMS notification
        Console.WriteLine($"SMS sent with message: {message}");
    }
}

public class PushDecorator : NotifierDecorator
{
    public PushDecorator(INotifier notifier) : base(notifier)
    {
    }
    public override void Notify(string message)
    {
        // Call the base notifier to send the message
        _notifier.Notify(message); 
        // Logic to send push notification
        Console.WriteLine($"Push notification sent with message: {message}");
    }
}