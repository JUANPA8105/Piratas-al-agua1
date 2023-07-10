using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitCounter : MonoBehaviour
{
    void Update()
    {
        if (gameObject.transform.childCount == 0)
        {
            gameObject.SetActive(false);
        }
    }
}
