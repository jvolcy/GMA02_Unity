using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    int score = 0;

    [SerializeField]
    int babiesSaved = 0, babiesLost = 0, demonsKilled = 0, demonStrikes = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DemonHitFireball()
    {
        //Debug.Log("DemonHitFireball");
        score += 100;
        demonsKilled++;
    }

    public void BabyHitFireball()
    {
        //Debug.Log("BabyHitFireball");
        score -= 400;
        babiesLost++;
    }

    public void DemonHitDragon()
    {
        //Debug.Log("DemonHitDragon");
        score -= 50;
        demonStrikes++;
    }

    public void BabyHitDragon()
    {
        //Debug.Log("BabyHitDragon");
        score += 200;
        babiesSaved++;
    }
}
