using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCard : Card
{
    public CharacterSO Character; 

    public void ShowCard()
    {
        GameManager.gameManager.UpdateCharacterCardUI(Character, Mana, Character.Damage, Character.Health);
    }


    public void Invoke(Token token)
    {
        ShowCard(); 
    }
}
