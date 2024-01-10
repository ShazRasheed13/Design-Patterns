
using FactoryMethodPattern;

//Here the client code is not aware of the concrete class that is instantiated.
DocumentCreator resumeCreator = new ResumeCreator();
IDocument resume = resumeCreator.CreateDocument();
resume.CreateDocument();
