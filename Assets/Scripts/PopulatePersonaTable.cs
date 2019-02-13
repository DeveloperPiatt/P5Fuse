using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopulatePersonaTable : MonoBehaviour
{

    public int ROWCOUNT;
    public GameObject personaTableRow;
    public GameObject scrollView;

    // Start is called before the first frame update
    void Start()
    {
        for (int i=0; i< ROWCOUNT; i++) {
            Debug.Log("testing");
             GameObject go1 = (GameObject)Instantiate(personaTableRow, Vector3.zero, Quaternion.identity);
             go1.transform.SetParent(scrollView.transform, false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
