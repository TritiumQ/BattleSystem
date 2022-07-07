using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardAsset : ScriptableObject
{
    public int cardID;
    public int cardCost;
    public string cardName;
    public CardType cardType;  //SPELL,SURVENT,ENEMY //SURVENT=ENEMY
    public string cardDescription;
    public string cardCamp;
    public Image cardBackground;
    [Header("Spell card info")]
    public string spellEffectName;

    [Header("Survent card info")]
    public int hp;
    public int atk;
    public bool isTank;
    public bool isCharged;
    public string actionEffectName;
}
