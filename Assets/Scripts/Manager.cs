using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Manager : MonoBehaviour
{
    public static Manager Instance;
    public Renderer selectedRenderer;
    public Material SelectedMaterial;

    public List<PropsGameObject> propsGameObjects;
    private void Awake()
    {
        Instance = this;
    }

    public void ApplyVariantMaterial()
    {
        if (selectedRenderer != null && SelectedMaterial!= null)
        {
            selectedRenderer.material = SelectedMaterial;
        }
    }

    public void SelectMaterial(Material material)
    {
        SelectedMaterial = material;
    }

    public void EnabledDisableGameObject(string name)
    {
        foreach (PropsGameObject props in propsGameObjects)
        {
            if (props.name == name)
            {
                props.propObject.SetActive(!props.propObject.activeSelf);
            }
        }
    }
    [System.Serializable]
    public class PropsGameObject
    {
        public string name;
        public GameObject propObject;
    }
}
