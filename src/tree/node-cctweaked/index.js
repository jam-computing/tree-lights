const webSocket = require('ws')

const server = new webSocket.Server({ port: 3000 });
console.log("Started Websocket")
server.on('connection', (socket) => {
    console.log("Client connected");

    socket.on('message', (message) => {
        console.log(`Received: ${message}`);
        socket.send('message received!');
    });

    socket.on('close', () => {
        console.log("Client disconnected :(");
    })
})