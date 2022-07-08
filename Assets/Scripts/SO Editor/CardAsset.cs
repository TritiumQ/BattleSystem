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
    public string spellEffectName;     //����ʱ��Ч���硰���ơ�
    public bool copyType;   //��������


    [Header("Survent or Enemy card info")]
    public int hp;          //��ǰ����ֵ
    public int maxHp;       //����ֵ����
    public int atk;         //������
    public bool isTank;     //������
    public bool isCharged;  //ͻϮ���
    public bool isDeathrattle;  //������
    public int isHidden;    //����غ���
    public int isProtect;   //�ӻ�����
    public bool isVampire;  //��Ѫ���
    public bool isCombo;    //�������
    public int isSilence;   //��Ĭ�غ���
    public string deathrattleEffectName; //������ЧЧ��
    public string actionEffectName;    //����ʱ��ЧЧ�����硰�Ȼ����ٻ���
}
