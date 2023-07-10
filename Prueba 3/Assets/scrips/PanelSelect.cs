using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelSelect: MonoBehaviour
{
    public int panelSelect;
    public void changePanel()
    {
        PanelManager.panel = panelSelect;
    }
}
