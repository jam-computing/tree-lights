# <b> Tree Lights </b> 🎄
A container for code and ideas for tree lightshow

+ [Power Adapter](https://www.amazon.co.uk/dp/B07RHM5KCW/ref=sspa_dk_detail_3?pd_rd_i=B07RHM5KCW&pd_rd_w=4sFHv&content-id=amzn1.sym.67430c1d-696a-45e1-be6b-972213775cc6&pf_rd_p=67430c1d-696a-45e1-be6b-972213775cc6&pf_rd_r=EJCAPMQP2K8M846SX8FJ&pd_rd_wg=Mq5ME&pd_rd_r=cf8fdd5f-cd97-4af6-a0bd-76511c525399&s=electronics&sp_csd=d2lkZ2V0TmFtZT1zcF9kZXRhaWwy&th=1) - ✔️
+ [Power Supply](https://www.amazon.co.uk/Multibao-3000mA-Adapter-Charger-Replacement-Black/dp/B0BGGV97KT/ref=sr_1_5?crid=Q3UE5ME2786B&keywords=5V+3A+power+adapter&qid=1695894357&sprefix=5v+3a+power+adapter%2Caps%2C136&sr=8-5) - ✔️
+ [Lights](https://www.wish.com/search/ws2812b%20leds/product/5b8d1471ba9a7328dcf75c68?source=search&position=71) - ✔️
+ Male to male breadboard wires ✔️
+ Mr Martin's <b> REAL </b> tree / sad fake one ✔️ ( kinda )
+ Level shifter from and breadboard from Mr Martin's stash ✔️

# Leafscript 🌲

Leafscript is a interpreted language with native support for tree-lights.
It is easy to learn and understand.

Get started [here](https://github.com/juleswhi/leafscript)

# Raspberry Pi 🥧

+ The RPi runs a C# Websocket server, which clients can connect to and send animations to ( and individual frames! )
+ The server will then take those animations and map them to the tree

## Lighting 🌩️

<img src="https://m.media-amazon.com/images/I/71kuC8MiyZL._AC_SX679_.jpg" width="200"/>

+ Probably need a high light density - Matt Parker had a 6-7 ft tree with **500** LEDs
+ Curved surface area of a cone = **πr²l**
+ Optimal light density - A lighting calc can be found [here](https://www.countryliving.com/uk/homes-interiors/interiors/a38498712/christmas-tree-lights-baubles-calculator/), but most websites recommend **100 lights per 2ft of tree**
+ At least 300 lights, preferably 500
+ How many lights do we want IN the tree compared to the amount on outside of tree
+ Use less lights and do half the tree
+ Imaging lights - need after school or multiple lunchtimes to get it right

## C# libraries 📘

+ Emgu - This library is used pinpoint the tree lights
+ Adafriut - Neopixel - To manipulate the tree lights

## Electronics 🔌

+ [Video of how to wire the pi](https://www.youtube.com/watch?v=KJupt2LIjp4) 
+ The video uses the following method. Wiring with only a female adapter and jumper wires

<img src="https://www.sdiplight.com/wp-content/uploads/2020/04/Raspberry-PI-WS2812b-External-Power-supply-wiring-diagram.jpg" width="200">

<br>

+ Wiring the pi with a chip

<img src="https://www.sdiplight.com/wp-content/uploads/2020/04/Raspberry-PI-74AHCT125-WS2812-wiring-diagram.jpg" width="200">

<br>

+ Wiring the pi with a diode

<img src="https://www.sdiplight.com/wp-content/uploads/2020/04/Raspberry-PI-1N4001-WS2812-wiring-diagram.jpg" width="200">

<br>

+ 0.3W / LED
+ Wiring multiple strips

<img src="https://i.stack.imgur.com/S5S34.png" width="2000"/>

</br>

+ Indian guys who sound like they know what they are doing can be found [here](https://www.youtube.com/watch?v=1OB2-H-jiJM), and [here](https://www.youtube.com/watch?v=nnapNHn-Ge0)
+ A high ampage power supply will be required for daisy chaining the LEDs or each set of 50 can be provided with its own power supply

## Light Show 🔦

+ A couple minutes of preset animations - show stopper - maybe use external non-tree lights - people talk about tree - more people see tree - ooga booga bish bash bosh Tree 2 electric boogaloo I am become Tree pine needeler of school
+ Obnoxious Carol Of the Bells
+ Get someone from maths to come up with cool mathematical function to use on tree
+ Use precomputed animations

## C# API

+ An API which allows users to programatically display effects to the tree.
+ Technical documentation about the API can be found [here](https://github.com/Friends-Robotics/Tree-Lights/blob/main/docs/API.md)

## Minecraft 🧱

+ Minecraft implemented with the Tree Lights!
+ You can "draw" an image with some blocks in minecraft and get it to show up on the tree!
+ A full guide to getting it setup can be found [here](https://github.com/Friends-Robotics/Tree-Lights/blob/main/docs/Minecraft.md)

## Fun Features 

+ Code competition for who can make the best code using the API?
+ GUI client where you can create animations or switch on off invididual lights

