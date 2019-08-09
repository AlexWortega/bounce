using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSpawn : MonoBehaviour
{
    public GameObject branch;//префаб ветки
    public GameObject Tree_center;//префаб центра
    public int levels_of_tree;//
    public int cout_branches;//количество веток
   // private int radius= 3;//радиус по которому хуярится ветки
    public int const_level;//сколько высоты дельта между веткками
    // Start is called before the first frame update
    public int numberOfObjects = 20;
    public float radius = 5f;
    void Start()
    {

        for (int y = 0; y < levels_of_tree; y= y+1)
        {
            float level_branch = 0;
            Instantiate(Tree_center, new Vector3(0, y, 0), Quaternion.identity);
            //спавн центра

            for (int i = 0; i < numberOfObjects; i++)
            {

                float angle = i * Mathf.PI * 2 / numberOfObjects;
                float x = Mathf.Cos(angle) * radius/10;
                float z = Mathf.Sin(angle) * radius/10;
                
                level_branch++;
                Vector3 pos = transform.position + new Vector3(x, level_branch, z);
                float angleDegrees = -angle * Mathf.Rad2Deg;
                Quaternion rot = Quaternion.Euler(0, angleDegrees, 0);
                Instantiate(branch, pos, rot);
            }
                //спавн веток
               
        }
        

        // Update is called once per frame
        
    }
}
