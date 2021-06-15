namespace Bridge
{
    public abstract class AbstractionRemoteControl
    {
        public ImplementorDevice ImplementorDevice { get; set; }

        public virtual void TogglePower()
        {
            if (ImplementorDevice.IsEnabled())
            {
                ImplementorDevice.Disable();
            }
            else
            {
                ImplementorDevice.Enable();
            }
        }

        public virtual int GetVolume()
        {
            return ImplementorDevice.GetVolume();
        }

        public virtual void SetVolume(int percent)
        {
            ImplementorDevice.SetVolume(percent);
        }
    }
}