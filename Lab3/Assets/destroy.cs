using UnityEngine;

public class CollectableItem : MonoBehaviour
{
    // Вызывается при столкновении с другим коллайдером
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Проверяем, что столкнулись с игроком (по тегу)
        if (other.CompareTag("Player"))
        {
            // Уничтожаем предмет
            Destroy(gameObject);

            // Альтернатива: делаем предмет невидимым и неактивным
            // gameObject.SetActive(false);
        }
    }
}
