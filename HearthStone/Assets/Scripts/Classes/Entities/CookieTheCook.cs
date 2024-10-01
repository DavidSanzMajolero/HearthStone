using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CookiTheCook : CharacterCard, IOnDead, IEffect
{
    private void Start()
    {
        ShowCard();
    }

    public void Effect()
    {
        throw new System.NotImplementedException();
    }

    public void Effect(Fighter target)
    {
        throw new System.NotImplementedException();
    }

    public void Effect(Fighter[] targets)
    {
        throw new System.NotImplementedException();
    }

    public void OnDead()
    {
        throw new System.NotImplementedException();
    }
}
