// Exercism: Jedics_Toys
class RemoteControlCar
{
    private int _distense = 0;
    private int _battery = 100;

    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }

    public string DistanceDisplay()
    {
        return $"Driven {_distense} meters";
    }

    public string BatteryDisplay()
    {
        if (_battery > 0)
        {
            return $"Battery at {_battery}%";
        }
        else
        {
            return $"Battery empty";
        }
    }

    public void Drive()
    {
        if (_battery > 0)
        {
            _distense += 20;
            _battery -= 1;
        }
    }
}
