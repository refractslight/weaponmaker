using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;


public class UIManager : MonoBehaviour
{

    [SerializeField] private List<Button> _tabs;

    private Action<Button> _changeTabsEvent;
    
    void Start()
    {
        foreach (Button tab in _tabs)
        {
            tab.onClick.AddListener(delegate { _changeTabs(tab); });
        }
    }

    private void _changeTabs(Button tab)
    {
        Debug.Log("Changed Tabs");

        tab.gameObject.SetActive(true);
        foreach (Button button in _tabs)
        {
            if (button != tab) 
            {
                
            }
        }

        Debug.Log($"{tab.name} active");

    }
}
