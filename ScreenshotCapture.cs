using UnityEngine;
using System.IO;

public class ScreenshotCapture : MonoBehaviour
{
    public Transform targetObject;
    public int startAngleX = 0;
    public int endAngleX = 360;
    public int angleStepX = 30; // angle interval(x-axis)
    public int startAngleY = 0;
    public int endAngleY = 360;
    public int angleStepY = 30; // angle interval(y-axis)
    public string folderName = "Screenshot"; // Folder name to save
    public string fileNamePrefix = "Screenshot";

    // initial angle setting
    private int currentAngleX = 0;
    private int currentAngleY = 0;

    void Start()
    {
        // If the folder does not exist, create a new folder
        if (!Directory.Exists(targetObject.name))
        {
            Directory.CreateDirectory(targetObject.name);
        }

        string fileName = fileNamePrefix + "_X0" + currentAngleX.ToString() + "_Y0.png";
        string filePath = Path.Combine(targetObject.name, fileName);

        targetObject.rotation = Quaternion.Euler(0, 0, 0);

        ScreenCapture.CaptureScreenshot(filePath);
    }

    void Update()
    {
        // If the current angle (x, y-axis) is less than or equal to 360 degrees, capture
        if (currentAngleX < endAngleX && currentAngleY < endAngleY)
        {  
            string fileName = targetObject.name + "_X" + currentAngleX.ToString() + "_Y" + currentAngleY.ToString() + ".png";
            string filePath = Path.Combine(targetObject.name, fileName);

            // Change the angle of the target object
            targetObject.rotation = Quaternion.Euler(currentAngleX, currentAngleY, 0);

            // Image Capture
            ScreenCapture.CaptureScreenshot(filePath);

            // Increase the y-axis angle
            currentAngleY += angleStepY;

            // If the y-axis angle reaches 360 degrees, set y-axis to 0 and x-axis to +15, then repeat
            if (currentAngleY == endAngleY)
            {
                currentAngleY = startAngleY;
                currentAngleX += angleStepX;
            }
        }
    }
}
