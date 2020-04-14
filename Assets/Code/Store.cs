using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Store : MonoBehaviour
{
    private Transform container;
    private Transform shopItem;
    private void Awake()
    {
        container = transform.Find("container");
        shopItem = container.Find("shopItem");
    } 
}
