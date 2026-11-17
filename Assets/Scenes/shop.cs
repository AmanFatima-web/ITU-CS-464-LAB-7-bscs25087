
using UnityEngine;

public class ShopManager : MonoBehaviour
{
    public GameObject purchaseMessage;

    public void BuyItem()
    {
        purchaseMessage.SetActive(true);
    }
}
