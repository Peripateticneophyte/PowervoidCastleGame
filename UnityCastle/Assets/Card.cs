using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public enum CharacterType
{
    Normal,
    Fire,
    Water,
    Earth,
    Lightning
}

public class Card : MonoBehaviour
{
    public int CardID = 0;
    public string CardName;
    public int MaxHealth;
    public string flavorText;

    public List<CharacterType> Weaknesses;
    public List<Attack> Attacks;

    public Card()
    {

    }


    public Card(int InId, string InName, int InPower, int InHealth, string InFlavorText)
    {
        CardID = InId;
        CardName = InName;
        Attacks.Add(new Attack(InPower));
        
        MaxHealth = InHealth;
        flavorText = InFlavorText;
    }
}
