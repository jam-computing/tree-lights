# <b> Tree Lights </b>
A container for code and ideas for tree lightshow

## Prototype Shopping List

+ Breadboard
+ Breadboard wires
+ Lights
+ Diode
+ PSU

## Shopping List

+ [Tree 5ft](https://www.amazon.co.uk/Artificial-Christmas-Realistic-Natural-Branches/dp/B0BDMZ4JWT/ref=sr_1_9?c=ts&keywords=Christmas%2BTrees&qid=1694347371&s=kitchen&sr=1-9&ts_id=3028703031&th=1), [Tree 4ft](https://www.amazon.co.uk/Ureprism-Artificial-Christmas-Decoration-assembly/dp/B0BG2KWLPZ/ref=sr_1_4?keywords=4ft%2Bchristmas%2Btree%2Bpre%2Bdecorated&qid=1694348804&sr=8-4&th=1), Mr Martin's <b> REAL </b> tree<br>
+ [Lights on Amazon](https://www.amazon.co.uk/BTF-LIGHTING-Transparent-Individually-Addressable-Waterproof/dp/B0B64ZY3W5/ref=sr_1_4?crid=2CRNP2FBN84HS&keywords=lights+individually+addressable&qid=1694348440&s=kitchen&sprefix=lights+individually+adressabl%2Ckitchen%2C83&sr=1-4), [Lights on Wish](https://www.wish.com/search/ws2812b%20leds/product/5b8d1471ba9a7328dcf75c68?source=search&position=71) <br>
+ [PSU](https://www.amazon.co.uk/Gonine-Adapter-100-240V-Converter-Speakers-Black/dp/B09WXSG546/ref=sr_1_3?crid=1O7PSQ0NQ1WFJ&keywords=psu+5v+15w&qid=1694359761&sprefix=psu+5v+15w%2Caps%2C74&sr=8-3) <br>
+ [Breadboard](https://www.amazon.co.uk/400-Point-Solderless-PCB-Breadboard/dp/B013EW663K/ref=mp_s_a_1_43?crid=2ESSX2HVB93TW&keywords=bread+boards+electronics+kit&qid=1694374436&sprefix=breadboard+electronics+kit%2Caps%2C130&sr=8-43) <br>
+ Wires and diode - tech dept / robotics

## Lighting

<img src="https://m.media-amazon.com/images/I/71kuC8MiyZL._AC_SX679_.jpg" width="200"/>

+ At least 300 lights
+ How many lights do we want IN the tree compared to the amount on outside of tree
+ Use less lights and do half the tree?
+ Imaging lights - need after school or multiple lunchtimes to get it right

## Python libraries

+ Opencv - To pinpoint the tree lights
+ Neopixel - To manipulate the tree lights

## Algorithm

+ Use image manipulation to pinpoint each light
+ Gaussian blurr followed by cv.minMaxLoc()
+ Rotate tree 90 degrees then repeat
+ Tree should have central axis in centre of image
+ This should be done in a dark room to ensure accuracy

## Electronics

+ [Video of how to wire the pi](https://www.youtube.com/watch?v=KJupt2LIjp4) 
+ Wiring the pi with a chip

<br>

<img src="https://www.sdiplight.com/wp-content/uploads/2020/04/Raspberry-PI-74AHCT125-WS2812-wiring-diagram.jpg" width="200">

<br>

+ Wiring the pi with a diode

<img src="https://www.sdiplight.com/wp-content/uploads/2020/04/Raspberry-PI-1N4001-WS2812-wiring-diagram.jpg" width="200">

<br>

+ 0.3W / LED
+ Wiring multiple strips

<img src="https://i.stack.imgur.com/S5S34.png" width="2000"/>

## Light Show

+ Probably need a high light density - Matt Parker had a 6-7 ft tree with **500** LEDs
+ Curved surface area of a cone = **πr²l**
+ Optimal light density - A lighting calc can be found [here](https://www.countryliving.com/uk/homes-interiors/interiors/a38498712/christmas-tree-lights-baubles-calculator/), but most websites recommend **100 lights per 2ft of tree**
+ A couple minutes of preset animations - show stopper - maybe use external non-tree lights?? - people talk about tree - more people see tree - ooga booga
+ Obnoxious Carol Of the Bells
+ Get someone from maths to come up with cool mathematical function to use on tree?
+ Use precomputed animations?

## Extras

+ API - C# compatible to allow GCSE and A Level IT people to work with the tree
+ GUI client where you can create animations or switch on off invididual lights
+ Scratch type tree programming to showcase at open day
