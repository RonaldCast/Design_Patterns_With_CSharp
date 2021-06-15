namespace Bridge
{
    public interface ImplementorDevice
    {
        bool IsEnabled();
        void Enable();
        void Disable();
        int GetVolume();
        void SetVolume(int percent);
    }
}