using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anduin : MonoBehaviour
{
    public string AvatarName;

    public void Start()
    {
        GameManager.gameManager.UpdateAvatarUI(AvatarName);
    }

    public void ChangeAvatarName(string newName)
    {
        AvatarName = newName;
        GameManager.gameManager.UpdateAvatarUI(AvatarName);
    }
}
