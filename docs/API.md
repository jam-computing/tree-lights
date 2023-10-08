# Tree-Light API 

This API was created to allow users to easily interface with individually addressable christmas tree lights.

## Getting Started

To get started with the API, you can use either:

+ -- Not Implemented -- The NuGet Package

+ Clone this Repository and copy the project to your solution

## Your first program :exclamation_mark

The core of the API is the `Tree` class. This allows you to interface with a TreeServer without having to do any networking.

The `Tree` can be wrapped in a `using` statement, and will automically close the connection when out of scope.

```cs
using(Tree tree = new Tree()) {
    // Code here
}
```

This looks nice, but nothing actually happens. Let's add a `Connect` to the program.

For the rest of this guide, we are going to assume you already have a `using` statement.

## `Connect()`

The `Connect()` method can take two different parameters, an `IpAddr` object, or a couple strings and a port.

Let's use the `IpAddr` object.

```cs
IPAddr ip = new IPAddr() {
    Address = "localhost",
    Port = 3000,
    Path = "Text"
};
```

+ The `Address` is the IpV4 address of whatever computer is hosting the server. In your case, this would be the RPi hosting the server.
+ The `Port` is the port the server is running on. This defaults to 3000.
+ The `Path` is the specific way you want to communicate with the server.

Now to actually connect.

```cs
tree.Connect(ip);
```

This code will connect you to the RPi / Server.

To check if the connection actually worked, use the `IsConnected` property of the `Tree` class.

This will return `true` if the connection actually exists

```cs
if(!tree.IsConnected) return;
```

For real world applications, you should probably add some information here to report to the user, but for our purposes, its fine

## `Send()`

Actually sending data is very easy.

The `Send()` method has 2 overloads, it can take either a `ISendable` or a `string`.

Let's send a string.

```cs
tree.Send("Hello, Tree!");
```

This will send a string to the server.

But what if we want to send more complex data?

We should use an `ISendable`, such as a `Frame`.

First, we need to change the `Path` to `Frame`

```cs
Path = "Frame"
```

Then we should create a `Frame` object and send that instead

```cs
Frame frame = new (new List<(int, int, int)>(), "Intrigued Reader");

tree.Send(frame)
```

