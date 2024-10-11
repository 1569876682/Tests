using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    public class TalentAssessmentSystem
    {
        //时间复杂度O(log(min(m, n))
        //空间复杂度O(1)
        public static double FindMedianTalentIndex(int[] fireAbility, int[] iceAbility)
        {
            if (fireAbility.Length > iceAbility.Length)
            {
                int[] tmp = fireAbility;
                fireAbility = iceAbility;
                iceAbility = tmp;
            }
            int n = fireAbility.Length;
            int m = iceAbility.Length;
            int total = n + m;
            int left = 0;
            int right = n;
            while(left <= right)
            {
                int mid = (left + right) / 2;
                int mid2 = (total + 1) / 2 - mid;
                if(mid != 0 && mid2 != m && fireAbility[mid - 1] > iceAbility[mid2])
                {
                    right = mid - 1;
                }
                else if(mid != n && mid2 != 0 && fireAbility[mid] < iceAbility[mid2 - 1])
                {
                    left = mid + 1;
                }
                else
                {
                    int maxLeft;
                    if (mid == 0) maxLeft = iceAbility[mid2 - 1];
                    else if (mid2 == 0) maxLeft = fireAbility[mid - 1];
                    else maxLeft = Math.Max(iceAbility[mid2 - 1], fireAbility[mid - 1]);
                    if (total % 2 == 1) return maxLeft;

                    int minRight;
                    if (mid == n) minRight = iceAbility[mid2];
                    else if (mid2 == m) minRight = fireAbility[mid];
                    else minRight = Math.Min(iceAbility[mid2], fireAbility[mid]);
                    return (maxLeft + minRight) / 2;
                }
            }
            return 0;
        }
    }
}