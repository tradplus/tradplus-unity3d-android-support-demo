﻿using System;
using UnityEngine;
using System.Collections.Generic;
using TradPlusInternal.ThirdParty.MiniJSON;

public class TradPlusAndroidNative
{
    private readonly AndroidJavaObject _nativePlugin;


    public TradPlusAndroidNative(string adUnitId)
    {
        _nativePlugin = new AndroidJavaObject("com.tradplus.ads.unity.NativeUnityPlguin", adUnitId);
    }

    // 设置AdSize，加载广告前调用
    public void SetAdSize(int width, int height)
    {
        _nativePlugin.Call("setSize", width, height);
    }

     
    public void SetNativeCustomParams(Dictionary<string, object> map)
    {
        _nativePlugin.Call("setCustomParams", Json.Serialize(map));
    }

    //加载广告，设置位置（底部中间、顶部中间）
    public void CreateNative(TradPlus.AdPosition position, string adSceneId = "")
    {
        _nativePlugin.Call("createNative", (int)position, adSceneId);
    }

    //加载广告 设置坐标参数
    //两种加载广告的方法只能二选一
    public void CreateNative(int x, int y, string adSceneId = "")
    {
        _nativePlugin.Call("createNative", x, y, adSceneId);
    }

    //隐藏广告 or 显示广告
    public void ShowNative(bool shouldShow)
    {
        _nativePlugin.Call("hideNative", !shouldShow);
    }

    //销毁广告
    public void DestroyNative()
    {
        _nativePlugin.Call("destroyNative");
    }

    //进入广告场景
    public void NativeEntryAdScenario(string adSceneId = "")
    {
        _nativePlugin.Call("entryAdScenario", adSceneId);
    }
}
