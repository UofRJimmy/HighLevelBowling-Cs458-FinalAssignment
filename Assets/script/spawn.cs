using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    [SerializeField]
    private GameObject bottles;
    [SerializeField]
    private GameObject spawnpoint;
    private float colddown;
    // Start is called before the first frame update
    void Start()
    {
        colddown = 0f;

    }

    // Update is called once per frame
    void Update()
    {
        if (colddown > 0f)
        {
            colddown -= Time.deltaTime;
        }
        create();

    }
    void create()
    {
        if (cancreate)
        {
            Instantiate(bottles, transform.position, Quaternion.identity);
            colddown = 2f;
        }
    }

    public bool cancreate
    {
        get
        {
            return colddown <= 0f;
        }
    }
}
