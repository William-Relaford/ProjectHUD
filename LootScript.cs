using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootScript : MonoBehaviour {
    [System.Serializable]
    public class DropCurrency
    {
        public string name;
        public GameObject item;
        public int dropRarity;
    }

    public List<DropCurrency> LootTable = new List<DropCurrency>();
    public int dropChance;
    

    public void calculateloot()
    {
        int calc_dropChance = Random.Range(0, 101);

        if(calc_dropChance > dropChance)
        {
            Debug.Log("No Loot for me");
            return;
        }

        if(calc_dropChance <= dropChance)
        {
            int itemWeight = 0;

            for(int i = 0; i < LootTable.Count; i++)
            {
                itemWeight += LootTable[i].dropRarity;
            }
            Debug.Log("itemWeight=" + itemWeight);//135

            int randomValue = Random.Range(0, itemWeight);//80

            for (int Coin = 0; Coin < LootTable.Count; Coin++)
            {
             
                if (randomValue <= LootTable[Coin].dropRarity)
                {
                    Instantiate(LootTable[Coin].item,transform.position,Quaternion.identity);
                    return;
                }
                randomValue -= LootTable[Coin].dropRarity;
                Debug.Log("Random Value decreased" + randomValue);
            }
        }
    }
}
