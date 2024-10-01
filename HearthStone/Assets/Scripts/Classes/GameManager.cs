using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManager;

    public Image Char, Spell, Token, Power, Avatar;
    public Text CharMana, CharDMG, CharHP, CharDesc, SpellMana, SpellDesc, PowerMana, TokenHP, TokenDMG;
    public Text AvatarNameText;  
    private void Awake()
    {
        if (gameManager != null && gameManager != this)
        {
            Destroy(gameObject);
        }
        else
        {
            gameManager = this;
        }
    }

    public void UpdateCharacterCardUI(CharacterSO characterSO, int mana, int dmg, int hp)
    {
        Char.sprite = characterSO.Design;
        CharMana.text = mana.ToString();
        CharDMG.text = dmg.ToString();
        CharHP.text = hp.ToString();
        CharDesc.text = characterSO.Description;
    }

    public void UpdateSpellCardUI(EntitySO spellSO, int manaCost)
    {
        Debug.Log(Spell);
        Spell.sprite = spellSO.Design;     
        SpellMana.text = manaCost.ToString(); 
        SpellDesc.text = spellSO.Description; 
    }
    public void UpdateAvatarUI(string avatarName)
    {
        AvatarNameText.text = avatarName;
    }
    public void UpdateToken(string HP, string DAM)
    {
        TokenHP.text = HP;
        TokenDMG.text = DAM;
    }

}
