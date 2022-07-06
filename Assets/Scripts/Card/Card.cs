using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public enum CardType
{
    ENEMY,
    SPELL,
    SURVENT
}

public class Card : MonoBehaviour
{
    CardAsset cardAsset;
    int cardID;
    int cardCost;
    string cardName;
    CardType cardType;  //SPELL,SURVENT,ENEMY
    string cardDescription;
    string cardCamp;
    Image cardBackground;

    //spell
    string spellEffectName;

    //survent
    int hp;
    int atk;
    bool isTank;
    bool isCharged;

    //enemy
    string effectName;
    void LoadCardInfo()
	{
        cardID = cardAsset.cardID;
        cardCost = cardAsset.cardCost;
        cardName = cardAsset.cardName;
        cardType = cardAsset.cardType;
        cardDescription = cardAsset.cardDescription;
        cardCamp = cardAsset.cardCamp;
        
        switch (cardType)
		{
            case CardType.SPELL:
                spellEffectName = cardAsset.spellEffectName;
                break;
            case CardType.SURVENT:
                hp = cardAsset.hp;
                atk = cardAsset.atk;
                isTank = cardAsset.isTank;
                isCharged = cardAsset.isCharged;
                break;
            case CardType.ENEMY:
                effectName = cardAsset.effectName;
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
