using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instantinate : MonoBehaviour {
    private List<List<int>> angs;
    private int period = 1;
    private int periodshchet = 0;
    public int storona;
    public GameObject sphera;
    public int dims;
    private List<List<int>> crds;
	void Start () {
        crds = new List<List<int>>();
	   for(int i=0; i<dims; i++)
        {
            crds.Add(new List<int>());
            for (int j = 0; j < Mathf.Pow(2, dims); j++){
                crds[i].Add(0);
                if (periodshchet >= period)
                {
                    crds[i][j] =-storona/2;
                    periodshchet = 0;
                }

                else
                {
                    crds[i][j] = storona/2;
                    periodshchet++;
                }
                
            }
            periodshchet = 0;
            period*=2;
        }
        for (int i = 0; i < dims; i++)
        {
            for (int j = 0; j < Mathf.Pow(2, dims); j++)
            {
                Instantiate(sphera, new Vector3(crds[0][j], crds[1][j], crds[2][j]), Quaternion.identity);
            }
        }
    }
	
	
	void Update () {
        if (Input.GetKey(KeyCode.Space)) {
            for (int i = 0; i < Mathf.Pow(2,dims); i++)
            {

            }
        }
	}
}
