
using StrategyPattern;

ShoppingCart shoppingCart = new ShoppingCart();

shoppingCart.SetPaymentStrategy(new CreditCardPayment());
shoppingCart.Checkout(100);

shoppingCart.SetPaymentStrategy(new PayPalPayment());
shoppingCart.Checkout(200);
