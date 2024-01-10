// Client code

using ChainOfResponsibilityPattern;

IApprover manager = new Manager();
IApprover director = new Director();
IApprover vicePresident = new VicePresident();

// Creating a chain of responsibility
manager.ProcessRequest(new PurchaseRequest(1, "Office Supplies", 800));
director.ProcessRequest(new PurchaseRequest(2, "New Project Equipment", 3500));
vicePresident.ProcessRequest(new PurchaseRequest(3, "Conference Sponsorship", 12000));

// Alternative approach using a chain
PurchaseHandler purchaseHandler = new PurchaseHandler(manager);
purchaseHandler.ProcessPurchase(new PurchaseRequest(4, "Marketing Materials", 600));
purchaseHandler.ProcessPurchase(new PurchaseRequest(5, "IT Infrastructure Upgrade", 7000));
purchaseHandler.ProcessPurchase(new PurchaseRequest(6, "Company Event Sponsorship", 18000));
