using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public enum AttackEffects
{
    Normal,
    Burn,
    Corrosion,
    Sleep,
    Stunned,
    Frozen,
    Soulsteal
}

public class Attack : MonoBehaviour
{
    public string AttackName = "None";
    public int AttackDamage = 100;

    public List<AttackEffects> TraitsOnAttack = new List<AttackEffects>();

    public Attack(int Power)
    {
        AttackName = "basic attack";
        AttackDamage = Power;
        TraitsOnAttack.Add(AttackEffects.Normal);
    }

}
