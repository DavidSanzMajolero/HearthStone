using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TokenRoja : MonoBehaviour
{
    public string HP;
    public string DAM;

    public void Start()
    {

        ChangeToker();
    }

    public void ChangeToker()
    {

        GameManager.gameManager.UpdateToken(HP, DAM);  // Actualiza la UI con el nuevo nombre
    }
}
