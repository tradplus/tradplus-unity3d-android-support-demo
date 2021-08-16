﻿using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices;

#if UNITY_IOS
[SuppressMessage("ReSharper", "AccessToStaticMemberViaDerivedType")]
public class TradPlusBinding
{
    public TradPlus.Reward SelectedReward;

    private readonly string _adUnitId;
    public TradPlusBinding(string adUnitId)
    {
        _adUnitId = adUnitId;
        SelectedReward = new TradPlus.Reward { Label = string.Empty };
    }

    //splash
    public void LoadSplash()
    {
        _tradplusLoadSplash(_adUnitId);
    }

    //Banner
    public void CreateBanner(TradPlus.AdPosition position)
    {
        _tradplusCreateBanner((int) position, _adUnitId);
    }

    public void DestroyBanner()
    {
        _tradplusDestroyBanner(_adUnitId);
    }

    public void ShowBanner(bool shouldShow)
    {
        _tradplusShowBanner(_adUnitId, shouldShow);
    }

    public void ShowNative(int x, int y, int width, int height)
    {
        _tradplusShowNative(_adUnitId, x, y, width, height);
    }

    //显示广告 or 隐藏广告
    public void HideNative(bool needDestroy)
    {
        _tradplusHideNative(_adUnitId, needDestroy);
    }

    //Interstital
    public void InterstitialEntryAdScenario()
    {
        _tradplusInterstitialEntryAdScenario(_adUnitId);
    }

    public void InterstitialEntryAdScenario(string adSceneId)
    {
        _tradplusInterstitialEntryAdScenario2(_adUnitId, adSceneId);
    }

    public void RequestInterstitialAd(bool autoReload, bool isPangleTemplateRender)
    {
        _tradplusRequestInterstitialAd(_adUnitId, autoReload, isPangleTemplateRender);
    }

    public bool IsInterstitialReady {
        get { return _tradplusIsInterstitialReady(_adUnitId); }
    }

    public void ShowInterstitialAd()
    {
        _tradplusShowInterstitialAd(_adUnitId);
    }

    public void ShowInterstitialAd(string adSceneId)
    {
        _tradplusShowInterstitialAd2(_adUnitId, adSceneId);
    }

    public void ShowInterstitialConfirmUWSAd()
    {
        _tradplusShowInterstitialConfirmUWSAd(_adUnitId);
    }

    public void DestroyInterstitialAd()
    {
        _tradplusDestroyInterstitialAd(_adUnitId);
    }

    //RewardedVideo
    public void RewardedVideoEntryAdScenario()
    {
        _tradplusRewardedVideoEntryAdScenario(_adUnitId);
    }

    public void RewardedVideoEntryAdScenario(string adSceneId)
    {
        _tradplusRewardedVideoEntryAdScenario2(_adUnitId, adSceneId);
    }

    public void RequestRewardedVideo(bool autoReload, bool isPangleTemplateRender)
    {
        _tradplusRequestRewardedVideo(_adUnitId, autoReload, isPangleTemplateRender);
    }

    // Queries if a rewarded video ad has been loaded for the given ad unit id.
    public bool HasRewardedVideo()
    {
		return _tradplusHasRewardedVideo(_adUnitId);
    }

    // If a rewarded video ad is loaded this will take over the screen and show the ad
    public void ShowRewardedVideo()
    {
        _tradplusShowRewardedVideo(_adUnitId);
    }

    public void ShowRewardedVideo(string adSceneId)
    {
        _tradplusShowRewardedVideo2(_adUnitId, adSceneId);
    }

    public void ShowRewardedVideoConfirmUWSAd()
    {
        _tradplusShowRewardedVideoConfirmUWSAd(_adUnitId);
    }

    public void DestroyRewardedVideo()
    {
        _tradplusDestroyRewardedVideo(_adUnitId);
    }

    //OfferWall
    public void RequestOfferWall()
    {
        _tradplusRequestOfferWall(_adUnitId);
    }
  // Queries if a OfferWall ad has been loaded for the given ad unit id.
    public bool HasOfferWall()
    {
        return _tradplusHasOfferWall(_adUnitId);
    }

    // If a OfferWall ad is loaded this will take over the screen and show the ad
    public void ShowOfferWall()
    {
        _tradplusShowOfferWall(_adUnitId);
    }

    public void ShowOfferWallConfirmUWSAd()
    {
        _tradplusShowOfferWallConfirmUWSAd(_adUnitId);
    }

    public void DestroyOfferWall()
    {
        _tradplusDestroyOfferWall(_adUnitId);
    }

#region DllImports
#if ENABLE_IL2CPP && UNITY_ANDROID
    // IL2CPP on Android scrubs DllImports, so we need to provide stubs to unblock compilation
    private static void _tradplusCreateBanner(int position, string adUnitId) {}
    private static void _tradplusDestroyBanner(string adUnitId) {}
    private static void _tradplusShowBanner(string adUnitId, bool shouldShow) {}
    private static void _tradplusShowBannerConfirmUWSAd(string adUnitId){}
    private static void _tradplusShowBannerEntryAdScenario(string adUnitId){}

    private static void _tradplusRequestInterstitialAd(string adUnitId, bool autoReload, bool isPangleTemplateRender) {}
    private static bool _tradplusIsInterstitialReady(string adUnitId) { return false; }
    private static void _tradplusShowInterstitialAd(string adUnitId) {}
    private static void _tradplusShowInterstitialAd2(string adUnitId,string adSceneId) {}
    private static void _tradplusDestroyInterstitialAd(string adUnitId) {}
    private static void _tradplusShowInterstitialConfirmUWSAd(string adUnitId) {}
    private static void _tradplusInterstitialEntryAdScenario(string adUnitId) {}
    private static void _tradplusInterstitialEntryAdScenario2(string adUnitId,string adSceneId) {}

    private static void _tradplusRequestRewardedVideo(string adUnitId, bool autoReload, bool isPangleTemplateRender) {}
    private static bool _tradplusHasRewardedVideo(string adUnitId) { return false; }
    private static string _tradplusGetAvailableRewards(string adUnitId) { return null; }
    private static void _tradplusShowRewardedVideo(string adUnitId) {}
    private static void _tradplusShowRewardedVideo2(string adUnitId,string adSceneId) {}
    private static void _tradplusDestroyRewardedVideo(string adUnitId) {}
    private static void _tradplusShowRewardedVideoConfirmUWSAd(string adUnitId) {}
    private static void _tradplusRewardedVideoEntryAdScenario(string adUnitId) {}
    private static void _tradplusRewardedVideoEntryAdScenario2(string adUnitId,string adSceneId) {}

    private static void _tradplusRequestOfferWall(string adUnitId) {}
    private static bool _tradplusHasOfferWall(string adUnitId) { return false; }
    private static void _tradplusShowOfferWall(string adUnitId) {}
    private static void _tradplusShowOfferWall(string adUnitId,string adSceneId) {}
    private static void _tradplusDestroyOfferWall(string adUnitId) {}
    private static void _tradplusShowOfferWallConfirmUWSAd(string adUnitId) {}
    private static void _tradplusShowOfferWallEntryAdScenario(string adUnitId) {}
    private static void _tradplusShowOfferWallEntryAdScenario(string adUnitId,string adSceneId) {}
    private static void _tradplusShowNative(string adUnitId, int x, int y, int width, int height) {}
    private static void _tradplusHideNative(string adUnitId, bool needDestroy) {}
    private static void _tradplusLoadSplash(string adUnitId) {}
#else
    [DllImport("__Internal")]
    private static extern void _tradplusLoadSplash(string adUnitId);

    [DllImport("__Internal")]
    private static extern void _tradplusCreateBanner(int position, string adUnitId);

    [DllImport("__Internal")]
    private static extern void _tradplusDestroyBanner(string adUnitId);

    [DllImport("__Internal")]
    private static extern void _tradplusShowBanner(string adUnitId, bool shouldShow);

    [DllImport("__Internal")]
    private static extern void _tradplusShowNative(string adUnitId, int x, int y, int width, int height);

    [DllImport("__Internal")]
    private static extern void _tradplusHideNative(string adUnitId, bool needDestroy);

    [DllImport("__Internal")]
    private static extern void _tradplusInterstitialEntryAdScenario(string adUnitId);

    [DllImport("__Internal")]
    private static extern void _tradplusInterstitialEntryAdScenario2(string adUnitId, string adSceneId);

    [DllImport("__Internal")]
	private static extern void _tradplusRequestInterstitialAd(string adUnitId, bool autoReload ,bool isPangleTemplateRender);

    [DllImport("__Internal")]
    private static extern bool _tradplusIsInterstitialReady(string adUnitId);

    [DllImport("__Internal")]
    private static extern void _tradplusShowInterstitialAd(string adUnitId);

    [DllImport("__Internal")]
    private static extern void _tradplusShowInterstitialAd2(string adUnitId, string adSceneId);

    [DllImport("__Internal")]
    private static extern void _tradplusShowInterstitialConfirmUWSAd(string adUnitId);

    [DllImport("__Internal")]
    private static extern void _tradplusDestroyInterstitialAd(string adUnitId);

    [DllImport("__Internal")]
    private static extern void _tradplusRewardedVideoEntryAdScenario(string adUnitId);

    [DllImport("__Internal")]
    private static extern void _tradplusRewardedVideoEntryAdScenario2(string adUnitId, string adSceneId);

    [DllImport("__Internal")]
    private static extern void _tradplusRequestRewardedVideo(string adUnitId, bool autoReload, bool isPangleTemplateRender);

    [DllImport("__Internal")]
    private static extern bool _tradplusHasRewardedVideo(string adUnitId);

    [DllImport("__Internal")]
    private static extern void _tradplusShowRewardedVideo(string adUnitId);

    [DllImport("__Internal")]
    private static extern void _tradplusShowRewardedVideo2(string adUnitId, string adSceneId);

    [DllImport("__Internal")]
    private static extern void _tradplusShowRewardedVideoConfirmUWSAd(string adUnitId);

    [DllImport("__Internal")]
    private static extern void _tradplusDestroyRewardedVideo(string adUnitId);

    [DllImport("__Internal")]
    private static extern void _tradplusRequestOfferWall(string adUnitId);

    [DllImport("__Internal")]
    private static extern bool _tradplusHasOfferWall(string adUnitId);

    [DllImport("__Internal")]
    private static extern void _tradplusShowOfferWall(string adUnitId);

    [DllImport("__Internal")]
    private static extern void _tradplusShowOfferWallConfirmUWSAd(string adUnitId);

    [DllImport("__Internal")]
    private static extern void _tradplusDestroyOfferWall(string adUnitId);


#endif
#endregion
}
#endif
