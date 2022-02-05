using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

//[createAssetMenu(menuName = "Scriptable Object/Deck")]
public class Deck : MonoBehaviour
{
    public static List<Card> CardList = new List<Card>();

    [SerializeField] public Card[] CardSet;

    
    void Awake()
    {
        // 
        // TODO: read from CSV file
        //  
           
    }
}
