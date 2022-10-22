using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class AnotherScreen : MonoBehaviour
{
    private void Start()
    {
        
    }

   IEnumerator nextscene()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene(1);
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("1level"))
        {
            Debug.Log("nextsceneee");
            StartCoroutine(nextscene());

            // if (Input.GetKey(KeyCode.E))
            // {

            // }


        }

      
    }

    IEnumerator levelgenerator()
    {

        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(1);
    }
}
