using FlyweightPattern;

Forest forest = new Forest();

forest.PlantTree(1, 2, "Oak", "Green");
forest.PlantTree(3, 4, "Oak", "Green");
forest.PlantTree(5, 6, "Oak", "Green");

forest.Display();
