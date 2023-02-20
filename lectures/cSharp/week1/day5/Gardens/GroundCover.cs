class GroundCover : Plant {


    public GroundCover(string thePlant) :base(thePlant) {
        SunReqs = "Partial";
        SpreadRate = 8;
    }
    public override void AddPlant(Plant APlant, Garden ChosenGarden) {
        if(this.SpreadRate > ChosenGarden.GardenCapacity) {
            Console.WriteLine($"{ChosenGarden.GardenName} is too full to currently add {APlant.PlantName}");
        } else {
            base.AddPlant(APlant, ChosenGarden);
        }
    }
        public int SlowGrow() {
        this.SpreadRate = 2;
        Console.WriteLine($"{this.PlantName} is a slow grower and will take 2 years before needing to have more space");
        return this.SpreadRate;
    }
}