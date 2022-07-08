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
    public string spellEffectName;     //发动时生效，如“复制”
    public bool copyType;   //复制体标记


    [Header("Survent or Enemy card info")]
    public int hp;          //当前生命值
    public int maxHp;       //生命值上限
    public int atk;         //攻击力
    public bool isTank;     //嘲讽标记
    public bool isCharged;  //突袭标记
    public bool isDeathrattle;  //亡语标记
    public int isHidden;    //隐匿回合数
    public int isProtect;   //加护次数
    public bool isVampire;  //吸血标记
    public bool isCombo;    //连击标记
    public int isSilence;   //沉默回合数
    public string deathrattleEffectName; //亡语生效效果
    public string actionEffectName;    //部署时生效效果，如“先机，召唤”
}
