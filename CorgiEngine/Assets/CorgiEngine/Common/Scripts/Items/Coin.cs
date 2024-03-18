using UnityEngine;
using UnityEngine.Events;

namespace MoreMountains.CorgiEngine
{
    /// <summary>
    /// Coin manager
    /// </summary>
    [AddComponentMenu("Corgi Engine/Items/Coin")]
    public class Coin : PickableItem
    {
        // Creamos un evento estático para notificar la recolección de monedas
        public static UnityEvent OnCoinCollectedStatic = new UnityEvent();

        protected override void Pick(GameObject picker) 
        {
            CorgiEnginePointsEvent.Trigger(PointsMethods.Add, 10); // Añadir puntos al jugador
            // Invocamos el evento estático para notificar a todos los suscriptores que se ha recogido una moneda
            OnCoinCollectedStatic.Invoke();
        }
    }
}
