using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserChar : MonoBehaviour
{
    void Update()
    {
        if (CharManager.User != 4)
        {
            gameObject.transform.GetChild(CharManager.User).gameObject.SetActive(true);
        }
        
    }
}
