using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject ballPrefab;

    public float xCap;

    private void Start()
    {
        StartCoroutine(SpawnBall());
    }
    IEnumerator SpawnBall()
    {
        while(true)
        {
            Vector2 direction = new Vector2(Random.Range(-xCap, xCap),transform.position.y);

            GameObject ball = Instantiate(ballPrefab, direction, Quaternion.identity);

            Destroy(ball, 5f);

            yield return new WaitForSeconds(1f);
        }
    }
}
