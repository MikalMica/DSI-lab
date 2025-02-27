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

    private void NoSelected()
    {
        _inventory.RemoveFromClassList("selected");
        _spells.RemoveFromClassList("selected");
        _options.RemoveFromClassList("selected");

    }

    private void OnEnable()
    {
        UIDocument a_uiDoc = GetComponent<UIDocument>();
        VisualElement a_root = a_uiDoc.rootVisualElement;

        VisualElement a_content = a_root.Q("Content");
        VisualElement a_menu = a_root.Q("Menus");

        _inventory = a_menu.Q("Inventory");
        _spells = a_menu.Q("Spells");
        _options = a_menu.Q("Options");

        _inventoryContent = a_content.Q("InvContent");
        _spellsContent = a_content.Q("SpellsContent");
        _optionsContent = a_content.Q("OptContent");

        _inventory.RegisterCallback<MouseDownEvent>(evt =>
        {
            NoContent();
            NoSelected();
            _inventoryContent.style.display = DisplayStyle.Flex;
            _inventory.AddToClassList("selected");
        });

        _spells.RegisterCallback<MouseDownEvent>(evt =>
        {
            NoContent();
            NoSelected();
            _spellsContent.style.display = DisplayStyle.Flex;
            _spells.AddToClassList("selected");
        });

        _options.RegisterCallback<MouseDownEvent>(evt =>
        {
            NoContent();
            NoSelected();
            _optionsContent.style.display = DisplayStyle.Flex;
            _options.AddToClassList("selected");
        });
    }
}
