using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopulatePersonaTable : MonoBehaviour
{

    public int ROWCOUNT;
    public GameObject personaTableRow;
    public GameObject scrollView;
    ArrayList masterPersonaList = new ArrayList();
    Text pname;
    Text plevel;
    

    // Start is called before the first frame update
    void Start()
    {
        if (masterPersonaList.Count == 0) {
            PopulatePersonaArray();
        }
        
        foreach (Hashtable pData in masterPersonaList) {
            GameObject go1 = (GameObject)Instantiate(personaTableRow, Vector3.zero, Quaternion.identity);
             go1.transform.SetParent(scrollView.transform, false);

            GameObject nameLabel = go1.transform.Find("name").gameObject;
             pname = nameLabel.GetComponent<Text>();

            GameObject baselevelLabel = go1.transform.Find("blevel").gameObject;
            plevel = baselevelLabel.GetComponent<Text>(); 

            //  pname = go1.GetComponent<Text>();
             Debug.Log(pData["name"]);
             pname.text = pData["name"].ToString();
             plevel.text = pData["level"].ToString();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PopulatePersonaArray() {
        masterPersonaList.Add(CreatePersona("persona01", 1));
        masterPersonaList.Add(CreatePersona("persona02", 23));
        masterPersonaList.Add(CreatePersona("persona03", 48));
        masterPersonaList.Add(CreatePersona("persona04", 32));
    }

    Hashtable CreatePersona(string pname, int plevel) {
        Hashtable aNewPersona = new Hashtable();
        aNewPersona.Add("name", pname);
        aNewPersona.Add("level", plevel);
        return aNewPersona;
    }
}
