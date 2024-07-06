using UnityEngine;
using UnityEngine.Tilemaps;

public class NextActivePieceBoard : MonoBehaviour
{
    public Tilemap tilemap { get; private set; }
    public Piece nextPiece { get; private set; }

    public TetrominoData[] tetrominoes;
    public Vector2Int boardSize = new Vector2Int(5, 5);
    public Vector3Int nextPieceSpawnPosition = new Vector3Int(0, 0, 0);

    private void Awake()
    {
        tilemap = GetComponentInChildren<Tilemap>();
        nextPiece = GetComponentInChildren<Piece>();

        for (int i = 0; i < tetrominoes.Length; i++)
        {
            tetrominoes[i].Initialize();
        }
    }

    public void DisplayNextPiece()
    {
        int random = Random.Range(0, tetrominoes.Length);
        TetrominoData data = tetrominoes[random];
        nextPiece.InitializeNextActivePiece(this, nextPieceSpawnPosition, data);

        tilemap.ClearAllTiles();
        Set(nextPiece);
    }

    private void Set(Piece piece)
    {
        for (int i = 0; i < piece.cells.Length; i++)
        {
            Vector3Int tilePosition = piece.cells[i] + piece.position;
            tilemap.SetTile(tilePosition, piece.data.tile);
        }
    }
}
