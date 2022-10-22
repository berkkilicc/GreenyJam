using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class AnotherScreen1 : MonoBehaviour
{
    private bool skipMovie = false;
    private void Start()
    {
        
    }
    private void Update()
    {
        StartCoroutine(nextscene());

        
    }



    IEnumerator nextscene()
    {
        if (Input.GetKey(KeyCode.E))
        {
            yield return new WaitForSeconds(3f);
            SceneManager.LoadScene(0);
        }
        
    }



}
