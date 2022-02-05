using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public enum CharacterCast
{
    Photocaste,
    Necrocaste,
    Neurocaste,
    Protocaste,
    Cocaste,
    Marcocaste
}

public enum CharacterGene
{
    Pyrogene,
    Hydrogene,
    Cryogene
}

public enum UnitRank
{
    One,
    Two,
    Three,
    Four,
    Five
}

public enum UnitType
{
    Standard,
    Beserker,
    Conveyance,
    Celestial,
    Sacrifice,
    Siege,
    Blockade,
    Commander,
    Ruler
}

public class Card : MonoBehaviour
{
    public int CardID = 0;
    public string CardName = "None"; // not a valid assumption, please overwrite when card created
    public int CastNumber = 1; // not a valid assumption, please overwrite when card created
    public CharacterGene Gene = CharacterGene.Pyrogene; // not a valid assumption, please overwrite when card created
    public UnitRank Rank = UnitRank.One;
    public UnitType Type = UnitType.Standard;
    public int MaxHealth = 2200;
    public int Speed = 50;
    public short BaseAccuracy = 95;
    public string flavorText = "";
    public bool IsCertainHit = false;
    public int Swiftness = 100;

    public List<CharacterGene> Weaknesses;
    public List<Attack> Attacks;

    public Card()
    {

    }


    public Card(int InId, string InName, int InPower, int InHealth, 
                string InFlavorText, CharacterGene InGene, UnitRank InRank,
                UnitType InType, int InCastNumber, int InSpeed, short InAccuracy,
                int InSwiftness)
    {
        CardID = InId;
        CardName = InName;
        Attacks.Add(new Attack(InPower));
        
        MaxHealth = InHealth;
        flavorText = InFlavorText;

        Gene = InGene;
        Rank = InRank;
        Type = InType;
        CastNumber = InCastNumber;
        Speed = InSpeed;
        BaseAccuracy = InAccuracy;
        Swiftness = InSwiftness;
    }
}
