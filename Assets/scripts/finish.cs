using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class finish : MonoBehaviour
{
    [SerializeField]
    private GameObject cookedEgg;

    public Text congrats;
    

    //// Start is called before the first frame update
    void Start()
    {

    }
    //// Update is called once per frame
    void Update()
    {
       
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.SetActive(false);
            cookedEgg.SetActive(true);

            congrats.text = "Congratulations!";
            StartCoroutine(ExecuteAfterTime(4));
        }
    }

    IEnumerator ExecuteAfterTime(float time)
    {
        
        yield return new WaitForSeconds(time);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        
    }
}
