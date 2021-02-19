using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectScaler : MonoBehaviour
{
    #region Properties
    [Header("Attributes")]
    [SerializeField] private float scaleSpeed = 0f;

    [Header("Component Reference")]
    [SerializeField] private ObjectSelector objectSelector = null;

    private ScaleType scaleType = ScaleType.ScaleUp;
    private int targetScale = 1;
    private bool isScaling = false;
    #endregion

    #region MonoBehaviour Functions
    private void Start()
    {
        targetScale = 1;
    }

    private void Update()
    {
        if (objectSelector.ObjectSelected)
        {
            if (LevelUIManager.Instance.GetScalingJoystick.Vertical > 0)
            {
                this.transform.localScale += Vector3.one * Time.deltaTime * scaleSpeed;
            }
            else if (LevelUIManager.Instance.GetScalingJoystick.Vertical < 0)
            {
                this.transform.localScale -= Vector3.one * Time.deltaTime * scaleSpeed;
            }
        }
    }
    #endregion
}
