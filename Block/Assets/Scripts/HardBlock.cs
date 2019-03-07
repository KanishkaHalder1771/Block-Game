using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HardBlock : MonoBehaviour {

    [SerializeField] Sprite sprite2;
    int x=0;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        x = x + 1;
        if (x == 1)
        {
            gameObject.GetComponent <SpriteRenderer>().sprite = sprite2;
        }
        if(x == 2)
        {
            Destroy(gameObject);
        }
    }
}
