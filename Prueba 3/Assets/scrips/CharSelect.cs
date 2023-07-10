using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CharSelect : MonoBehaviour
{
    public int charID;
    public void changeID()
    {
        CharManager.User = charID;
    }
}
