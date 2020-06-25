# team-1
Team 1 (AR) course project repo / CART 370 / Winter 2020
> Ali Egseem, Valerie Bourdon, and Véronique Pesant


# Truth & Condition
*Truth and Condition* is an augmented reality exhibition exploring the unspoken; how words rarely communicate what they truly mean. It consists of a series of typographic prints that, upon further expansion in AR, reveal hidden meanings and truths. It explores the notion of honest communication uninhibited by conditioning; saying what you can’t say but wish you could.


## Posters
Using the Truth & Condition app, point your phone towards the following posters. Make sure only one poster is displayed on your screen.


<a href="https://github.com/CART370-W20/team-1/blob/master/Truth%20%26%20Condition/Assets/Images/Poster01.png"><img src="https://github.com/CART370-W20/team-1/blob/master/Truth%20%26%20Condition/Assets/Images/Poster01.png" title="Poster01" alt="Poster01" width="600px"></a>
<a href="https://github.com/CART370-W20/team-1/blob/master/Truth%20%26%20Condition/Assets/Images/Poster02.png"><img src="https://github.com/CART370-W20/team-1/blob/master/Truth%20%26%20Condition/Assets/Images/Poster02.png" title="Poster02" alt="Poster02" width="600px"></a>


## Getting Started
### Prerequisites
- Unity 2019.3.1f1 with Android and iOS support.
- Device compatible with <a href="https://developers.google.com/ar/discover/supported-devices" target="_blank">ARCore (Android)</a> or <a href="https://developer.apple.com/library/archive/documentation/DeviceInformation/Reference/iOSDeviceCompatibility/DeviceCompatibilityMatrix/DeviceCompatibilityMatrix.html" target="_blank">ARKit (Apple)</a>
- Unity configured to universal render pipeline <a href="https://www.youtube.com/watch?v=m6YqTrwjpP0e" target="_blank">How to configure Universal render pipeline in Unity</a>
- Unity configured to AR Foundation <a href="https://www.youtube.com/watch?v=Ml2UakwRxjk" target="_blank">How to configure ArFoundation in Unity (Arkit, ARCore)</a>


### External Libraries
- Download ARkit for Google on Playstore
- <a href="https://developers.google.com/ar/develop/unity/quickstart-android" target="_blank"> ARFoundation </a>
- <a href="https://developers.google.com/ar/develop/unity/quickstart-android" target="_blank"> ARCore </a>
- <a href="https://developer.apple.com/augmented-reality/" target="_blank"> ARKit </a>


### Installing
On your phone:
<a href="https://www.youtube.com/watch?v=bp2PiFC9sSs&t=99s" target="_blank">Tutorial to get started with AR on your phone</a>

On your phone:
- Go to settings and turn on developper tools
- Allow USB debugging
- Plug phone into computer via USB
In Unity
- Open Unity scene: ImageTracking
- File > Build Settings
- Change platform to Android
- Click switch device
- Run device: select phone model
- Build and run


### Running the tests
#### How to use
- Open the Truth & Condition app on your phone.
- Point your phone towards the first poster until the AR scene is projected on top.
- Rotate and move your phone around the poster to view hidden messages.
- Point your phone away from the poster and toward the second poster to view the second experience.
- Note: posters must be physically far apart from each other to work properly. 
- If the poster is not being tracked properly, simply restart the app and point your phone towards the poster again.


###### Scripts
- TrackedImageInfoManager: tracks models to flat planes. <a href="https://www.youtube.com/watch?v=iM0ghkvsRos&t=275s">Code reference</a>.
- Levitate: creates the levitating effect in the first poster. <a href="https://github.com/Kodrin/Unity-AR-Base-Template">Code reference</a>.


###### Shaders
- InsideHead: creates the scrolling text texture on inside of head on Poster 02
- OutsideScroll: creates the scrolling text on the objects on Poster 01
- PostProcessing: creates post-processing effects such as bloom on both posters
- RingScroll: creates the scrolling text on the ring around the head on Poster 02
- Scrolling texture: creates the scrolling text on the static rectangles on Poster 01


### Built using
- Unity + Universal Render Pipeline
- AR Foundation
- Blender
- Illustrator
- Photoshop


### License
All rights reserved.


### Acknowledgments
- <a href="https://github.com/Unity-Technologies/arfoundation-samples">AR Foundation Samples</a>
- <a href="https://www.youtube.com/watch?v=iM0ghkvsRos&t=275s">Dilmer Valecillos AR Samples</a>
- <a href="https://github.com/Kodrin/Unity-AR-Base-Template">Codrin Tablan Negrei AR Samples</a>
