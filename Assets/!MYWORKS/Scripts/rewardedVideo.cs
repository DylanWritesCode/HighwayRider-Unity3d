using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using EasyMobile;

public class rewardedVideo : MonoBehaviour {
    public Text Coins;
    void OnEnable() 
    {
        Advertising.RewardedAdCompleted += CompletedHandler;
        Advertising.RewardedAdSkipped += SkippedHandler;
    }

    void OnDisable()
    {
        Advertising.RewardedAdCompleted -= CompletedHandler;
        Advertising.RewardedAdSkipped -= SkippedHandler;
    }

    void CompletedHandler(RewardedAdNetwork network, AdLocation location)
    {
        giveReward();
        NativeUI.ShowToast("Thanks for watching rewarded video ad, your reward has been credited");
    }

    void SkippedHandler(RewardedAdNetwork network, AdLocation location)
    {
        NativeUI.ShowToast("Unfortunately you skipped the video, reward is not credited");
    }


    void giveReward() {
        PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") + 1000);
        Coins.text = PlayerPrefs.GetInt("Coins").ToString();
    }

    public void ShowVideoAd() {
        if (Advertising.IsRewardedAdReady())
            Advertising.ShowRewardedAd();
    }
}
