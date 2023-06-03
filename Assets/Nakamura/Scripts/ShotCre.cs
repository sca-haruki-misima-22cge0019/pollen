
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShotCre : MonoBehaviour
{
    [SerializeField] GameObject Shot;
    [SerializeField] GameObject superShot;
    [SerializeField] Image Drug;
    public List<Sprite> DrugList = new List<Sprite>();
    private int drug = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            drug--;

            if (drug == 0)
            {
                drug = 10;
            }

            Instantiate(Shot, new Vector3(-7.8f, 0.0f), Quaternion.identity);
        }
        Drug.sprite = DrugList[drug];

        if (Input.GetKeyDown(KeyCode.M))
        {
            Instantiate(superShot, new Vector3(-7.8f, 0.0f), Quaternion.identity);
        }
    }

}
