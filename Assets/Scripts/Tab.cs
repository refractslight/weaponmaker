using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Tab : MonoBehaviour
{
    [SerializeField] private List<Button> _tabs;
    [SerializeField] private List<GameObject> _contents;
    [SerializeField] private GameObject _UIManager;
    [SerializeField] private Sprite _selected;
    [SerializeField] private Sprite _deselected;


    private SpriteState spriteState = new SpriteState();
    private Action<Button> _changeTabsEvent;
    private bool _isSelected = false;

    void Start()
    {
        foreach (Button tab in _tabs)
        {
            tab.onClick.AddListener(delegate { _changeTabs(tab); });
            if (_tabs[0] == tab)
            {
                _isSelected = true;
            }
        }

    }

    private void _changeTabs(Button tab)
    { 
        
        Debug.Log("Changed Tabs");
        if (!_isSelected)
        {
            spriteState.pressedSprite = _selected;

        }
        else
        {
            spriteState.pressedSprite = _deselected;
        }

        Debug.Log($"{tab.name} active");

    }
}
