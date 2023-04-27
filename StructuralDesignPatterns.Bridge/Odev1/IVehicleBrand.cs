namespace StructuralDesignPatterns.Bridge.Odev1;

public interface IVehicleBrand
{
    string GetBrandName();
}

public interface IVehicleModel
{
    string GetModelName();
}

public class Toyota : IVehicleBrand
{
    public string GetBrandName() => "Toyota";
}

public class BMW : IVehicleBrand
{
    public string GetBrandName() => "BMW";
}

public class Corolla : IVehicleModel
{
    public string GetModelName() => "Corolla";
}

public class X3 : IVehicleModel
{
    public string GetModelName() => "X3";
}

public class X5 : IVehicleModel
{
    public string GetModelName() => "X5";
}

public class Vehicle
{
    private readonly IVehicleBrand _brand;
    private readonly IVehicleModel _model;
    public Vehicle(IVehicleBrand brand, IVehicleModel model)
    {
        _brand = brand;
        _model = model;
    }

    public string GetVehicleInfo()
    {
        return $"{_brand.GetBrandName()} - {_model.GetModelName()}";
    }
}
