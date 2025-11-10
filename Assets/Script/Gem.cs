using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class Gem : MonoBehaviour, Item
{
    public void Collect()
    {
        Destroy(gameObject);
    }

}
