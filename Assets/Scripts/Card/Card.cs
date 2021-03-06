using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Card : MonoBehaviour
{
    public CardAsset cardAsset;
    int cardID;
    int cardCost;
    string cardName;
    CardType cardType;  //SPELL,SURVENT,ENEMY
    string cardDescription;
    CardCamp cardCamp;
    Image cardBackground;
    
    //spell
    string spellEffectName;
    bool isCopied;

    //survent or enemy
    int hp;
    int maxHp;
    int atk;
    bool isTank;
    bool isCharged;
    bool isDeathrattle;
    int isHidden;
    int isProtected;
    bool isVampire;
    bool isCombo;
    int isSilence;
    string deathrattleEffectName;
    string actionEffectName;
    void LoadCardInfo()
	{
        cardID = cardAsset.cardID;
        cardCost = cardAsset.cardCost;
        cardName = cardAsset.cardName;
        cardType = cardAsset.cardType;
        cardDescription = cardAsset.cardDescription;
        cardCamp = cardAsset.cardCamp;
        cardBackground = cardAsset.cardBackground;

        switch (cardType)
		{
            case CardType.SPELL:
                spellEffectName = cardAsset.spellEffectName;
                isCopied = cardAsset.isCopied;
                break;
            case CardType.SURVENT:
            case CardType.ENEMY:
                hp = cardAsset.hp;
                atk = cardAsset.atk;
                isTank = cardAsset.isTank;
                isCharged = cardAsset.isCharged;
                isDeathrattle = cardAsset.isDeathrattle;
                isHidden = cardAsset.isHidden;
                isProtected = cardAsset.isProtected;
                isVampire = cardAsset.isVampire;
                isCombo = cardAsset.isCombo;
                isSilence = cardAsset.isSilence;
                deathrattleEffectName = cardAsset.deathrattleEffectName;
                actionEffectName = cardAsset.actionEffectName;
                break;
            default:
                break;
		}
	}
    void LoadCardInfo(CardAsset _cardAsset)
	{
        cardAsset = _cardAsset;
        LoadCardInfo();
	}
}
