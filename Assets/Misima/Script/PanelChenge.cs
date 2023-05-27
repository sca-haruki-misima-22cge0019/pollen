using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelChenge : MonoBehaviour
{
    public GameObject ClosePanel;
    public GameObject NextPanel;

    // Start is called before the first frame update
    void Start()
    {
        ClosePanel.SetActive(true);
        NextPanel.SetActive(false);
    }

    public void CloseView() 
    {
        ClosePanel.SetActive(true);
        NextPanel.SetActive(false);
    }

    public void NextView() 
    {
        ClosePanel.SetActive(false);
        NextPanel.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
