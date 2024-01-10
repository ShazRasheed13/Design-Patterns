using ProxyPattern;

Image image1= new ProxyImage("image1.jpg");
Image image2 = new ProxyImage("image2.jpg");

image1.Display();
image2.Display();
image1.Display();

