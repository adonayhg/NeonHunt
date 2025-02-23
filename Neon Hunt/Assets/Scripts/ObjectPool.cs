using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    Stack<GameObject> pool;
    [SerializeField]
    GameObject prefab;

    [SerializeField]
    int amount = 10;
    // Start is called before the first frame update
    void Awake()
    {
        pool = new Stack<GameObject>();
        GameObject temporal = null;
        for (int i = 0; i < amount; i++)
        {
            temporal = Instantiate(prefab);
            temporal.SetActive(false);
            pool.Push(temporal);

        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public GameObject Pop()
    {
        GameObject toReturn = null;
        if (pool.Count > 0)
        {
            toReturn = pool.Pop();
        }
        else
        {
            toReturn = Instantiate(prefab);
        }
        return toReturn;
    }

    public void Push(GameObject objectToPush)
    {
        objectToPush.SetActive(false);
        pool.Push(objectToPush);

    }

}