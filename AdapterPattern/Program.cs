using AdapterPattern;

Client client = new Client();
LegacyPrinter legacyPrinter = new LegacyPrinter();
LegacyPrinterAdapter adapter = new LegacyPrinterAdapter(legacyPrinter);
client.PrintMessage(adapter, "Shaz your message is registered");
