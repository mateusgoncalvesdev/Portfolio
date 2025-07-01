namespace Portfolio.Services;

public class DeviceService
{
    public bool IsMobile { get; private set; }

    public void SetDeviceType(int width)
    {
        IsMobile = width < 768;
    }
}

