// Attach this script to the gameobject that will be clicked to call VerifyPermission().
// Ex. Attach to a UI.Button, and set OnClick to VerifyPermission();

using UnityEngine;
using UnityEngine.UI;

public class UsageSample : MonoBehaviour
{
    // Link UI elements in the Inspector.
    [SerializeField] private Button _button;
    [SerializeField] private Text _text;

    public void VerifyPermission()
    {
        Debug.Log("VerifyPermission()");

        // Display some sort of thinking message to the user.
        if (_text != null) _text.text = "Verifying camera permission...";
        else Debug.Log("Link UI Text in the Inspector.");

        // Disable the button while verifying permission.
        if (_button != null) _button.interactable = false;
        else Debug.Log("Link UI Button in the Inspector.");

        // Use native UI to request camera permission.
        iOSCameraPermission.VerifyPermission(gameObject.name, "SampleCallback");
    }

    private void SampleCallback(string permissionWasGranted)
    {
        Debug.Log("Callback.permissionWasGranted = " + permissionWasGranted);
        
        if (permissionWasGranted == "true")
        {
            // You can now use the device camera.
            if (_text != null) _text.text = "You can now use the camera";
        }
        else
        {
            // You cannot use the device camera.  You may want to display a message to the user
            // about changing the camera permission in the Settings app.
            if (_text != null) _text.text = "Please active camera access in Settings.";

            // You may want to re-enable the button to display the Settings message again.
            if (_button != null) _button.interactable = true;
        }
    }
}

// MIT License
// 
// Copyright (c) 2018 Cory Butler
// www.CoryButler.com
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.
