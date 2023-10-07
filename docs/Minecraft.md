# Using Minecraft with the Tree 🎄

This is a guide on how to get your minecraft up and running with the Tree.

## Prerequisites

+ Minecraft Java Edition
+ [Forge](https://files.minecraftforge.net/net/minecraftforge/forge/) + [CC:Tweaked](https://www.curseforge.com/minecraft/mc-mods/cc-tweaked) Installed
+ [Node.js](https://nodejs.org/en) Installed
+ This repo cloned

If you have all those things, your ready to go!

## Acquiring the Image

+ Get your image that you want to use ( the picture of the tree )
+ Place it in the `data/images` folder
+ Update the config so that you reference the images' name

![image](https://github.com/Friends-Robotics/Tree-Lights/assets/62078259/aadd9ec7-cb36-44f5-a9f3-921b2391b7b7)


## Resizing the image

+ Take your image and go to: [this](https://imageresizer.com/) image rescaling website
 
![image](https://github.com/Friends-Robotics/Tree-Lights/assets/62078259/53b541a2-790d-436b-ba2f-6ed135296bd8)


+ Resize the image to your prefered resolution: ( Suggested 50x50 )
+ Download the image and take note of where it was placed

## Getting the Mural

+ Go to [this](https://mcstacker.net/murals/) website.
+ Add your newly resized file to it. Keep the scale to 1.

![image](https://github.com/Friends-Robotics/Tree-Lights/assets/62078259/2ca84e0e-d75a-4eb2-9a36-c8b5772108a3)

+ Set the placement to `On ground - top of image is WEST -x`

![image](https://github.com/Friends-Robotics/Tree-Lights/assets/62078259/493420cf-7364-4b84-9f27-4e642263c9b2)

+ When choosing the blocks, exclude: `Glass Blocks`, `Falling Blocks` and `Wool Blocks`

+ Finally, download the `datapack` file.

## Getting the image into Minecraft

+ Open Minecraft with the mod installed.
+ Create a new `Superflat` world.
+ Set cheats `on` and gamemode to `Creative`
+ Make sure its on `Superflat`!

+ Exit back to the Main Menu once the world has loaded.
+ Go back to the game and select `edit` on your singleplayer world.
+ Click on `Open World Folder` ( Important! )
+ Copy the `Mural.zip` file from your downloads to the `datapacks` folder in the world.
+ Go back into the game!

+ For more info on datapacks, go [here](https://letmegooglethat.com/?q=How+to+download+datapacks+in+minecraft)

## Commands

+ Stand **_One Block_** above the surface.
+ Type the following command into chat:
```
/function mm:mural
```
+ This command will spawn in your image
+ If it doesn't work, make sure that you have followed the steps correctly and that you are _at least one block above the surface_

+ If you've done it correctly: it should look like this!
  
![2023-10-07_21 03 05](https://github.com/Friends-Robotics/Tree-Lights/assets/62078259/8f774432-6e03-49c8-9481-50bb3b76c443)

+ Take down the **_Bottom Left_** and **_Top Right_** Coordinates ( X, Y and Z ) of the image.
+ This is what we got for our example:

```
1, -61, -42
-48 -61 -42
```

+ Next, get a `Computercraft Computer`. We need a special version, so use the following command

```
/give @p computercraft:computer_command
```

+ This will give you a command computer. Place it down on the ground.

+ Right click on the computer and you will be greeted with a [prompt](https://www.techtarget.com/whatis/definition/command-prompt)
+ Type the following command into the prompt: 

```
pastebin get CLbgFwBG script
```

+ This command 🗑️ will get some code and put it on your computercraft computer.

## Editing the script

+ To edit the script, type:

```
edit script
```

+ Look for the line that says `-- IMPORTANT --`: You should replace the sample coordinates with your own ones, that you took down earlier.
+ The bottom left cords will be the starting coords, and the top right will be the ending coords.

+ Also, if you are using a RPi to control your tree, you should change the IP aswell.

## Allowing local connections.

+ One problem we have is that the code will not run because CC:Tweaked does not allow local connections by default.
+ We need to fix this by going into the config files ( scary 👻 )
+ `Save and Quit to Title`
+ Go back to your `World Folder` that you were in earlier.
+ Go to `serverconfig/computercraft-server.toml`
+ Open it in your favourite text editor.
+ Find the line: `[[http.rules]]`
+ Delete the line below: `action = "deny"`.
+ Now we should be able to get started!

## Communicating with Node

+ To setup node, go to [this] repo in your file explorer.
+ Go to `src/tree/node-cctweaked`
+ Right click on the folder and click, `Open in Terminal`:

![image](https://github.com/Friends-Robotics/Tree-Lights/assets/62078259/1766ce7f-9508-4b9d-b023-a2bd558d1233)

+ In the terminal, type `node .`
+ It should say, `Started Websocket`!, Your websocket is now running
+ If not, check your node version with `node -v`, it should be `> 18`

## Colouring in the lights

+ Please see [this]() file for a list of what blocks are supported.
+ Replace any of the blocks in your image with some of the supported blocks
+ In our example, I wrote the word: `tree` on the image:

![2023-10-07_21 40 40](https://github.com/Friends-Robotics/Tree-Lights/assets/62078259/da867aff-9850-4ede-97fe-d32304d19afc)


## Almost done!

+ Make sure your TreeServer is online.
+ Make sure your Node server is online.

_N.B. The tree server should be online BEFORE the node server_

+ Go to the computer in your Minecraft world, and type the following command:

```
script
```

With any luck: your image should be showing on the tree!

## If you are using the GUI to view the image.

+ In the TreeGUI, click on `View Minecraft Image`

![image](https://github.com/Friends-Robotics/Tree-Lights/assets/62078259/03e851f3-9cd9-4750-9ec6-0f14e01ec217)

+ Then click on `LOAD`

Your Journey is complete! 🎆


_author: [juleswhi](https://github.com/juleswhi)_
