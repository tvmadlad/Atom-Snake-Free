using UnityEngine;
using System.Collections;
using GoogleMobileAds.Api;

public class Global : MonoBehaviour {

	public AudioSource BackgroundMusic;
    public Snake snake;

    private BannerView bannerView;




    public float RunTime;

	// Use this for initialization
	void Start () {
		RunTime = 1;
        RequestBanner();
       


    }

	
	// Update is called once per frame
	void Update () {
	
	}
    public void MainMenuLink() {
        Debug.Log(bannerView);
        if (bannerView != null)
            bannerView.Destroy();
        snake.isLoading = true;
        snake.LoadingScreen.SetActive(true);
        Application.LoadLevel(0);
        
    }
	public void RestartGame (){
		Application.LoadLevel (1);
	}
	public void RestartLevel2 (){
		Application.LoadLevel (2);
	}
	public void RestartLevel3 (){
		Application.LoadLevel (3);
	}
    private void RequestBanner()
    {

#if UNITY_ANDROID
        string adUnitId = "ca-app-pub-9376068839028526/3428266296";
#elif UNITY_IPHONE
		string adUnitId = "ca-app-pub-9376068839028526/3428266296";
#else
		string adUnitId = "unexpected_platform";
#endif

        // Create a 320x50 banner at the top of the screen.
        bannerView = new BannerView(adUnitId, AdSize.Banner, AdPosition.Top);
        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();
        // Load the banner with the request.
        bannerView.LoadAd(request);
    }
}
	