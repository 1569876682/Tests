using System;

namespace ConsoleApp1
{
    public class TreasureHuntSystem
    {
        //时间复杂度O(n)，其中n为treasures的长度
        //空间复杂度O(n)
        /* 进阶挑战：
         * 1.如果我们允许玩家使⽤⼀次"魔法钥匙"，可以安全地打开任意两个相邻的宝箱⽽不触发陷阱，你会如何修改你的算法？
         * 
         * 
         * 2.在游戏的⾼级关卡中，有些宝箱可能包含负值（表⽰陷阱会扣除玩家的分数）。你的算法如何处理这种情况？
         * 答：目前的算法无法处理负值的情况，但是可以进行分段动态规划，在每次遇到的第一个负数和下一个负数之间（不包括这两个负数）进行一次目前的算法，
         * 把每段区域的结果累加就是最后的答案。
         */
        public static int MaxTreasureValue(int[] treasures)
        {
            if(treasures.Length == 0) return 0;
            if(treasures.Length == 1) return treasures[0];
            int[] dp = new int[treasures.Length];
            dp[0] = treasures[0];
            dp[1] = Math.Max(treasures[0], treasures[1]);
            for (int i = 2; i < treasures.Length; i++)
            {
                dp[i] = Math.Max(dp[i - 1], dp[i - 2] + treasures[i]);
            }
            return dp[treasures.Length - 1];
        }
    }
}