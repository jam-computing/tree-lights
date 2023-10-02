# Tree Lights
A container for code and ideas for tree lightshow




# Shopping List

+ [Tree 5ft](https://www.amazon.co.uk/Artificial-Christmas-Realistic-Natural-Branches/dp/B0BDMZ4JWT/ref=sr_1_9?c=ts&keywords=Christmas%2BTrees&qid=1694347371&s=kitchen&sr=1-9&ts_id=3028703031&th=1), [Tree 4ft](https://www.amazon.co.uk/Ureprism-Artificial-Christmas-Decoration-assembly/dp/B0BG2KWLPZ/ref=sr_1_4?keywords=4ft%2Bchristmas%2Btree%2Bpre%2Bdecorated&qid=1694348804&sr=8-4&th=1) <br>
+ [Lights](https://www.amazon.co.uk/BTF-LIGHTING-Transparent-Individually-Addressable-Waterproof/dp/B0B64ZY3W5/ref=sr_1_4?crid=2CRNP2FBN84HS&keywords=lights+individually+addressable&qid=1694348440&s=kitchen&sprefix=lights+individually+adressabl%2Ckitchen%2C83&sr=1-4) <br>
+ [PSU](https://www.amazon.co.uk/Gonine-Adapter-100-240V-Converter-Speakers-Black/dp/B09WXSG546/ref=sr_1_3?crid=1O7PSQ0NQ1WFJ&keywords=psu+5v+15w&qid=1694359761&sprefix=psu+5v+15w%2Caps%2C74&sr=8-3) <br>
+ [Breadboard](https://www.amazon.co.uk/400-Point-Solderless-PCB-Breadboard/dp/B013EW663K/ref=mp_s_a_1_43?crid=2ESSX2HVB93TW&keywords=bread+boards+electronics+kit&qid=1694374436&sprefix=breadboard+electronics+kit%2Caps%2C130&sr=8-43) <br>
+ Wires and diode - tech dept / robotics

# ITL

The programming language for the scripting of the tree will be done in [ITL](https://github.com/juleswhi/itl).

ITL is a simple, interpreted programming language, with native implementation to access the Tree's ws

# Raspberry Pi

The plan for the RPi is as follows:
+ Python Websocket AND flask Webserver on the pi
+ The websocket will take in 300 - 500 coordinates, cooresponding colours, a name, and an optional terminator.
+ If the websocket takes in a request specified above, then it will wait until the terminator, and store the sequence in a file, called the name.
+ Then the webserver will display all the files in a directory, and display them, along with an option to play
+ the python server will also interact wiht the tree directly, allowing it to modify the colours of each individual light.

The RPi Py server should also have functionality for a direct, immediate connection, E.G for the GUI.
## GUI Client

The GUI Client will be built in Unity, and will involve a 3D model of a tree, ( built in Blender ). 

Where the user clicks on the tree, that will light up the corresponding light on the tree.

?( Allow user to create animations in the GUI )

# Lighting

+ How many lights do we want IN the tree compared to the amount on outside of tree
+ Use less lights and do half the tree?
+ Imaging lights - need after school or multiple lunchtimes to get it right

# Python libraries

+ Opencv
+ Pillow
+ Neopixel

# Algorithm

+ Use image manipulation to pinpoint each light - max of a moving weighted average - look at convolutions ( somone translate pls )
+ Rotate tree 90 degrees then repeat
+ Tree should have central axis in centre of image

# Light Show

+ Probably need a high light density - Matt Parker had a 6-7 ft tree with **500** LEDs
+ Curved surface area of a cone = **πr²l**
+ Optimal light density - A lighting calc can be found [here](https://www.countryliving.com/uk/homes-interiors/interiors/a38498712/christmas-tree-lights-baubles-calculator/), but most websites recommend **100 lights per 2ft of tree**
+ A couple minutes of preset animations - show stopper - maybe use external non-tree lights?? -> people talk about tree -> more people see tree -> ooga booga
+ Obnoxious Carol Of the Bells
+ Get someone from maths to come up with coool mathematical function to use on tree?
+ Use precomputed animations?

# Extras

+ **_API!!!!_**
+ GUI client where you can create animations or switch on off invididual lights
