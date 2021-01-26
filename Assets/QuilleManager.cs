using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuilleManager : MonoBehaviour
{
    public GameObject quille;
    public GameObject scene;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 3; i++) {
            GameObject newQuille = Instantiate(quille, new Vector3(0, 0, 0), Quaternion.identity);
            newQuille.transform.parent = scene.transform;
            newQuille.transform.localPosition = new Vector3(-4 + (i * 3), 0, 30);
        }
    }

    // Update is called once per frame
    void Update()
    {   
    }
}
