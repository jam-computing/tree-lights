# Json Examples

Here are some examples of the json strings of the following objects:

### Frame

`Sender` is the client sending the data.

`Pixels` is a list of RGB values parsed in string format.

```json
{
    "Sender": "",
    "Pixels": ["1, 2, 3", "2, 3, 4"]
}
```

### Animation

Because it is just stores a list of frames, it is common practice to store the `Sender` as a the length between the current frame and next.

```json
{
    "Sender": "",
    "Frames": [
        {
            "Sender": "",
            "Pixels": ["1, 2, 3", "2, 3, 4"]
        }
    ]

}
```

### Setup

```json
{
    "Name": "",
    "Sender": "",
    "index": 0,
    "LedCount": 500
}
```