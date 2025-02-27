using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ItemSelector : MonoBehaviour
{
    private void OnEnable()
    {
        UIDocument uiDoc = GetComponent<UIDocument>();
        VisualElement root = uiDoc.rootVisualElement;

        UQueryBuilder<VisualElement> builder = new(root);
        VisualElement left = builder.Name("Left");

        left.Query(className: "equipment").ToList().ForEach(item =>
        {
            item.RegisterCallback<MouseOverEvent>(evt =>
            {
                item.AddToClassList("selected");
            });

            item.RegisterCallback<MouseOutEvent>(evt =>
            {
                item.RemoveFromClassList("selected");
            });
        });
    }
}
