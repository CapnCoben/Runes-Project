using UnityEngine;

public class Cube : MonoBehaviour
{
    [SerializeField] public Transform[] checkpoints;
    [SerializeField] public float[] speed;
    [SerializeField] public Color[] colors;
    public int currentCheckpointIndex = 0;
}