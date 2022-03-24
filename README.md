# Unity Mobile Sensors Demo

Download or clone this Unity project "Mobile Sensor Demo" and take a look at the two application examples "Whip" and "Balls". The scenes can be found in their respective folders along with relevant scripts (.cs files). Try to add the required code in the scripts to get sensor input and use that for the desired output.

## Balls example
The goal of the Balls example is to make a set of balls/spheres roll around on a plane by tilting the phone (see recording below). Everything you need is in the scene – you just need to get mobile sensor input and use it to tilt the plane. The script you need to add your code to is called "Attitude.cs".

https://user-images.githubusercontent.com/43847716/159903108-334d1a2a-2979-4b08-b2d4-eed63d14c65d.mp4

##### Steps:
* This application uses gyroscope so in the code you should check that your device supports gyroscope.
* Most sensors are disabled by default, so enable the gyroscope in the start function.
* Use the attitude of the gyroscope to control rotation of the plane (be aware that some axes may need to be swapped).


## Whip example
The goal for the Whip example is to make a simple application that triggers a sound effect when flicking the phone. Everything you need is in the scene – you just need to get mobile sensor input and use it to play a sound. The script you need to add your code to is called "Whip.cs".

##### Steps:
* This application uses acceleration. Check that the device supports this sensor and that it is enabled.
* Play the sound clip when the acceleration is above some threshold that you define.

---

You can test the application on your phone either by using the [Unity Remote 5](https://play.google.com/store/apps/details?id=com.unity3d.mobileremote&hl=en&gl=US) app (check [this guide](https://github.com/malteerasmussen/unity-mobile-sensors-demo/blob/main/Mobile%20Sensor%20Demo/Assets/Connect%20Android%20phone%20guide.txt) if you have issues connecting your phone) or by making an Android build to your phone.
