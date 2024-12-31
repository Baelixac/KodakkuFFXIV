using System;
using System.Numerics;
using System.Runtime.Intrinsics.Arm;
using Dalamud.Memory.Exceptions;
using KodakkuAssist.Module.GameEvent;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using ECommons;
using Newtonsoft.Json;
using Dalamud.Utility.Numerics;
using KodakkuAssist.Data;
using KodakkuAssist.Data.PartyList;
using KodakkuAssist.Script;
using KodakkuAssist.Module.GameEvent;
using KodakkuAssist.Module.Draw;
using KodakkuAssist.Module.GameOperate;
using KodakkuAssist.Module.Draw.Manager;
using Newtonsoft.Json;
using System.Security.Cryptography;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel;
using System.Collections.Generic;
using System.Collections;
using System.Threading.Tasks;
using static Dalamud.Interface.Utility.Raii.ImRaii;
using Dalamud.Game.ClientState.Objects.Types;
using ECommons.Reflection;


namespace Weapontong;

[ScriptType(guid: "0374b7ed-6f72-4fb7-9c0c-ecb9641a1aed", name: "绝神兵泰坦小工具", territorys: [777], version: "0.0.0.5", author: "RedBromine & Baelixac", note:"神兵泰坦标3号桶位置+头上标点" +
    "\n 三连桶点名测试请用以下的宏：" +
    "\n /e 测试三连桶标点鸭鸭")]
public class Weapontong
{
    public List<int> playerIndexList = new List<int>();//playerIndexList 三连桶读取玩家名单初始化
    public List<int> customOrder = new List<int> { 0, 1, 4, 5, 6, 7, 2, 3 };//三连桶顺序 mt st d1234 h12
    public int bucketcount = 0; //让三连桶事件只触发1次
    public bool sanliantong = true;
    //存所有人ID
    
    [ScriptMethod(name: "重置战斗检测", eventType: EventTypeEnum.CombatChanged, eventCondition: ["Type:ResetCombat"], userControl:false)]
    public void 重置战斗检测(Event @event, ScriptAccessory accessory)
    {
         sanliantong = true;
         playerIndexList = new List<int>();//把三连桶存的名字清空
         bucketcount = 0;//初始化TT石牢计数
    }

    [ScriptMethod(name: "P3三连桶A右", eventType: EventTypeEnum.AddCombatant, eventCondition: ["SourcePosition:{\"X\":95.00,\"Y\":0.00,\"Z\":112.00}"], userControl:false)]
    public void P3三连桶A右(Event @event, ScriptAccessory accessory)
    {
        var dp = accessory.Data.GetDefaultDrawProperties();
        var dp2 = accessory.Data.GetDefaultDrawProperties();
        var dp3 = accessory.Data.GetDefaultDrawProperties();
        if (@event["SourceName"] == "爆破岩石" && sanliantong == true)
        { 
            
            dp.Name = "3号桶";
            dp.Scale = new(1);
            dp.Delay = 2000;
            dp.DestoryAt = 12000;
            dp.Color = new(0.3f, 1.0f, 0f,1.5f);
            dp.Position = new(105, 0, 105);
            
            dp2.Name = "2号桶";
            dp2.Scale = new(1);
            dp2.Delay = 2000;
            dp2.DestoryAt = 12000;
            dp2.Color = new(0.3f, 1.0f, 0f,1.5f);
            dp2.Position = new(100, 0, 100);
            
            dp3.Name = "1号桶";
            dp3.Scale = new(1);
            dp3.Delay = 2000;
            dp3.DestoryAt = 12000;
            dp3.Color = new(0.3f, 1.0f, 0f,1.5f);
            dp3.Position = new(100, 0, 94);
            
            accessory.Method.SendDraw(DrawModeEnum.Default, DrawTypeEnum.Circle, dp3);
            accessory.Method.SendDraw(DrawModeEnum.Default, DrawTypeEnum.Circle, dp2);
            accessory.Method.SendDraw(DrawModeEnum.Default, DrawTypeEnum.Circle, dp);
            sanliantong = false;
        }
    }

    [ScriptMethod(name: "P3三连桶A左", eventType: EventTypeEnum.AddCombatant, eventCondition: ["SourcePosition:{\"X\":105.00,\"Y\":0.00,\"Z\":112.00}"], userControl:false)]
    public void P3三连桶A左(Event @event, ScriptAccessory accessory)
    {
        var dp = accessory.Data.GetDefaultDrawProperties();
        var dp2 = accessory.Data.GetDefaultDrawProperties();
        var dp3 = accessory.Data.GetDefaultDrawProperties();
        if (@event["SourceName"] == "爆破岩石" && sanliantong == true)
        { 
            dp.Name = "3号桶";
            dp.Scale = new(1);
            dp.Delay = 2000;
            dp.DestoryAt = 12000;
            dp.Color = new(0.3f, 1.0f, 0f,1.5f);
            dp.Position = new(95, 0, 105);
            
            dp2.Name = "2号桶";
            dp2.Scale = new(1);
            dp2.Delay = 2000;
            dp2.DestoryAt = 12000;
            dp2.Color = new(0.3f, 1.0f, 0f,1.5f);
            dp2.Position = new(100, 0, 100);
            
            dp3.Name = "1号桶";
            dp3.Scale = new(1);
            dp3.Delay = 2000;
            dp3.DestoryAt = 12000;
            dp3.Color = new(0.3f, 1.0f, 0f,1.5f);
            dp3.Position = new(100, 0, 94);
            
            accessory.Method.SendDraw(DrawModeEnum.Default, DrawTypeEnum.Circle, dp3);
            accessory.Method.SendDraw(DrawModeEnum.Default, DrawTypeEnum.Circle, dp2);
            accessory.Method.SendDraw(DrawModeEnum.Default, DrawTypeEnum.Circle, dp);
            sanliantong = false;
        }
    }
    [ScriptMethod(name: "P3三连桶D右", eventType: EventTypeEnum.AddCombatant, eventCondition: ["SourcePosition:{\"X\":112.00,\"Y\":0.00,\"Z\":105.00}"], userControl:false)]
    public void P3三连桶D右(Event @event, ScriptAccessory accessory)
    {
        var dp = accessory.Data.GetDefaultDrawProperties();
        var dp2 = accessory.Data.GetDefaultDrawProperties();
        var dp3 = accessory.Data.GetDefaultDrawProperties();
        if (@event["SourceName"] == "爆破岩石" && sanliantong == true)
        { 
            dp.Name = "3号桶";
            dp.Scale = new(1);
            dp.Delay = 2000;
            dp.DestoryAt = 12000;
            dp.Color = new(0.3f, 1.0f, 0f,1.5f);
            dp.Position = new(105, 0, 95);
            
            dp2.Name = "2号桶";
            dp2.Scale = new(1);
            dp2.Delay = 2000;
            dp2.DestoryAt = 12000;
            dp2.Color = new(0.3f, 1.0f, 0f,1.5f);
            dp2.Position = new(100, 0, 100);
            
            dp3.Name = "1号桶";
            dp3.Scale = new(1);
            dp3.Delay = 2000;
            dp3.DestoryAt = 12000;
            dp3.Color = new(0.3f, 1.0f, 0f,1.5f);
            dp3.Position = new(94, 0, 100);
            
            accessory.Method.SendDraw(DrawModeEnum.Default, DrawTypeEnum.Circle, dp3);
            accessory.Method.SendDraw(DrawModeEnum.Default, DrawTypeEnum.Circle, dp2);
            accessory.Method.SendDraw(DrawModeEnum.Default, DrawTypeEnum.Circle, dp);
            sanliantong = false;
        }
    }
    [ScriptMethod(name: "P3三连桶D左", eventType: EventTypeEnum.AddCombatant, eventCondition: ["SourcePosition:{\"X\":112.00,\"Y\":-0.00,\"Z\":95.00}"], userControl:false)]
    public void P3三连桶D左(Event @event, ScriptAccessory accessory)
    {
        var dp = accessory.Data.GetDefaultDrawProperties();
        var dp2 = accessory.Data.GetDefaultDrawProperties();
        var dp3 = accessory.Data.GetDefaultDrawProperties();
        if (@event["SourceName"] == "爆破岩石" && sanliantong == true)
        { 
            dp.Name = "3号桶";
            dp.Scale = new(1);
            dp.Delay = 2000;
            dp.DestoryAt = 12000;
            dp.Color = new(0.3f, 1.0f, 0f,1.5f);
            dp.Position = new(105, 0, 105);
            
            dp2.Name = "2号桶";
            dp2.Scale = new(1);
            dp2.Delay = 2000;
            dp2.DestoryAt = 12000;
            dp2.Color = new(0.3f, 1.0f, 0f,1.5f);
            dp2.Position = new(100, 0, 100);
            
            dp3.Name = "1号桶";
            dp3.Scale = new(1);
            dp3.Delay = 2000;
            dp3.DestoryAt = 12000;
            dp3.Color = new(0.3f, 1.0f, 0f,1.5f);
            dp3.Position = new(94, 0, 100);
            
            accessory.Method.SendDraw(DrawModeEnum.Default, DrawTypeEnum.Circle, dp3);
            accessory.Method.SendDraw(DrawModeEnum.Default, DrawTypeEnum.Circle, dp2);
            accessory.Method.SendDraw(DrawModeEnum.Default, DrawTypeEnum.Circle, dp);
            sanliantong = false;
        }
    }
    [ScriptMethod(name: "P3三连桶C左", eventType: EventTypeEnum.AddCombatant, eventCondition: ["SourcePosition:{\"X\":95.00,\"Y\":-0.00,\"Z\":88.00}"], userControl:false)]
    public void P3三连桶C左(Event @event, ScriptAccessory accessory)
    {
        var dp = accessory.Data.GetDefaultDrawProperties();
        var dp2 = accessory.Data.GetDefaultDrawProperties();
        var dp3 = accessory.Data.GetDefaultDrawProperties();
        if (@event["SourceName"] == "爆破岩石" && sanliantong == true)
        { 
            dp.Name = "3号桶";
            dp.Scale = new(1);
            dp.Delay = 2000;
            dp.DestoryAt = 12000;
            dp.Color = new(0.3f, 1.0f, 0f,1.5f);
            dp.Position = new(105, 0, 95);
            
            dp2.Name = "2号桶";
            dp2.Scale = new(1);
            dp2.Delay = 2000;
            dp2.DestoryAt = 12000;
            dp2.Color = new(0.3f, 1.0f, 0f,1.5f);
            dp2.Position = new(100, 0, 100);
            
            
            dp3.Name = "1号桶";
            dp3.Scale = new(1);
            dp3.Delay = 2000;
            dp3.DestoryAt = 12000;
            dp3.Color = new(0.3f, 1.0f, 0f,1.5f);
            dp3.Position = new(100, 0, 106);
            
            accessory.Method.SendDraw(DrawModeEnum.Default, DrawTypeEnum.Circle, dp3);
            accessory.Method.SendDraw(DrawModeEnum.Default, DrawTypeEnum.Circle, dp2);
            accessory.Method.SendDraw(DrawModeEnum.Default, DrawTypeEnum.Circle, dp);
            sanliantong = false;
        }
    }
    [ScriptMethod(name: "P3三连桶C右", eventType: EventTypeEnum.AddCombatant, eventCondition: ["SourcePosition:{\"X\":105.00,\"Y\":-0.00,\"Z\":88.00}"], userControl:false)]
    public void P3三连桶C右(Event @event, ScriptAccessory accessory)
    {
        var dp = accessory.Data.GetDefaultDrawProperties();
        var dp2 = accessory.Data.GetDefaultDrawProperties();
        var dp3 = accessory.Data.GetDefaultDrawProperties();
        if (@event["SourceName"] == "爆破岩石" && sanliantong == true)
        { 
            dp.Name = "3号桶";
            dp.Scale = new(1);
            dp.Delay = 2000;
            dp.DestoryAt = 12000;
            dp.Color = new(0.3f, 1.0f, 0f,1.5f);
            dp.Position = new(95, 0, 95);
            
            dp2.Name = "2号桶";
            dp2.Scale = new(1);
            dp2.Delay = 2000;
            dp2.DestoryAt = 12000;
            dp2.Color = new(0.3f, 1.0f, 0f,1.5f);
            dp2.Position = new(100, 0, 100);
            
            
            dp3.Name = "1号桶";
            dp3.Scale = new(1);
            dp3.Delay = 2000;
            dp3.DestoryAt = 12000;
            dp3.Color = new(0.3f, 1.0f, 0f,1.5f);
            dp3.Position = new(100, 0, 106);
            
            accessory.Method.SendDraw(DrawModeEnum.Default, DrawTypeEnum.Circle, dp3);
            accessory.Method.SendDraw(DrawModeEnum.Default, DrawTypeEnum.Circle, dp2);
            accessory.Method.SendDraw(DrawModeEnum.Default, DrawTypeEnum.Circle, dp);
            sanliantong = false;
        }
    }
    [ScriptMethod(name: "P3三连桶B右", eventType: EventTypeEnum.AddCombatant, eventCondition: ["SourcePosition:{\"X\":88.00,\"Y\":-0.00,\"Z\":95.00}"], userControl:false)]
    public void P3三连桶B右(Event @event, ScriptAccessory accessory)
    {
        var dp = accessory.Data.GetDefaultDrawProperties();
        var dp2 = accessory.Data.GetDefaultDrawProperties();
        var dp3 = accessory.Data.GetDefaultDrawProperties();
        if (@event["SourceName"] == "爆破岩石" && sanliantong == true)
        { 
            dp.Name = "3号桶";
            dp.Scale = new(1);
            dp.Delay = 2000;
            dp.DestoryAt = 12000;
            dp.Color = new(0.3f, 1.0f, 0f,1.5f);
            dp.Position = new(95, 0, 105);
            
            dp2.Name = "2号桶";
            dp2.Scale = new(1);
            dp2.Delay = 2000;
            dp2.DestoryAt = 12000;
            dp2.Color = new(0.3f, 1.0f, 0f,1.5f);
            dp2.Position = new(100, 0, 100);
            
                        
            dp3.Name = "1号桶";
            dp3.Scale = new(1);
            dp3.Delay = 2000;
            dp3.DestoryAt = 12000;
            dp3.Color = new(0.3f, 1.0f, 0f,1.5f);
            dp3.Position = new(106, 0, 100);
            
            accessory.Method.SendDraw(DrawModeEnum.Default, DrawTypeEnum.Circle, dp3);
            accessory.Method.SendDraw(DrawModeEnum.Default, DrawTypeEnum.Circle, dp2);
            accessory.Method.SendDraw(DrawModeEnum.Default, DrawTypeEnum.Circle, dp);
            sanliantong = false;
        }
    }
    [ScriptMethod(name: "P3三连桶B左", eventType: EventTypeEnum.AddCombatant, eventCondition: ["SourcePosition:{\"X\":88.00,\"Y\":-0.00,\"Z\":105.00}"], userControl:false)]
    public void P3三连桶B左(Event @event, ScriptAccessory accessory)
    {
        var dp = accessory.Data.GetDefaultDrawProperties();
        var dp2 = accessory.Data.GetDefaultDrawProperties();
        var dp3 = accessory.Data.GetDefaultDrawProperties();
        if (@event["SourceName"] == "爆破岩石" && sanliantong == true)
        { 
            dp.Name = "3号桶";
            dp.Scale = new(1);
            dp.Delay = 2000;
            dp.DestoryAt = 12000;
            dp.Color = new(0.3f, 1.0f, 0f,1.5f);
            dp.Position = new(95, 0, 95);
            
            dp2.Name = "2号桶";
            dp2.Scale = new(1);
            dp2.Delay = 2000;
            dp2.DestoryAt = 12000;
            dp2.Color = new(0.3f, 1.0f, 0f,1.5f);
            dp2.Position = new(100, 0, 100);
            
            dp3.Name = "1号桶";
            dp3.Scale = new(1);
            dp3.Delay = 2000;
            dp3.DestoryAt = 12000;
            dp3.Color = new(0.3f, 1.0f, 0f,1.5f);
            dp3.Position = new(106, 0, 100);
            
            accessory.Method.SendDraw(DrawModeEnum.Default, DrawTypeEnum.Circle, dp3);
            accessory.Method.SendDraw(DrawModeEnum.Default, DrawTypeEnum.Circle, dp2);
            accessory.Method.SendDraw(DrawModeEnum.Default, DrawTypeEnum.Circle, dp);
            sanliantong = false;
        }
    }
    
    [ScriptMethod(name: "P3三连桶点名头上标点", eventType: EventTypeEnum.ActionEffect, eventCondition: ["ActionId:regex:^(11116|11115)$"])]
    public void P3三连桶点名头上标点(Event @event, ScriptAccessory accessory)
    {

            if (!ParseHexId(@event["TargetId"], out var tid)) return;
            var playerindex = accessory.Data.PartyList.IndexOf(tid);//获取3个被点人在可达鸭里的队伍位置
            playerIndexList.Add(playerindex);//把3个人的位置存进playerIndexList
            bucketcount++;
            if (bucketcount == 3)//让三连桶事件只触发1次，不然3次石牢事件会触发3次
            {
                List<int> finalIndex = playerIndexList.OrderBy(n => customOrder.IndexOf(n)).ToList();//按照mt st d1234 h12的顺序排列
                //accessory.Method.SendChat($"/e {string.Join(", ", finalIndex)}"); //debug用 测试点名
                accessory.Method.Mark(accessory.Data.PartyList[finalIndex[0]], MarkType.Attack1, false); //给顺序1的人标1
                accessory.Method.Mark(accessory.Data.PartyList[finalIndex[1]], MarkType.Attack2, false); //给顺序2的人标2
                accessory.Method.Mark(accessory.Data.PartyList[finalIndex[2]], MarkType.Attack3, false); //给顺序3的人标3
            }
    }
    
    [ScriptMethod(name: "三连桶标点测试", eventType: EventTypeEnum.Chat, eventCondition: ["Message:regex:^(测试三连桶标点鸭鸭)"])]
    public void 三连桶标点测试(Event @event, ScriptAccessory accessory)
    {
        // 创建一个 Random 实例
        Random random = new Random();
        // 生成 1~7 之间的 3 个不重复的随机整数
        List<int> randomBucket = Enumerable.Range(1, 7) // 生成 1~7 的范围
            .OrderBy(x => random.Next()) // 随机排序
            .Take(3) // 取前3个幸运B
            .ToList(); // 转换为列表
        List<int> finalIndex = randomBucket.OrderBy(n => customOrder.IndexOf(n)).ToList();//按照mt st d1234 h12的顺序排列
        accessory.Method.SendChat($"/e 测试：随机点3人 \n 可达鸭小队序列：0，1，4，5，6，7，2，3 \n 对应 MT ST D1 D2 D3 D4 H1 H2 \n 本次测试随机点名序列：{string.Join(", ", finalIndex)}"); //debug用 测试点名
        accessory.Method.Mark(accessory.Data.PartyList[finalIndex[0]], MarkType.Attack1, false);//给顺序1的人标1
        accessory.Method.Mark(accessory.Data.PartyList[finalIndex[1]], MarkType.Attack2, false);//给顺序2的人标2
        accessory.Method.Mark(accessory.Data.PartyList[finalIndex[2]], MarkType.Attack3, false);//给顺序3的人标3
    }
    
    

    private static bool ParseHexId(string? idStr, out uint id)
    {
        id = 0;
        if (string.IsNullOrEmpty(idStr)) return false;
        try
        {
            var idStr2 = idStr.Replace("0x", "");
            id = uint.Parse(idStr2, System.Globalization.NumberStyles.HexNumber);
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }
    


    
    
}



public static class EventExtensions
{
    
    private static bool ParseHexId(string? idStr, out uint id)
    {
        id = 0;
        if (string.IsNullOrEmpty(idStr)) return false;
        try
        {
            var idStr2 = idStr.Replace("0x", "");
            id = uint.Parse(idStr2, System.Globalization.NumberStyles.HexNumber);
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }
    
    //public static uint SourceName(this Event @event)
    //{
    //    return ParseHexId(@event["SourceName"], out var id) ? id : 0;
    //}
    
    public static uint SourceId(this Event @event)
    {
        return ParseHexId(@event["SourceId"], out var id) ? id : 0;
    }

    public static uint TargetId(this Event @event)
    {
        return ParseHexId(@event["TargetId"], out var id) ? id : 0;
    }
    public static uint ActionId(this Event @event)
    {
        return JsonConvert.DeserializeObject<uint>(@event["ActionId"]);
    }


    public static Vector3 SourcePosition(this Event @event)
    {
        return JsonConvert.DeserializeObject<Vector3>(@event["SourcePosition"]);
    }

    public static Vector3 TargetPosition(this Event @event)
    {
        return JsonConvert.DeserializeObject<Vector3>(@event["TargetPosition"]);
    }

    public static Vector3 EffectPosition(this Event @event)
    {
        return JsonConvert.DeserializeObject<Vector3>(@event["EffectPosition"]);
    }

    public static float SourceRotation(this Event @event)
    {
        return JsonConvert.DeserializeObject<float>(@event["SourceRotation"]);
    }
    
    
    
}
