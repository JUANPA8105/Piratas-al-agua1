using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Meta : MonoBehaviour
{ 
    public int tagScene = 2;
    private float timeAcum = 0;
    private bool isClear = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            isClear = true;
            gameObject.GetComponent<AudioSource>().Play();
        }
    }
    private void Update()
    {
        if (isClear == true)
        {
            timeAcum += Time.deltaTime;
            if (timeAcum > 5)
            {
                SceneManager.LoadScene(tagScene);
            }
        }
    }
}
