using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSelector : MonoBehaviour
{
    #region Properties
    [Header("Attributes")]
    [SerializeField] private PropType propType = PropType.Selectable;

    [Header("Component Reference")]
    [SerializeField] private PropHandler propHandler = null;
    [SerializeField] private ObjectScaler objectScaler = null;
    #endregion

    #region MonoBehaviour Functions
    private void OnMouseDown()
    {
        if (propType == PropType.Selectable && !ObjectSelected)
        {
            if (!LevelManager.Instance.ActiveObjectPropHandler)
            {
                LevelManager.Instance.ActiveObjectPropHandler = propHandler;
                propHandler.EnableObjectHighlight(true);
            }
            else
            {
                LevelManager.Instance.ClearActiveObjectHighlight();
                LevelManager.Instance.ActiveObjectPropHandler = propHandler;
                propHandler.EnableObjectHighlight(true);
            }

            LevelUIManager.Instance.EnableScalePhase(true);
            ObjectSelected = true;
        }
        else
        {
            LevelManager.Instance.ClearActiveObjectHighlight();
            LevelUIManager.Instance.EnableScalePhase(false);
        }
    }
    #endregion

    #region Getter And Setter
    public bool ObjectSelected { get; set; }
    #endregion
}
