import cv2
import io


cam = cv2.VideoCapture(0)


def capture_led(kernel_size, blur_iterations):
    _, image = cam.read()

    greyscale_image = cv2.cvtColor(image, cv2.COLOR_BGR2GRAY)

    blurred_image = greyscale_image
    for i in range(blur_iterations):
        blurred_image = cv2.blur(greyscale_image, kernel_size)

    min_val, max_val, min_loc, max_loc = cv2.minMaxLoc(blurred_image)

    # Debug Info
    # cv2.imshow('Original', image)
    # cv2.waitKey(1000)
    # cv2.imshow('Greyed', greyscale_image)
    # cv2.waitKey(1000)
    # cv2.imshow('Blurred', blurred_image)
    # cv2.waitKey(1000)
    # image = cv2.circle(image, max_loc, 20, (0, 225, 0), -1)
    # cv2.imshow('Brightest Area', image)
    # cv2.waitKey(5000)

    return image.shape[:2], max_loc


def toggle_only_index_led(index):
    pass  # This should turn off all LEDs then switch on the one at the index


def main():
    number_of_leds = 10
    led_locations = []
    for i in range(number_of_leds):
        toggle_only_index_led(i)
        led_locations.append(capture_led((20, 20), 1))

    # Write to the file before exiting
    file = io.open('led_locations', 'w')
    led_locations = [str(location) for location in led_locations]
    file.write('\n'.join(led_locations))


if __name__ == '__main__':
    main()
