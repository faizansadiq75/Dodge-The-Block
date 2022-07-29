using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawner : MonoBehaviour
{
    public Transform[] size;
    public GameObject blockPrefab;

    private void Start()
    {
        StartCoroutine(spawnBlocker());
    }
    IEnumerator spawnBlocker()
    {
        while (true)
        {
            yield return new WaitForSeconds(2f);
            int j = Random.Range(0, size.Length);
            for (int i = 0; i < size.Length; i++)
            {
                if (i != j)
                {
                    Instantiate(blockPrefab, size[i].position, Quaternion.identity);
                }
            }
        }
    }
}
