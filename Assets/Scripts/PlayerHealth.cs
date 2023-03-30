using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerHealth : MonoBehaviour
{
    [SerializeField] int maxHealthPoints = 3;
    [SerializeField] float unhitableTime;
    int healthPoints;
    bool isUnhitable = false;
    [SerializeField] GameObject playerHealthHUD;
    [SerializeField] GameObject unhitableGFX;
    Image[] heartImages;
    // Start is called before the first frame update
    void Start()
    {
        healthPoints = maxHealthPoints;
        heartImages = playerHealthHUD.GetComponentsInChildren<Image>();
        unhitableGFX.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Obstacle") && isUnhitable == false)
        {
            Debug.Log("Found rock!!");
            healthPoints--;
            heartImages[healthPoints].enabled = false;
            if (healthPoints <= 0)
            {
                Debug.Log("ded");
            }
            else
            {
                StartCoroutine(BeUnhitable());
            }

        }
    }

    IEnumerator BeUnhitable()
    {
        isUnhitable = true;
        unhitableGFX.SetActive(true);
        yield return new WaitForSeconds(unhitableTime);
        isUnhitable = false;
        unhitableGFX.SetActive(false);
    }


}
