namespace Bridge
{
    public class ConcreteImplementorDevice : ImplementorDevice
    {
        private  bool _enable = false;
        private int _volume = 0; 
        public bool IsEnabled()
        {
            return _enable;
        }

        public void Enable()
        {
            _enable = true;
        }

        public void Disable()
        {
            _enable = false; 
        }

        public int GetVolume()
        {
            return _volume;
        }

        public void SetVolume(int percent)
        {
            _volume = percent;
        }
    }
}