namespace Builder
{
    
    public class CommonHouseBuilder : IHouseBuilder
    {
        private House _house = new House();

        public void AddPool()
        {
            _house.Add("Piscina");
        }

        public void AddGarden()
        {
            _house.Add("Jardin");
        }

        public void AddOffice()
        {
            _house.Add("Oficina");
        }

        public void AddTechnology()
        {
            _house.Add("Tecnologia");
        }

        public House GetHouse()
        {
            return _house;
        }

        public void Reset()
        {
            _house = new House();
        }
    }
}