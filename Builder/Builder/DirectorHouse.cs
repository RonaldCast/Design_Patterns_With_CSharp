namespace Builder
{
    public class DirectorHouse
    {
        private IHouseBuilder _houseBuilder;

        public IHouseBuilder HouseBuilder
        {
            set { _houseBuilder = value; }
        }

        public void BuildHouseSimple()
        {
            _houseBuilder.AddGarden();
        }

        public void BuildFullHouse()
        {
            _houseBuilder.AddGarden();
            _houseBuilder.AddOffice();
            _houseBuilder.AddPool();
            _houseBuilder.AddTechnology();
            
        }
    }
}