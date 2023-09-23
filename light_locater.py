import cv2


def main():
    cam = cv2.VideoCapture(0)

    _, image = cam.read()

    cv2.imshow('Original', image)
    cv2.waitKey(1000)

    greyscale_image = cv2.cvtColor(image, cv2.COLOR_BGR2GRAY)
    cv2.imshow('Greyed', greyscale_image)
    cv2.waitKey(1000)

    blurs = 20
    for i in range(blurs):
        blurred_image = cv2.GaussianBlur(greyscale_image, (9, 9), cv2.BORDER_DEFAULT)
    cv2.imshow('Blurred', blurred_image)
    cv2.waitKey(1000)

    min_val, max_val, min_loc, max_loc = cv2.minMaxLoc(blurred_image)

    image = cv2.circle(image, max_loc, 20, (0, 225, 0), -1)
    cv2.imshow('Brightest Area', image)
    cv2.waitKey(5000)


if __name__ == '__main__':
    main()
