﻿int[] arr = {1, 3, 2, 5, 7, 10, 9, 6, 8};

for (int i = 1; i < arr.Length; i++)
{
    int temp = arr[i];
    int j = i;
    while(j > 0 && arr[j-1] > temp)
    {
        arr[j] = arr[j-1];
        j--;
    }
    arr[j] = temp;
}