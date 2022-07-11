using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum GamePhase
{
    playerDraw,
    playerAction,
    enemyDraw,
    enemyAction,
    gameStart
}
public class BatttleSystem : MonoBehaviour
{
    Monster monster;
    List<Card> monsterSurvents = new List<Card>(); //敌人随从

    Player player;
    List<Card> playerDeck = new List<Card>(); //玩家牌堆
    List<Card> playerDiscardPile = new List<Card>(); //玩家弃牌堆
    List<Card> playerHands = new List<Card>(); //玩家手牌
    List<Card> playerSurvents = new List<Card>(); //玩家随从
    public int playerMaxHands; //玩家手牌上限
    public int playerMaxSurvents; //玩家随从放置上限
    
    int round;
    public GamePhase currentPhase = GamePhase.playerDraw;
    void Start()
    {

    }
    public void OnClickTurnEnd()
    {
        TurnEnd();
    }
    public void TurnEnd()
    {

    }
    public void GetHands(int _count) //从牌堆拿牌
    {
        while(_count>0)
        {
            _count--;
            if (playerHands.Count == playerMaxHands)
                break;
            Card _getNewCard = playerDeck[0];
            playerDeck.RemoveAt(0);
            playerHands.Add(_getNewCard);
            if(playerDeck.Count==0) //牌堆清空时惩罚并洗牌更新
            {
                PlayDeckPunish();
            }
        }
    }
    public void GetPlaterDeck() //牌堆更新洗牌
    {

    }
    public void PlayDeckPunish() //牌堆清空惩罚
    {

    }
    private void Update()
	{
		
	}
}
