using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
/*
public class CardDisplay : MonoBehaviour
{
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI costText;
    public TextMeshProUGUI healthText;
    public TextMeshProUGUI attackText;
    public TextMeshProUGUI skillText;
    public TextMeshProUGUI raceText;

    public Image backgroundImage;

    public Card card;

    // Start is called before the first frame update
    void Start()
    {
        ShowCard(); //显示/刷新卡牌
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowCard()
    {
        nameText.text = card.cardName;
        if(card is MonsterCard)
        {
            var monster = card as MonsterCard;
            attackText.GetComponent<TextMeshProUGUI>().text = monster.atk.ToString();
            healthText.GetComponent<TextMeshProUGUI>().text = monster.health.ToString();
            costText.GetComponent<TextMeshProUGUI>().text = monster.cost.ToString();
            raceText.GetComponent<TextMeshProUGUI>().text = monster.race;
            skillText.GetComponent<TextMeshProUGUI>().text = monster.skill;
        }
        else if(card is SpellCard)
        {
            var spell = card as SpellCard;
            attackText.GetComponent<TextMeshProUGUI>().gameObject.SetActive(false);
            healthText.GetComponent<TextMeshProUGUI>().gameObject.SetActive(false);
            costText.GetComponent<TextMeshProUGUI>().text = spell.cost.ToString();
            raceText.GetComponent<TextMeshProUGUI>().text = spell.race;
            skillText.GetComponent<TextMeshProUGUI>().text = spell.effect;
        }
    }
}
*/