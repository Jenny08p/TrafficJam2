using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeployCars : MonoBehaviour
{
    public GameObject truckPrefab;
    public float respawnTime = 5.0f;
    private Vector2 screenBounds; 
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(truckWave()); 
    }

    private void spawnEnemy()
    {
        GameObject a = Instantiate(truckPrefab) as GameObject;
        a.transform.position = new Vector2(screenBounds.x * 2, Random.Range(-0, screenBounds.x));
    }
 
   IEnumerator truckWave()
    {
        while(true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnEnemy();
        }
    }
}
