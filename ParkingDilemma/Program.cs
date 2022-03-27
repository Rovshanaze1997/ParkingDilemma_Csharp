namespace ParkingDilemma;
public static class Solution {
    private static int CarParkingRoof(int[] arr, int k) {
        Array.Sort(arr);
        var start = 0;
        var carParkingRoof = int.MaxValue;
        
        for (int end = 0; end < arr.Length; end++) {
            if (end < k - 1) {
                continue;
            }
            var currentRoofLength = arr[end] - arr[start++] + 1;
            carParkingRoof = Math.Min(carParkingRoof, currentRoofLength);
        }
        return carParkingRoof;
    }

    public static void Main()
    {
        Console.WriteLine(
        CarParkingRoof(new []{6,2,12,7}, 2)); 
    }
}