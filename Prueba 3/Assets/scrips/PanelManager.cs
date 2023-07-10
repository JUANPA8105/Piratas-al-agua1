using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelManager : MonoBehaviour
{
    public static int panel = 1;
    AudioSource audi;
    private bool comAudio = false;
    public int panelSelect;
    public void changePanel()
    {
        PanelManager.panel = panelSelect;
    }
    public void LoadController()
    {
        for (int i = 1; i < this.transform.childCount; i++)
        {
            if (i != panel)
            {
                gameObject.transform.GetChild(i).gameObject.SetActive(false);
            } else
            {
                gameObject.transform.GetChild(panel).gameObject.SetActive(true);
            }
        }
    }
    private void Start()
    {
        try
        {
            audi = GetComponent<AudioSource>();
            audi.Play();
            audi.loop = true;
            comAudio = true;
        }
        catch
        {
            comAudio = false;
        }
    }
    void Update()
    {
        if (comAudio)
        {
            if (AudioManager.sound)
            {
                audi.volume = 0.5f;
            }
            else
            {
                audi.volume = 0;
            }
        }
        LoadController();
    }

}
