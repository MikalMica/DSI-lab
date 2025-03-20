using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Lab4d : VisualElement
{
    VisualElement panelRojo = new VisualElement();
    VisualElement panelAmbar = new VisualElement();
    VisualElement panelVerde = new VisualElement();
    int estado;

    public int Estado {
        get { return estado; }
        set{
            estado = value;
            encenderColor();
        }
    }


    void encenderColor()
    {
        panelRojo.style.backgroundColor = new Color(0.27f, 0, 0);
        panelAmbar.style.backgroundColor = new Color(0.27f, 0.27f, 0);
        panelVerde.style.backgroundColor = new Color(0, 0.27f, 0);

        if (Estado == 0) panelRojo.style.backgroundColor = Color.red;
        if (Estado == 1) panelAmbar.style.backgroundColor = Color.yellow;
        if (Estado > 1) panelVerde.style.backgroundColor = Color.green;

    }
    public new class UxmlFactory : UxmlFactory<Lab4d, UxmlTraits> { };
    public new class UxmlTraits : VisualElement.UxmlTraits
    {
        UxmlIntAttributeDescription myEstado = new UxmlIntAttributeDescription { name = "estado", defaultValue = 0 };

        public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
        {
            base.Init(ve, bag, cc);
            var semaforo = ve as Lab4d;
            semaforo.Estado = myEstado.GetValueFromBag(bag, cc);
            Debug.Log("semaforo Estado: " + semaforo.Estado);
        }
    }

    public Lab4d()
    {

        panelRojo.style.width = 100;
        panelRojo.style.height = 100;

        panelAmbar.style.width = 100;
        panelAmbar.style.height = 100;

        panelVerde.style.width = 100;
        panelVerde.style.height = 100;

        panelRojo.AddToClassList("panel_round");
        panelAmbar.AddToClassList("panel_round");
        panelVerde.AddToClassList("panel_round");

        hierarchy.Add(panelRojo);
        hierarchy.Add(panelAmbar);
        hierarchy.Add(panelVerde);
    }
}
