using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildWall : MonoBehaviour
{
    // Start is called before the first frame update
    private string path = "Brick";
    void Start()
    {
        GameObject Wall = new GameObject("Wall");
        Wall.transform.position = new Vector3(0, Random.Range(0, 5), 0);
        for (int i = 0;i< 5;i++)
        {
            for (int j = 0;j<10;j++)
            {
                float y_th = (float)i * (float)(0.5);
                GameObject Brick =  (GameObject)Instantiate(Resources.Load(path),new Vector3(j,y_th,0),Quaternion.identity);
                Brick.transform.parent = Wall.transform;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
