using Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Services
{
    public class AlgorithService: IAlgorithmService
    {
        public AlgorithService() 
        {

        }
        public int KadanesAlgorithm(int[] Arr)
        {
            int maxAnswer = Arr[0];
            int maxSoFar = Arr[0];
            int maxEndingHere = Arr[0];
            for (int i = 1; i < Arr.Length; i++)
            {
                maxEndingHere = Math.Max(Arr[i], maxEndingHere + Arr[i]);
                maxSoFar = Math.Max(maxSoFar, maxEndingHere);
            }
            return maxSoFar;
        }


    }
}
