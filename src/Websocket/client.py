import asyncio
import websockets

async def send_and_receive_messages():
    async with websockets.connect("ws://192.168.1.2:8765") as websocket:
        while True:
            user_input = input("Enter a message (or 'exit' to quit): ")
            if user_input == 'exit':
                break  # Exit the loop if the user enters 'exit'
            await websocket.send(user_input)
            response = await websocket.recv()
            print("Server says:", response)

asyncio.get_event_loop().run_until_complete(send_and_receive_messages())
