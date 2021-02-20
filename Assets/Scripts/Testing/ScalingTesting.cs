using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScalingTesting : MonoBehaviour
{
    [SerializeField] private float scaleSpeed = 0f;
    private Vector3 targetScale = new Vector3(2, 2, 2);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.localScale.x < 2)
        {
            transform.localScale = Vector3.Lerp(transform.localScale, targetScale, scaleSpeed * Time.deltaTime);
        }
    }
}
