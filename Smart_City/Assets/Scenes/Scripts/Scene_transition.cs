using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_transition : MonoBehaviour
{
    public Animator transitionanim;
    public string scenename;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    IEnumerator LoadScene()
    {
        transitionanim.SetTrigger("end");
        yield return new WaitForSeconds(0.1f);
        SceneManager.LoadScene(scenename);
    }
}
