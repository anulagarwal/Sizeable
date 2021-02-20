using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    #region Properties
    public static LevelManager Instance = null;

    private List<float> ObjectScales = new List<float>() { 0.25f, 0.5f, 1, 2f, 3f };
    #endregion

    #region MonoBehaviour Functions
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        Instance = this;
    }
    #endregion

    #region Getter And Setter
    public PropHandler ActiveObjectPropHandler { get; set; }

    public List<float> GetObjectScales { get => ObjectScales; }
    #endregion

    #region Public Core Functions
    public void ClearActiveObjectHighlight()
    {
        if (ActiveObjectPropHandler)
        {
            ActiveObjectPropHandler.EnableObjectHighlight(false);
            ActiveObjectPropHandler.DisableObjectSelection();
            ActiveObjectPropHandler = null;
        }
    }
    #endregion
}
