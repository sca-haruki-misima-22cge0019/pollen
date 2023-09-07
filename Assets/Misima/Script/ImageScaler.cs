using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageScaler : MonoBehaviour
{
    public Image imageToScale;
    public float minScale = 0.5f;
    public float maxScale = 2.0f;
    public float ScaleSpeed = 0.1f;

    private float currentScale = 1.0f;
    private bool isScalingUp = true;

    // Start is called before the first frame update
    void Start()
    {
        SetImageScale(currentScale);
    }

    // Update is called once per frame
    void Update()
    {
        if (isScalingUp)
        {
            currentScale += ScaleSpeed * Time.deltaTime;
            if(currentScale >= maxScale)
            {
                currentScale = maxScale;
                isScalingUp = false;
            }
        }
        else
        {
            currentScale -= ScaleSpeed * Time.deltaTime;
            if(currentScale <= minScale)
            {
                currentScale = minScale;
                isScalingUp = true;
            }
        }
        SetImageScale(currentScale);
    }

    private void SetImageScale(float scale)
    {
        imageToScale.transform.localScale = new Vector3(scale,scale,1f);
    }
}
