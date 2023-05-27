using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarrierTime : MonoBehaviour
{
    private float noTime = 0.0f;
    [SerializeField] GameObject Barrier;
    [SerializeField] GameObject TimeUIObject;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TimeUIObject.SetActive(false);
        if (!Barrier.activeSelf)
        {
            
            noTime += Time.deltaTime;

            if (noTime >= 7.0f)
            {
                TimeUIObject.SetActive(true);
                int count = (int)noTime;
                count = 10-count;
                Text TimeText = TimeUIObject.GetComponent<Text>();
                TimeText.text = count.ToString();
            }
        }

        if (noTime >= 10.0f)
        {
            Barrier.SetActive(true);
            TimeUIObject.SetActive(false);
            noTime = 0.0f;
        }
    }
}
