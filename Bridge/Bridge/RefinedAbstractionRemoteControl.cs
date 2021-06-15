namespace Bridge
{
    public class RefinedAbstractionDevice : AbstractionRemoteControl
    {
        private readonly int _volume = 10; 
        
        public override int GetVolume()
        {
            return _volume;
        }
    }
}