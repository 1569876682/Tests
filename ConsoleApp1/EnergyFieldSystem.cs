using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class EnergyFieldSystem
    {
        //时间复杂度O(n²)
        //空间复杂度O(1)
        //创意思考：这个能量场机制如何影响玩家在游戏中的策略选择？你能想到如何将这个概念扩展到⼀个有趣的游戏玩法中吗？
        //答：玩家会尽可能选距离远并且更高的位置建造能量塔；
        //我的想法是，玩家视角一开始在地图中心，并且左右两个方向均有迷雾，迷雾覆盖的区域不可见，玩家只能在可视范围内建造能量塔，
        //根据获得的能量场的强度的数值，玩家可以以一定速度获得魔力值，玩家可以消耗魔力值释放召唤魔法，召唤魔法可以召唤可控制的兵种，
        //控制兵探索地图来让迷雾区域可见，当探索到一定区域后，玩家可以重新规划两座能量塔的位置，以达到更快的魔力获取速度。
        public static float MaxEnergyField(int[] heights)
        {
            float maxField = 0;
            for(int i = 0; i < heights.Length; i++)
            {
                for(int j = i + 1; j < heights.Length; j++)
                {
                    maxField = Math.Max((heights[i] + heights[j]) * (j - i) / 2.0f, maxField);
                }
            }
            return maxField;
        }
    }
}
