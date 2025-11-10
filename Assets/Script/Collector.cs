using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Collector : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Item item_ = collision.GetComponent<Item>();
        if (item_ != null)
        {
            item_.Collect();
        }
    }
}
