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
        // don't want to have to write cards in this deck in this function
        // want them to be a property to edit in unity window,
        // and instead are saved in the scenes
        // will have to figure out some way of doing deck databases
        // for players to choose from
        // when they go into a game
    }
}
