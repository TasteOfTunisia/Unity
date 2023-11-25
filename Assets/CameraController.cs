using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public WebCamTexture webcamTexture;
    //private Texture2D capturedImage;
    private new Renderer renderer;
    //private FirebaseStorage storage;

    // private const string BucketUrl = "gs://tasteoftunisia-cd2cb.appspot.com";
    // private const string StoragePath = "images/";

    private void Start()
    {
        renderer = GetComponent<Renderer>();
        // storage = FirebaseStorage.DefaultInstance;

        if (WebCamTexture.devices.Length == 0)
        {
            Debug.Log("No camera detected on the device.");
            return;
        }

        webcamTexture = new WebCamTexture();
        renderer.material.mainTexture = webcamTexture;
        webcamTexture.Play();
    }

    /* public void CaptureImage()
     {
         // Capture the current frame from the camera
         capturedImage = new Texture2D(webcamTexture.width, webcamTexture.height);
         capturedImage.SetPixels(webcamTexture.GetPixels());
         capturedImage.Apply();

         // Generate a unique filename for the image
         string filename = System.Guid.NewGuid().ToString() + ".png";
         string storagePath = StoragePath + filename;

         // Upload the image to Firebase Storage
         StorageReference storageRef = storage.GetReferenceFromUrl(BucketUrl);
         StorageReference imageRef = storageRef.Child(storagePath);
         byte[] imageData = capturedImage.EncodeToPNG();

         imageRef.PutBytesAsync(imageData)
             .ContinueWith((task) =>
             {
                 if (task.IsFaulted || task.IsCanceled)
                 {
                     Debug.Log("Failed to upload image to Firebase Storage.");
                 }
                 else if (task.IsCompleted)
                 {
                     Debug.Log("Image uploaded to Firebase Storage: " + storagePath);
                 }
             });
     }*/


}
