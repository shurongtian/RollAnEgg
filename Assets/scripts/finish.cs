using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class finish : MonoBehaviour
{
    //Attach an Image you want to fade in the GameObject's Inspector
    public Text m_Text;
    //Use this to tell if the toggle returns true or false
    bool m_Fading;
    //// Start is called before the first frame update
    void Start()
    {
        m_Fading = false;
    }

    //// Update is called once per frame
    void Update()
    {
        //If the toggle returns true, fade in the Image
        if (m_Fading == true)
        {
            //Fully fade in Image (1) with the duration of 2
            m_Text.CrossFadeAlpha(1, 2.0f, false);
            m_Fading = false;
        } else if (m_Fading == false)
        {
            //If the toggle is false, fade out to nothing (0) the Image with a duration of 2
            m_Text.CrossFadeAlpha(0, 2.0f, false);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            m_Fading = true;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
