import asyncio
import websockets

async def send_coords(file_string, server_uri):
    async with websockets.connect(server_uri) as websocket:
        try:
                    await websocket.send(file_string)
                    print(f"Sent: {file_string}")
        except Exception as e:
            print(f"Error: {e}")


file_name = "coords.txt"
server_uri = "ws://192.168.1.2:8765"  # Replace with the actual WebSocket server address
filecontents = ""
with open(file_name, 'r') as file:
    filecontents = (''.join(file)).strip().replace("\n", "")[2:]

asyncio.run(send_coords(filecontents, server_uri))
