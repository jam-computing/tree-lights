-- setup server stuff
local serverUrl = "ws://127.0.0.1:2000"
local ws = nil
local err = nil

-- IMPORTANT - should replace these coordinates
local startX, startY, startZ = -207, -60, 155
local endX, endY, endZ = -256, -60, 106

-- get all blocks in the specified area
local x = commands.getBlockInfos(startX, startY, startZ, endX, endY, endZ);



-- This will retreive the actual x and y? and z of the block in minecraft
-- Still need to do some heavy lifting to translate that to a tree cord
local a = {}

local counter = 1
for y = startX, endX, -1 do 
    for z = startZ, endZ, -1 do 
        a[counter] = { ( y * -1 ) + startX, z - startZ }
        counter = counter + 1
    end
end

local foundBlocks = {}
local numOfBlocks = 1

-- check for diamond blocks - should expand this to more blocks
for i = 1,#x do
   if x[i].name == "minecraft:diamond_block" then
        foundBlocks[numOfBlocks] = { "minecraft:diamond_block", a[i][1], a[i][2] }
        print("found diamond! at location: ")
        print("It's location is: (", a[i][1], a[i][2], ")")
        numOfBlocks = numOfBlocks + 1
   end
end

-- Connect to the server
local ws, err = http.websocket(serverUrl)

if err then 
    print("ERROR", err)
end

local numNum = 1

function TableToString(tbl, indent)
    if not indent then indent = "" end
    local str = "\n"
    local comma = false

    for key, value in pairs(tbl) do
        if comma then
            str = str .. ",\n"
        end

        if type(value) == "table" then
            str = str .. TableToString(value, indent .. "  ")
        elseif type(value) == "number" or type(value) == "boolean" then
            
            if numNum == 1 then
                str = str .. indent .. "ValueOne: " .. tostring(value)
                numNum = 2
            else 
                str = str .. indent .. "ValueTwo: " .. tostring(value)
                numNum = 1
            end
        elseif type(value) == "string" then
            str = str .. indent .. "Name: " ..  '"' .. value .. '"'
        else
            error("Invalid table value type: " .. type(value))
        end

        comma = true
    end

    str =  str .. "\n" .. indent 

    return str
end

local string = ""

for i = 1, #foundBlocks do 
    if i == #foundBlocks then
        string = string ..  "{" .. TableToString(foundBlocks[i], "  ") .. "}" 
    else 
        string = string ..  "{" .. TableToString(foundBlocks[i], "  ") .. "}," 
    end
end

ws.send("[" .. string .. "]") 
print("Send data to tree")

ws.close()


print("finished")