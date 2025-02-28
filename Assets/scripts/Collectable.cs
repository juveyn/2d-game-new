using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    public int flowerCount;
    private CollectableManager cm;
    // Start is called before the first frame update
    void Start()
    {
        cm = GameObject.FindAnyObjectByType<CollectableManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        cm.flowerCount++;
        Destroy(gameObject);
    }
}
