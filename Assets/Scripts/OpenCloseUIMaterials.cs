using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenCloseUIMaterials : MonoBehaviour
{
    public Animator scrollViewTexturesAnimator;
    public Animator scrollViewPropsAnimator;
    public void ActiveAndDesactiveTexture()
    {
        if (scrollViewPropsAnimator.GetBool("svpIsOpen") == true)
        {
            scrollViewPropsAnimator.SetBool("svpIsOpen", false);
        }

        if (scrollViewTexturesAnimator.GetBool("svtIsOpen") == true)
        {
            scrollViewTexturesAnimator.SetBool("svtIsOpen", false);
            Manager.Instance.SelectedMaterial = null;
        }
        else
            scrollViewTexturesAnimator.SetBool("svtIsOpen", true);
        
    }
    public void ActiveAndDesactiveProps()
    {
        if (scrollViewTexturesAnimator.GetBool("svtIsOpen") == true)
        {
            scrollViewTexturesAnimator.SetBool("svtIsOpen", false);
        }

        if (scrollViewPropsAnimator.GetBool("svpIsOpen") == true)
            scrollViewPropsAnimator.SetBool("svpIsOpen", false);
        else
            scrollViewPropsAnimator.SetBool("svpIsOpen", true);
        
    }
}
