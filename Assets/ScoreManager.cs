using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    // Start is called before the first frame update
    private bool fallen = false;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (fallen == false) {
            if (this.transform.rotation.eulerAngles.z > 70) {
                fallen = true;
                GlobalVariables.score += 1;
            }
        }
    }
}
