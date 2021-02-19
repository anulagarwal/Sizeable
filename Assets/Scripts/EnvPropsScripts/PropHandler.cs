using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropHandler : MonoBehaviour
{
    #region Properties
    [Header("Component Reference")]
    [SerializeField] private MeshRenderer meshRenderer = null;
    #endregion

    #region MonoBehaviour Functions
    #endregion

    #region Public Core Functions
    public void EnableObjectHighlight(bool value)
    {
        if (value)
        {
            meshRenderer.material.SetFloat("_Highlight", 1f);
        }
        else
        {
            meshRenderer.material.SetFloat("_Highlight", 0f);
        }
    }
    #endregion
}
