using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleInteraction : MonoBehaviour
{
    [SerializeField] private List<Item> items;

    private void Start()
    {
        EnableCorrectItem(ItemType.Coin);
    }

    private void EnableCorrectItem(ItemType itemType)
    {
        foreach (var item in items)
        {
            item.gameObject.SetActive(item.GetToyType() == itemType);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Collectible"))
        {
            var newItem = other.GetComponent<Item>();
            if (newItem == null) return;

            EnableCorrectItem(newItem.GetToyType());
        }
    }
    private void changeMoneyCounterText()
    {
        var checkItem = this.GetComponent<Item>();
    }
}
