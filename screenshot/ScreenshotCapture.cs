namespace Stolenpad.Utils
{
    using UnityEngine;

    public class ScreenshotCapture : SingletonMB<ScreenshotCapture>
    {
        [SerializeField] string fileName = "File Name";
        public void Screenshot()
        {
            Debug.Log("Screen Shot Taken");
            ScreenCapture.CaptureScreenshot(fileName + ".png");
        }
    }
}
