using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    #region Properties
    public static LevelManager Instance = null;
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
    #endregion

    #region Public Core Functions
    public void ClearActiveObjectHighlight()
    {
        if (ActiveObjectPropHandler)
        {
            ActiveObjectPropHandler.EnableObjectHighlight(false);
            ActiveObjectPropHandler = null;
        }
    }
    #endregion
}
