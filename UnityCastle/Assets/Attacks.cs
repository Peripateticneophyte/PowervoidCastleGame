using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public enum AttackType
{
    Normal,
    Lightning,
    Fire,
    Confusion
}

public class Attack : MonoBehaviour
{
    public string AttackName;
    public int AttackDamage;

    public List<AttackType> TraitsOnAttack = new List<AttackType>();

    public Attack(int Power)
    {
        AttackName = "basic attack";
        AttackDamage = Power;
        TraitsOnAttack.Add(AttackType.Normal);
    }

}
