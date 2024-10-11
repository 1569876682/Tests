using System;
using System.Collections.Generic;
using System.Reflection;
namespace ConsoleApp1
{
    public class LeaderboardSystem
    {
        //时间复杂度O(nlogm),其中n为scores的长度
        /* 进阶思考：如果我们的游戏变得⾮常受欢迎，玩家数量达到了数百万，你会如何优化这个算法以处理⼤规模数据？
         * 答：我认为目前的算法可以快速的处理数百万规模的数据
         * 
         */
        public static List<int> GetTopScores(int[] scores, int m)
        {
            if(m > scores.Length) m = scores.Length;
            PriorityQueue<int, int> priorityQueue = new PriorityQueue<int, int>();
            foreach (int score in scores)
            {
                if (priorityQueue.Count < m)
                {
                    priorityQueue.Enqueue(score, score);
                }
                else
                {
                    if (priorityQueue.Peek() < score)
                    {
                        priorityQueue.Dequeue();
                        priorityQueue.Enqueue(score, score);
                    }
                }
            }
            List<int> topScores = new List<int>(new int[m]);
            int i = topScores.Count - 1;
            while (priorityQueue.Count > 0)
            {
                topScores[i--] = priorityQueue.Dequeue();
            }
            return topScores;
        }
    }
}