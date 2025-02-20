using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MenuManager : MonoBehaviour
{
    //Content of the menus
    VisualElement _inventoryContent;
    VisualElement _spellsContent;
    VisualElement _optionsContent;

    //Clickable menus
    VisualElement _inventory;
    VisualElement _spells;
    VisualElement _options;

    private void NoContent()
    {
        _inventoryContent.style.display = DisplayStyle.None;
        _spellsContent.style.display= DisplayStyle.None;
        _optionsContent.style.display = DisplayStyle.None;
    }

    private void OnEnable()
    {
        UIDocument a_uiDoc = GetComponent<UIDocument>();
        VisualElement a_root = a_uiDoc.rootVisualElement;

        //VisualElement a_content = a_root.Q();
    }
}
