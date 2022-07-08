using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatttleSystem : MonoBehaviour
{
    Monster monster;
    List<Card> monsterSurvents; //敌人随从

    Player player;
    List<Card> playerDeck; //玩家牌堆
    List<Card> playerDiscardPile; //玩家弃牌堆
    List<Card> playerHands; //玩家手牌
    List<Card> playerSurvents; //玩家随从
    int round;

	private void Update()
	{
		
	}
}
