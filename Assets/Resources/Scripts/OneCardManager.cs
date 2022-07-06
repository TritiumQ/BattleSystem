using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
/*
public class OneCardManager : MonoBehaviour
{
    public CardAsset cardAsset;
    public OneCardManager PreviewManager;
    [Header("Text Component References")]
    public TextMeshProUGUI NameText;// 卡牌名字
    public TextMeshProUGUI ManaText;// 卡牌费用
    public TextMeshProUGUI DescriptionText;// 卡牌描述
    public TextMeshProUGUI HealthText;// 卡牌最大生命
    public TextMeshProUGUI AtkText;// 卡牌攻击
    public TextMeshProUGUI Race;
    [Header("GameObject References")]
    public GameObject HealthIcon;
    public GameObject AtkIcon;
    [Header("Image References")]
    public Image CardGraphicImage;// 卡牌图片
    public Image CardRarityImage;// 卡牌稀有度
    public Image CardFaceGlowImage;// 卡牌发光

    private void Awake()
    {
        if(cardAsset != null)
        {
            ReadCardFromAsset();
        }
    }

    private bool canBePlayedNow = false;
    public bool CanBePlayedNow
    {
        get
        {
            return canBePlayedNow;
        }
        set
        {
            canBePlayedNow = value;
            CardFaceGlowImage.enabled = value;
        }
    }

    public void ReadCardFromAsset()
    {
        // 更新卡牌信息
        // 添加图片
        CardRarityImage.sprite = cardAsset.RarityImage;
        CardGraphicImage.sprite = cardAsset.CardImage;
        // 添加卡牌名字
        NameText.text = cardAsset.name;
        // 添加卡牌费用
        ManaText.text = cardAsset.Cost.ToString();
        // 添加描述
        DescriptionText.text = cardAsset.Description;
        Race.text = cardAsset.Race;

        //卡牌光效默认关闭
        CardFaceGlowImage.enabled = false;
        
        if(cardAsset.MaxHealth != 0)
        {
            AtkText.text = cardAsset.Atk.ToString();
            HealthText.text = cardAsset.MaxHealth.ToString();
        }
        else
        {
            AtkText.GetComponent<TextMeshProUGUI>().gameObject.SetActive(false);
            HealthText.GetComponent<TextMeshProUGUI>().gameObject.SetActive(false);
        }

        if(PreviewManager != null)
        {
            PreviewManager.cardAsset = cardAsset;
            PreviewManager.ReadCardFromAsset();
        }

    }


}
*/