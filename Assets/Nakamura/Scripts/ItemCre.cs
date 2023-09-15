using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ItemCre : MonoBehaviour
{
    public List<GameObject> Itemselect = new List<GameObject>();
    float X;
    float Y;
    public float Itemcount = 10.0f;
    float time = 0.0f;
    int item;
    float rndItem;


    [Header("アイテムの確率")]
    public float mask;
    public float boost;
    public float super;
    private float[] Item = new float[3];
    private float ItemTotal;
    private float starttime = 10.0f;
    float t = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
        super = 0;
        Item[0] = mask;
        Item[1] = boost;
        Item[2] = super;

        if (SceneManager.GetActiveScene().name == "Bos")
        {
            Itemselect.RemoveAt(2);
        }

        for (int i = 0; i < Item.Length; i++)
        {
            //Debug.Log(Item[i]);
            ItemTotal += Item[i];
        }
        //Debug.Log(ItemTotal);
        rndItem = Random.Range(0.0f, ItemTotal);
    }

    // Update is called once per frame
    void Update()
    {
        t+= Time.deltaTime;
        if(t >= starttime)
        {
            Debug.Log(ItemTotal);
            time += Time.deltaTime;
            if (Itemcount <= time)
            {
                ItemRandom();
                X = Random.Range(9.6f, 14.0f);
                Y = Random.Range(-2.71f, 3.42f);
                Instantiate(Itemselect[item], new Vector3(X, Y), Quaternion.identity);
                time = 0.0f;
                Item[2] += 0.5f;
                ItemTotal += 0.5f;
            }
        }
        

    }

    void ItemRandom()
    {
        float total = 0;

        for (item = 0; item < Item.Length; item++)
        {
            total += Item[item];
            if (rndItem <= total)
            {
                Debug.Log(total);
                Debug.Log(rndItem);
                rndItem = Random.Range(0.0f, ItemTotal);
                break;
            }
        }
    }
}
