using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellCard : MonoBehaviour
{
    public EntitySO SpellEntity;
    public int ManaCost;

    void Start()
    {
        ShowSpellCard();
    }

    public void ShowSpellCard()
    {
        GameManager.gameManager.UpdateSpellCardUI(SpellEntity, ManaCost);
    }
}
