using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class SceneLoader : MonoBehaviour {

	// Use this for initialization
	void Start () {

        DontDestroyOnLoad(this.gameObject);
        SceneManager.LoadScene(1, LoadSceneMode.Additive);
        SceneManager.LoadScene(2, LoadSceneMode.Additive);
    }
	
	// Update is called once per frame
	void Update () {

        //Check if the user press Space bar
        if (Input.GetKeyDown(KeyCode.Space)) {

            int randomNumb = Random.Range(1, 5); // creates a number between 1 and 4
            int randomNumb2 = Random.Range(1, 5); // creates a number between 1 and 4

            while (randomNumb == randomNumb2) {
                randomNumb2 = Random.Range(1, 5);
            }
            SceneManager.LoadScene(randomNumb, LoadSceneMode.Single);
            SceneManager.LoadScene(randomNumb2, LoadSceneMode.Additive);
        }

	}
}
