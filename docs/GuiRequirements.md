# Design Requirements

Requirements for the design of the tree related software, its interface with itself and interaction with the user

## Animations 
- <b>Below is just a suggestion, we could just use json</b>
- Have the .gift extension <i>(but are actually just text files)</i>
- Have a name header:

```mathematica Selected a random language cus why not get syntax highlighting
<Name="name"/>
```

- Have a LED count header:

```mathematica
<LEDs="50"/>
```

- (Optional) Have a frame rate header in fps:

```mathematica
<FrameRate="1"/> // This means one fps
```

- Each frame is composed of a list of tuples and takes up one line of the .gift file, the length of this tuple list should be constant and equal to the number of LEDs:

```mathematica
[0,0,0], [0,0,0], [0,0,0], ...
```

- The overall animation should be composed of multiple lines of frames:

```mathematica
[0,0,0], [0,0,0], [0,0,0], ...\n
[0,0,0], [0,0,0], [0,0,0], ...\n
[0,0,0], [0,0,0], [0,0,0], ...
```

- The end of the string/file signals the end of the animation

## Server/Socket

- Connections
    - Accept only one device connected at one time to prevent conflicts (This could be changed later but it should be enforced while setup mode is active)
- Modes
    - Animation
        - Default mode
        - This mode should be active unless the tree is being setup
    - Setup
        - Allows the setup of the tree by turning on a specified pixel to maximum brightness (255, 255, 255) when requested by the GUI
- Animations
    - Should be easily uploaded from the GUI
    - Should be stored locally on the pi at a directory that is selected in the config (perhaps a usb if more storage is required and this would also allow animations to be imported in bulk)
    - Each animation should be stored in its own, named file
    - Should be able to trigger animations locally for testing
    - Animations should be async to allow them to be paused, stopped and then changed mid-execution
    - When requested should return a list of animations that are stored on the pi
- Tree Coordinates
    - Should recieve the normalised tree coordinates after a scan and return them on request
    - Should be stored in a text file


## Tree GUI

- Design
    - Designed in WPF 
    - Green and dark grey colour scheme with logos that are already on github in winforms
    - Music player style with a side menu
    - Have the ability to pause and stop animations
    - Avoid using a config for the GUI - more polished - but data should be stored in a file, just not explicitly exposed to the user
- Tree connections
    - Tab at the side
    - Default to debugging mode (no automatic connections to avoid unnecessary wait times unless the user has requested it)
    - User should be notified if the tree unexpectedly disconnects, and prompted, but not required to reconnect
- Scanner
    - Tab at the side
    - Should communicate with the socket to control individual LEDs
    - Returns a normalised list of tree coordinates for each led which is stored both locally and broadcast to the pi to be stored there
- Virtual tree
    - Tab at the side
    - When started should create each virtual light at the 
    - Should display the animation at the same time as the real tree
    - Should 
- Animations
    - Should be stored locally on the pi
    - Should be able to send animations to the socket
    - Get animations that are stored on the pi and trigger those

## Api

- Add .gift parsing (if we are using it)