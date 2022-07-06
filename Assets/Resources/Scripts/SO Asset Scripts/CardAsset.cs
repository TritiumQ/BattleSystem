using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TargetingOptions //卡牌目标选项
{
    NoTarget,
    AllCreatures,
    YourCreatures,
    AllCharacters,
    YourCharacters,
    EnemyCharacters
}

public class CardAsset : ScriptableObject
{
    [Header("General info")]
    //public CharacterAsset characterAsset;
    [TextArea(2, 3)]
    public string Description;// 卡牌描述
    public Sprite CardImage;// 卡牌图像
    public Sprite RarityImage;// 稀有度
    public int Cost;// 卡牌费用
    public string Race;

    [Header("Creature Info")]
    public int MaxHealth;// 最大生命值
    public int Atk;// 攻击力
    public int AtksPerTurn = 1;// 每回合攻击次数
    public bool Taunt;// 是否嘲讽
    public bool Charge;// 是否突袭
    public string CreatureScriptName;// 生物脚本名
    public int SpecialCreatureAmount;// 技能数值

    [Header("Spell Info")]
    public string SpellScriptName;
    public int SpellCreatureAmount;
    public TargetingOptions Targets;

}
