using UnityEngine;

public class ClearCounter : BaseCounter
{
   

   [SerializeField] private KitchenObjectSO kitchenObjectSO;
   
   public override void Interact(Player player)
   {
       if (!HasKitchenObject())
       {
           // There is no KitchenObject here
           if (player.HasKitchenObject())
           {
               // Player is carrying something
               player.GetKitchenObject().SetKitchenObjectParent(this);
           }
           else
           {
               // Player not carrying anything
           }
       }
       else
       {
           // There is a KitchenObject here
           if (player.HasKitchenObject())
           {
               // Player is carrying something
           }
           else
           {
               // Player is not carring anything
               GetKitchenObject().SetKitchenObjectParent(player);
           }
       }
   }

  
}
