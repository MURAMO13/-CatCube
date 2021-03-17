using UnityEngine;
using AppodealAds.Unity.Api;


public class AppodealAdss : MonoBehaviour
{



    private const string AppKey = "502bab622300f049ef93071ca3b8181c396634941dc5a80e";

        private void Start()
        {
              
            Initialize();
           // Appodeal.show(Appodeal.BANNER_TOP);
             Appodeal.show(Appodeal.BANNER_BOTTOM);


        }

        private void Initialize() 
        {   
            Appodeal.muteVideosIfCallsMuted(true);
            Appodeal.disableLocationPermissionCheck();
            Appodeal.setSmartBanners(false);
           
        Appodeal.initialize(AppKey,Appodeal.BANNER,true);

        }


















    /* StartCoroutine(ShowBannerWhenInitialized());
    IEnumerator ShowBannerWhenInitialized()
        {
            while (true)
            {
                if (Appodeal.isLoaded(Appodeal.BANNER))
                {
                    Appodeal.show(Appodeal.BANNER_TOP);


                }
                yield return new WaitForSeconds(1f);
            }

        }*/





}
