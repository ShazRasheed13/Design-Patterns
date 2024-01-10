using AbstractFactoryPattern;

IElectronicFactory gamingFactory = new GamingElectronicsFactory();
ILaptop gamingLaptop = gamingFactory.CreateLaptop();
IsmartPhone gamingSmartPhone = gamingFactory.CreateSmartPhone();

gamingLaptop.Assemble();
gamingSmartPhone.Assemble();
