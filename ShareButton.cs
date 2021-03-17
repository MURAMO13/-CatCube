using System.Collections;
using UnityEngine;
using System.IO;

public class ShareButton : MonoBehaviour
{

	
    public void ClickShare() 
    {
		
		StartCoroutine(TakeScreenshotAndShare());
    }
	private IEnumerator TakeScreenshotAndShare()
	{
		yield return new WaitForEndOfFrame();

		Texture2D ss = new Texture2D(Screen.width, Screen.height, TextureFormat.RGB24, false);
		ss.ReadPixels(new Rect(0, 0, Screen.width, Screen.height), 0, 0);
		ss.Apply();

		string filePath = Path.Combine(Application.temporaryCachePath, "shared img.png");
		File.WriteAllBytes(filePath, ss.EncodeToPNG());

		// To avoid memory leaks
		Destroy(ss);

		new NativeShare().AddFile(filePath)
			.SetSubject("Hi,U").SetText("Hi U,it's my points ↑↑ ʕ ᵔᴥᵔ ʔ ↑↑ {0} \n https://play.google.com/store/apps/details?id=com.OneGarrisonMo.CatCube  ", PlayerPrefs.GetInt("score"))
			.SetCallback((result, shareTarget) => Debug.Log("Share result: " + result + ", selected app: " + shareTarget))
			.Share();

		// Share on WhatsApp only, if installed (Android only)
		//if( NativeShare.TargetExists( "com.whatsapp" ) )
		//	new NativeShare().AddFile( filePath ).AddTarget( "com.whatsapp" ).Share();
	}
}
