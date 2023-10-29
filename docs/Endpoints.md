# Server endpoints

A list of TreeServer endpoints and what they do

### `/Frame` and `/Animation`

This endpoint is for receiving a `Frame` or `Animation` object.

+ Any `ISendable` object can be sent.
+ Any filepath can be sent. ( see filepath somewhere )

This will take the ISendable json or filepath and translate it into a useable object.

+ This endpoint will NOT return anything

_TreeAPI Implementation_

**_Remeber you MUST `using TreeAPI` at the top of your file!_**

```cs
using(Tree tree = new ())  {

    // Connect using ip 
    // This syntax might looks weird if you are new to C#  

    tree.Connect( "Frame".GetIp() );

    // The constructor takes a List of colours and a sender string
    Frame frame = new Frame(pixels, "Sender Tutorial");

    tree.Send()
}
```

### `/Text` and `/Ping`

This endpoint is primarily used for logs.

+ Any string can be sent 

The sent string will then be echoed to the console

+ A conformation message will then be sent back to the client.
+ In the case of `Ping`, it will just send back the message it received

This can also be used to check for a working connection.

_TreeAPI Implementation_

```cs
// Connect to tree here 

// Send the plain text message
tree.Send("Hello, World!");

// Wait for ~100 ms to ensure message is received 
Thread.Sleep(100);

// Do whatever you want with the message:w
Console.WriteLine( tree.ReceivedMessage );
```

### `/MinecraftBlock` and `/BlockRequest`

These endpoints are used for talking to the minecraft client.

You can ignore this one as they are handled by the lua client.

### `/SetupRequest`

This endpoint is exclusvely used with setting up a tree through the GUI.

The endpoints are still available programmatically, in case you wanted to use them with another language.

+ Any `Setup` json can be sent, which contains the index of the light that should be switched on.

If the index is -1, then is called an `Initial Setup`, where the server prepares for a setup.

+ The server will send back the index it just switched on, to ensure the client and server are synced.

### `/CreateFile`

This is used to send a ISendable, and the server will store it on disk.

+ Any `ISendable` json can be sent.

If it is a `Frame`, Then it writes the json to the `data/frames` directory.
If not, then it must be a `Animation`, so it writes to the `data/animations` directory.

### `/FrameRequest`

This request a json list of filenames that are in the `data/frames` or `data/animations` directory.
The client can then send back a filename through the endpoints, `/Frame` or `/Animation`.








