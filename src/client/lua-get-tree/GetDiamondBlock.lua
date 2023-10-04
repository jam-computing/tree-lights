local serverUrl = "ws://localhost:3000"
local ws = nil
local err = nil

local ws = http.websocket(serverUrl)


local startX, startY, startZ = 119, 101, 96

local endY = 104

while(startY <= endY) do

    local x = commands.getBlockInfo(startX, startY, startZ)

    startY = startY + 1

    if x.name == "minecraft:diamond_block" then
        ws.send("There was a diamond")
    end

end

ws.close()


