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
    private bool isScaling = false;
    private int scaleIndex = 2;
    private Vector3 targetScale = Vector3.zero;
    #endregion

    #region MonoBehaviour Functions
    private void Start()
    {
        
    }

    private void Update()
    {
        if (objectSelector.ObjectSelected)
        {
            if (LevelUIManager.Instance.GetScalingJoystick.Vertical > 0)
            {
                if (!isScaling)
                {
                    SetTargetScale(true);
                }
                else
                {
                    if (transform.localScale.x < LevelManager.Instance.GetObjectScales[scaleIndex])
                    {
                        transform.localScale = Vector3.Lerp(transform.localScale, targetScale, scaleSpeed * Time.deltaTime);
                    }
                    else
                    {
                        isScaling = false;
                    }
                }
            }
            else if (LevelUIManager.Instance.GetScalingJoystick.Vertical < 0)
            {
                if (!isScaling)
                {
                    SetTargetScale(false);
                }
                else
                {
                    if (transform.localScale.x > LevelManager.Instance.GetObjectScales[scaleIndex])
                    {
                        transform.localScale = Vector3.Lerp(transform.localScale, targetScale, scaleSpeed * Time.deltaTime);
                    }
                    else
                    {
                        isScaling = false;
                    }
                }
            }
        }
    }
    #endregion

    #region Private Core Functions
    private void SetTargetScale(bool inc)
    {
        float newScaleValue = 0;
        if (inc)
        {
            if (scaleIndex < LevelManager.Instance.GetObjectScales.Count - 1)
            {
                scaleIndex++;
                newScaleValue = LevelManager.Instance.GetObjectScales[scaleIndex] + 0.15f;
            }
        }
        else
        {
            if (scaleIndex > 0)
            {
                scaleIndex--;
                newScaleValue = LevelManager.Instance.GetObjectScales[scaleIndex] - 0.05f;
            }
        }

        targetScale = new Vector3(newScaleValue, newScaleValue, newScaleValue);
        isScaling = true;
    }
    #endregion
}
