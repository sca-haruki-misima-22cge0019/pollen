
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCre : MonoBehaviour
{
    public List<GameObject> Itemselect = new List<GameObject>();
    float X;
    float Y;
    float Itemcount = 5.0f;
    float time = 0.0f;
    int rnd;

    [Header("アイテムの確率")]
    public float nune;
    public float mask;
    public float boost;
    public float super;
    private float[] Item;
    private float ItemTotal;

    // Start is called before the first frame update
    void Start()
    {
        Item[0] = nune;
        Item[1] = mask;
        Item[2] = boost;
        Item[3] = super;

        for(int i = 0; i<Item.Length;i++)
        {
            ItemTotal+=Item[i];
        }
    }

    // Update is called once per frame
    void Update()
    {

        time += Time.deltaTime;
        if(Itemcount <= time)
        {
            ItemRandom();
            X = Random.Range(9.6f, 14.0f);
            Y = Random.Range(-2.71f,3.42f);
            Instantiate(Itemselect[rnd], new Vector3(X, Y), Quaternion.identity);
            time = 0.0f;
        }
        
    }

    void ItemRandom()
    {
        float total = 0;
        float rnd = Random.Range(0.0f,ItemTotal);

        for (int i = 0; i < Item.Length; i++)
        {
            total += Item[i];
            if(rnd <total)
            {

            }
        }
    }
}
