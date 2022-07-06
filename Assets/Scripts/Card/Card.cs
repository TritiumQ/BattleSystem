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
    public CardAsset cardAsset;
    int cardID;
    int cardCost;
    string cardName;
    CardType cardType;  //SPELL,SURVENT,ENEMY
    string cardDescription;
    string cardCamp;
    Image cardBackground;

    //spell
    string spellEffectName;

    //survent or enemy
    int hp;
    int atk;
    bool isTank;
    bool isCharged;
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
                break;
            case CardType.SURVENT:
            case CardType.ENEMY:
                hp = cardAsset.hp;
                atk = cardAsset.atk;
                isTank = cardAsset.isTank;
                isCharged = cardAsset.isCharged;
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
