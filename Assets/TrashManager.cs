using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using TMPro;

public class TrashManager : MonoBehaviour
{
    //[SerializeField] private GameObject unlockProgressObj;
    //[SerializeField] private Image progressBar;
    //[SerializeField] private TextMeshProUGUI trashAmount;
    //[SerializeField] private int trashPrice, trashRemainPrice;
    //[SerializeField] private float ProgressValue;



    //void Start()
    //{
    //    trashAmount.text = trashPrice.ToString("0");
    //    trashRemainPrice = trashPrice;
    //}


    //toplanan nesnelerin componentina ulasmak icin
    private void OnTriggerEnter(Collider other)
    {
        playerInventory playerInventory = other.GetComponent<playerInventory>();

        if (playerInventory != null)
        {
            //playerInventory.PlasticCollected();
            //playerInventory.PaperCollected();
            //playerInventory.GlassCollected();
            //playerInventory.IronCollected();
            //playerInventory.AluminumCollected();

            gameObject.SetActive(false);
        }
    }
}