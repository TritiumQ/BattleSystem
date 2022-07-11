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
    List<Card> monsterSurvents = new List<Card>(); //�������

    Player player;
    List<Card> playerDeck = new List<Card>(); //����ƶ�
    List<Card> playerDiscardPile = new List<Card>(); //������ƶ�
    List<Card> playerHands = new List<Card>(); //�������
    List<Card> playerSurvents = new List<Card>(); //������
    public int playerMaxHands; //�����������
    public int playerMaxSurvents; //�����ӷ�������
    
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
    public void GetHands(int _count) //���ƶ�����
    {
        while(_count>0)
        {
            _count--;
            if (playerHands.Count == playerMaxHands)
                break;
            Card _getNewCard = playerDeck[0];
            playerDeck.RemoveAt(0);
            playerHands.Add(_getNewCard);
            if(playerDeck.Count==0) //�ƶ����ʱ�ͷ���ϴ�Ƹ���
            {
                PlayDeckPunish();
            }
        }
    }
    public void GetPlaterDeck() //�ƶѸ���ϴ��
    {

    }
    public void PlayDeckPunish() //�ƶ���ճͷ�
    {

    }
    private void Update()
	{
		
	}
}
