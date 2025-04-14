namespace Decorator;

public interface ICoffee{
    double GetCost();
    string GetDescription();
}

public class BlackCoffe : ICoffee{
    public double GetCost()
    {
        return 1.99;
    }

    public string GetDescription()
    {
        return "Black Coffee";
    }
}

public class CoffeeDecorator : ICoffee{
    protected readonly ICoffee _coffee;

    public CoffeeDecorator(ICoffee coffee)
    {
        this._coffee = coffee;
    }

    public virtual double GetCost()
    {
        return _coffee.GetCost();
    }

    public virtual string GetDescription(){
        return _coffee.GetDescription();
    }
}

public class MilkDecorator : CoffeeDecorator{
    public MilkDecorator(ICoffee coffee) : base(coffee)
    {
    }

    public override double GetCost()
    {
        return _coffee.GetCost() + 0.50;
    }

    public override string GetDescription()
    {
        return _coffee.GetDescription() + ", Milk";
    }
}
public class SugarDecorator : CoffeeDecorator{
    public SugarDecorator(ICoffee coffee) : base(coffee)
    {
    }

    public override double GetCost()
    {
        return _coffee.GetCost() + 0.25;
    }

    public override string GetDescription()
    {
        return _coffee.GetDescription() + ", Sugar";
    }
}

//Add caramel decorator
public class CaramelDecorator : CoffeeDecorator{
    public CaramelDecorator(ICoffee coffee) : base(coffee)
    {
    }

    public override double GetCost()
    {
        return _coffee.GetCost() + 0.75;
    }

    public override string GetDescription()
    {
        return _coffee.GetDescription() + ", Caramel";
    }
}

//Add ExtraShotDecorator
public class ExtraShotDecorator : CoffeeDecorator{
    public ExtraShotDecorator(ICoffee coffee) : base(coffee)
    {
    }

    public override double GetCost()
    {
        return _coffee.GetCost() + 1.00;
    }

    public override string GetDescription()
    {
        return _coffee.GetDescription() + ", Extra Shot";
    }
}
