using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public static Manager Instance;
    public Renderer selectedRenderer;
    public Material SelectedMaterial;
    public List<MainMaterial> mainMaterials;

    [SerializeField] private int currentMainMaterialIndex = 0;
    [SerializeField] private int currentVariantIndex = 0;
    //public Image mainTextures;
    //public Image variantTextures;
    private void Awake()
    {
        Instance = this;
    }
    private void Start()
    {
        //UpdateMainTextureUI();
        //UpdateVariantTextureUI();
    }
    public void ChangeMainMaterial()
    {
        if (mainMaterials.Count > 0)
        {
            currentMainMaterialIndex = (currentMainMaterialIndex + 1) % mainMaterials.Count;
            currentVariantIndex = 0;
            //ApplyMainMaterial();
            //UpdateMainTextureUI();
            //UpdateVariantTextureUI();

        }
    }

    public void ChangeVariantMaterial()
    {
        if (mainMaterials.Count > 0 && mainMaterials[currentMainMaterialIndex].variants.Count > 0)
        {

            currentVariantIndex = (currentVariantIndex + 1) % mainMaterials[currentMainMaterialIndex].variants.Count;
            //ApplyVariantMaterial();
            //UpdateVariantTextureUI();

        }
    }

    public void ApplyMainMaterial()
    {
        if (selectedRenderer != null)
        {
            //selectedRenderer.material = mainMaterials[currentMainMaterialIndex].mainMaterial;\
            selectedRenderer.material = SelectedMaterial;
        }
    }

    public void ApplyVariantMaterial()
    {
        if (selectedRenderer != null && SelectedMaterial!= null/*&& mainMaterials[currentMainMaterialIndex].variants.Count > 0*/)
        {
            //selectedRenderer.material = mainMaterials[currentMainMaterialIndex].variants[currentVariantIndex];
            selectedRenderer.material = SelectedMaterial;
        }
    }
    //private void UpdateMainTextureUI()
    //{
    //    Material currentMaterial = mainMaterials[currentMainMaterialIndex].mainMaterial;
    //    Texture2D albedoTexture = (Texture2D)currentMaterial.GetTexture("_MainTex");

    //    if (albedoTexture != null)
    //    {
    //        Sprite albedoSprite = Sprite.Create(albedoTexture, new Rect(0, 0, albedoTexture.width, albedoTexture.height), new Vector2(0.5f, 0.5f));
    //        mainTextures.sprite = albedoSprite;
    //    }
    //}

    //private void UpdateVariantTextureUI()
    //{
    //    Material currentVariant = mainMaterials[currentMainMaterialIndex].variants[currentVariantIndex];
    //    Texture2D albedoTexture = (Texture2D)currentVariant.GetTexture("_MainTex");

    //    if (albedoTexture != null)
    //    {
    //        Sprite albedoSprite = Sprite.Create(albedoTexture, new Rect(0, 0, albedoTexture.width, albedoTexture.height), new Vector2(0.5f, 0.5f));
    //        variantTextures.sprite = albedoSprite;
    //    }
    //}
    public void SelectMaterial(Material material)
    {
        SelectedMaterial = material;
    }
    [System.Serializable]
    public class MainMaterial
    {
        public Material mainMaterial;
        public List<Material> variants = new List<Material>();
    }
}
