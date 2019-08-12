using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSpawn : MonoBehaviour
{
    
    public Transform Spawner;//префаб спавенра для чилда
    public GameObject branch;//префаб ветки
    public GameObject Tree_center;//префаб центра
    public GameObject tree_roots;//ебучие корни
    public GameObject island;//ебучий остров
    public int levels_of_tree;//какая то хуйня забыл зачем
    public int cout_branches;//количество веток
                            
    public int const_level;//сколько высоты дельта между веткками
    // ___________________________________
    //            _________
    //            |       |
    //            |  | |  |
    //            |   _   |
    //____________|_______|_______________
    public int numberOfObjects = 20;//скока веток
    public float radius = 5f;//по какому радиусу хуярятся
    void Start()
    {   
        Tree_center.transform.SetParent(Spawner);
        branch.transform.SetParent(Spawner);
        for (int y = 0; y < levels_of_tree; y= y+1)
        {
            float level_branch = -6;
            GameObject treecenter = Instantiate(Tree_center, new Vector3(0, y, 0), Quaternion.identity) as GameObject;
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
