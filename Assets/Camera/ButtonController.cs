using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    public CameraController cameraController;
    public Button saveButton;

    private void Start()
    {
        saveButton.onClick.AddListener(SavePicture);
    }

    private void SavePicture()
    {
        // Get the current frame from the webcam texture
        Texture2D snapshot = new Texture2D(cameraController.webcamTexture.width, cameraController.webcamTexture.height);
        snapshot.SetPixels(cameraController.webcamTexture.GetPixels());
        snapshot.Apply();

        // Encode the snapshot as a PNG
        byte[] bytes = snapshot.EncodeToPNG();

        // Define the file path and name
        string filePath = Application.dataPath + "/SavedPictures/";
        string fileName = "snapshot.png";

        // Create the folder if it doesn't exist
        if (!System.IO.Directory.Exists(filePath))
            System.IO.Directory.CreateDirectory(filePath);

        // Save the picture to the specified path
        System.IO.File.WriteAllBytes(filePath + fileName, bytes);

        Debug.Log("Picture saved: " + filePath + fileName);
    }
}