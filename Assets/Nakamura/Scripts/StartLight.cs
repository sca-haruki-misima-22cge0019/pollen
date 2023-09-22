using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class StartLight : MonoBehaviour
{
    [SerializeField] GameObject LightButton;
    private bool isImageEnabled = true;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Loop(0.5f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator Loop(float seconds)
    {
        while (true)
        {
            yield return new WaitForSeconds(seconds);
            Image image = LightButton.GetComponent<Image>();
            if (image != null)
            {
                isImageEnabled = !isImageEnabled;
                image.enabled = isImageEnabled;
            }
            Debug.Log("SSS");
        }
    }
}
