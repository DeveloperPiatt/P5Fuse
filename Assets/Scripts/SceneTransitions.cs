using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransitions : MonoBehaviour
{

  public Animator transitionAnim;
  public string sceneName;
  
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            StartCoroutine(LoadScene());
        }
    }

    public void loadPersonas() {
        StartCoroutine(LoadScene2("PersonasScene"));
    }

    public void loadShadows() {
        StartCoroutine(LoadScene2("ShadowsScene"));
    }
    public void loadFusionCalc() {
        StartCoroutine(LoadScene2("FusionCalcScene"));
    }

    public void loadProfiles() {
        StartCoroutine(LoadScene2("ProfilesScene"));
    }

    IEnumerator LoadScene2(string sn) {
        if(transitionAnim.gameObject.activeSelf) {
                transitionAnim.SetTrigger("end");
        }

        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(sn);
    }

    IEnumerator LoadScene() {

        if(transitionAnim.gameObject.activeSelf) {
                transitionAnim.SetTrigger("end");
        }

        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(sceneName);
    }
}
