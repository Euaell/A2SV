public class Solution {
    public int NumRescueBoats(int[] people, int limit) {
        Array.Sort(people);

        int boatCounter = 0;
        int counter = 0;

        int left = 0;
        int right = people.Length - 1;

        while (right >= left)
        {
            boatCounter++;
            if (people[left] + people[right] <= limit)
                left++;
            right--;
        }
        return boatCounter;
    }
}
