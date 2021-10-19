using UnityEngine;

public class BobMovement : MonoBehaviour
{
    #region Variables

    [SerializeField] private float deltaY;
    [SerializeField] private float speed;

    private Vector2 targetPos;
    private float yChange;

    #endregion

    #region Unity lifecycle

    private void Start()
    {
        targetPos = transform.position;
    }

    private void Update()
    {
        //Take input only if object is not moving
        if ((Vector2)transform.position == targetPos)
        {
            if ((Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)) && targetPos.y < deltaY)
            {
                targetPos = new Vector2(transform.position.x, transform.position.y + deltaY);
            }

            if ((Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow)) && targetPos.y > -deltaY)
            {
                targetPos = new Vector2(transform.position.x, transform.position.y - deltaY);
            }   
        }

        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
    }

    #endregion
}
