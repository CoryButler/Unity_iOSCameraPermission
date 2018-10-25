# Unity_iOSCameraPermission
Requestes iOS camera permission with a callback method in Unity.

# USAGE
The iOSCameraPermission static class will only function in iOS.

Still the class will NOT crash the app on other platforms.  It will just do nothing.

The string callbackName argument must match the name of the callback method you want to use.

The callback method must require a single string argument.

The string received will either be "true" or "false".

NOTE: You must set a Camera Usage Description in the Player Settings.

# Plugin directory structure
All .h and .m files must be in the follow location:

[ProjectName] > Assets > Plugins > iOS

# Usage Sample
See Assets > Scenes > SampleScene.unity

SampleScene implements the SampleUsage class.

Camera Usage Description is set to "Sample Camera Usage Description"
