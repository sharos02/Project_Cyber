using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Move : MonoBehaviour
{
    // How quickly the player follows the mouse.
    public float speed;

    //Called every frame
    void Update()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        if (sceneName == "Game")
        {
            //Converting mouse position into Vector3
            Vector3 Target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //Fixing Z-Axis
            Target.z = transform.position.z;

            // Move the player towards the mouse.
            transform.position = Vector3.MoveTowards(transform.position, Target, speed * Time.deltaTime / transform.localScale.x);
        }
    }
}
