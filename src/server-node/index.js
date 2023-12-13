const webSocket = require('ws')

const serverUrl = "ws://127.0.0.1:3000/MinecraftBlock";

const ws = new webSocket(serverUrl);

ws.on('open', () => {
})

ws.on('message', (data) => {
    console.log(data.toString())
})

ws.on('error', (err) => {
})

ws.on('close', () => {
    console.log("Server closed")
})

ws.onopen = (function () {
})







const server = new webSocket.Server({ port: 2000 });
console.log("Started Websocket")
server.on('connection', (socket) => {
    console.log("Client connected");

    socket.on('message', (message) => {
        console.log(`Received: ${message}`);
        ws.send(message.toString())
        if(message === "stop") ws.close()
        socket.send('message received!');
    });

    socket.on('close', () => {
        console.log("Client disconnected :(");
    })
})

