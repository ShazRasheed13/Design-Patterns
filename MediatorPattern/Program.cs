using MediatorPattern;

IChatMediator chatRoom = new ChatRoom();

User user1 = new BasicUser(chatRoom, "Alice");
User user2 = new PremiumUser(chatRoom, "Bob");
User user3 = new BasicUser(chatRoom, "Charlie");

((ChatRoom)chatRoom).AddUser(user1);
((ChatRoom)chatRoom).AddUser(user2);
((ChatRoom)chatRoom).AddUser(user3);

user1.Send("Hello everyone!");
user2.Send("Hello from Bob!");
