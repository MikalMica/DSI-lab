using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class TextEnhancer : MonoBehaviour
{
    private void OnEnable()
    {
        UIDocument a_uiDoc = GetComponent<UIDocument>();
        VisualElement a_root = a_uiDoc.rootVisualElement;

        Label a_firetxt = a_root.Q<Label>("Firetxt");
        Label a_firetitle = a_root.Q<Label>("Firetitle");

        Label a_healtxt = a_root.Q<Label>("Healtxt");
        Label a_healtitle = a_root.Q<Label>("Healtitle");

        Label a_matxt = a_root.Q<Label>("MAtxt");
        Label a_matitle = a_root.Q<Label>("MAtitle");

        a_firetxt.text = "<b><gradient=\"Fire\">Inflinge 50 puntos de daño</gradient></b>";
        a_firetitle.text = @"<b><gradient=""Fire"">Fireball</gradient></b>";

        a_healtitle.text = @"<b><gradient=""Heal"">Heal</gradient></b>";
        a_healtxt.text = @"<b><gradient=""Heal"">Cura 20 puntos de vida</gradient></b>";

        a_matitle.text = @"<b><gradient=""MA"">Magic armor</gradient></b>";
        a_matxt.text = @"<b><gradient=""MA"">Crea una armadura magica que da 10 puntos de defensa</gradient></b>";

    }
}
