using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public int index;
    // Start is called before the first frame update

    void OnMouseUp()
    {
        SceneManager.LoadScene(index);
    }
}
