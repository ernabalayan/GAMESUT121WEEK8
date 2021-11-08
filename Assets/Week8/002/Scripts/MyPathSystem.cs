using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MyPathSystem : MonoBehaviour {


    public enum SeedType { RANDOM, CUSTOM }
    [Header("Random Data")]
    public SeedType seedType = SeedType.RANDOM;

    System.Random random;
    public int seed = 0;

    [Space]
    public bool animatedPath;
    public List<List<GridCell>> gridCellList = new List<List<GridCell>>();
    public int pathLength = 10;

    [Range(1.0f, 7.0f)]
    public float cellSize = 1.0f;

    public float noiseScale;
    [Range(0f, 1f)] public float noiseThreshold;

    public GameObject[] cellPrefabs;
    Coroutine createPathCoroutine;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SetSeed();
            CreatePath();
        }
    }

    void SetSeed() {
        if (seedType == SeedType.RANDOM)
            random = new System.Random();
        else if (seedType == SeedType.CUSTOM)
            random = new System.Random(seed);
    }

    void CreatePath()
    {
        if (createPathCoroutine != null)
        {
            StopCoroutine(createPathCoroutine);
        }

        createPathCoroutine = StartCoroutine(CreatePathRoutine());
    }



    IEnumerator CreatePathRoutine()
    {
        for (int i = 0; i < gridCellList.Count; i++)
        {
            for (int j = 0; j < gridCellList[i].Count; j++)
            {
                Destroy(gridCellList[i][j].gameObject);
            }
        }
        gridCellList.Clear();

        Vector2 currentPosition = new Vector2(-15.0f, -9.0f);
        Vector2 initialPos = currentPosition;

        float noiseBase = random.Next(-100000, 100000);

        for (int y = 0; y < pathLength; y++)
        {
            gridCellList.Add(new List<GridCell>());

            for (int x = 0; x < pathLength; x++)
            {
                float noiseValue = Mathf.PerlinNoise((noiseBase + x) * noiseScale, (noiseBase + y) * noiseScale);

                GridCell cell = new GridCell(initialPos + new Vector2(x, y), noiseValue > noiseThreshold ? cellPrefabs[0] : cellPrefabs[1]);
                //cell.gameObject.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, noiseValue);

                gridCellList[y].Add(cell);

                yield return null;
            }
        }

        Vector2 currentCell = initialPos;
        Vector2 finalCell = initialPos + new Vector2(pathLength, pathLength);
        while (currentCell.x < finalCell.x && currentCell.y < finalCell.y)
        {
            bool direction = random.NextDouble();
            if (currentCell.x >= finalCell.x)
            {
                currentCell.y += 1;
            }
            else if (currentCell.y >= finalCell.y)
            {
                currentCell.x += 1;
            }
            else if (direction)
            {
                currentCell.x += 1;
            }
            else
            {
                currentCell.y += 1;
            }



            yield return null;
        }

        createPathCoroutine = null;
    }

    //IEnumerator CreatePathRoutine()
    //{
    //    gridCellList.Clear();
    //    Vector2 currentPosition = new Vector2(-15.0f, -20.0f);
    //    Vector2 initialPos = currentPosition;
    //    gridCellList.Add(new GridCell(currentPosition, cellPrefabs[0]));

    //    for (int i = 0; i < pathLength; i++)
    //    {

    //        int n = random.Next(100);

    //        if (n > 0 && n < 49)
    //        {
    //            currentPosition = new Vector2(currentPosition.x + cellSize, currentPosition.y);

    //        }
    //        else
    //        {
    //            currentPosition = new Vector2(currentPosition.x, currentPosition.y + cellSize);
    //        }


    //        yield return null;
    //    }
    //}

}
