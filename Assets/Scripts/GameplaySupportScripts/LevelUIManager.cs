using UnityEngine;
using System.Collections;

public class LevelUIManager : MonoBehaviour
{
    #region Properties
    public static LevelUIManager Instance = null;

    [Header("GameplayUIPanel Setup")]
    [SerializeField] private VariableJoystick scalingJoystick = null;
    [SerializeField] private GameObject scalingPhaseObj = null;
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
    public VariableJoystick GetScalingJoystick { get => scalingJoystick; }
    #endregion

    #region Public Core Functions
    public void EnableScalePhase(bool value)
    {
        scalingPhaseObj.SetActive(value);
    }
    #endregion
}