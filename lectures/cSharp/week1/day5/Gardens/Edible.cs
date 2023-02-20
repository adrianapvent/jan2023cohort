class Edible : Plant {
    public string Category;
    public string HarvestTime;

    public Edible(string thePlant, string theCategory, string theHarvest) :base(thePlant) {
        Category = theCategory;
        HarvestTime = theHarvest;
        AllGardens = new List<Garden>() {
            new Garden("Juli's Herb Garden"),
            new Garden("Melissa's Edible Garden")
        };
    }
}