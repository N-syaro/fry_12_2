using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
   public Text text;
    int E_Count = 0;
   public GameObject ClearPanel;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ClearPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Enemy");
        E_Count = objs.Length;
        Debug.Log("ìGÇÃêî"+E_Count);
        text.text="EnemyCount : " + E_Count;
        if(E_Count == 0)
        {
            ClearPanel.SetActive(true);
        }
    }
}
