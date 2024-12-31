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

[ScriptType(guid: "0374b7ed-6f72-4fb7-9c0c-ecb9641a1aed", name: "神兵3号桶位置", territorys: [777], version: "0.0.0.3", author: "RedBromine & Baelixac", note:"神兵泰坦标3号桶位置+头上标点（无需triggernometry）")]
public class Weapontong
{
    public List<int> playerIndexList = new List<int>();//playerIndexList 三连桶读取玩家名单初始化
    public List<int> customOrder = new List<int> { 0, 1, 4, 5, 6, 7, 2, 3 };//三连桶顺序 mt st d1234 h12
    public int bucketcount = 0; //让三连桶事件只触发1次
    public bool sanliantong = true;
    //存所有人ID
    
    [ScriptMethod(name: "重置战斗检测", eventType: EventTypeEnum.CombatChanged, eventCondition: ["Type:ResetCombat"])]
    public void 重置战斗检测(Event @event, ScriptAccessory accessory)
    {
         sanliantong = true;
         playerIndexList = new List<int>();//把三连桶存的名字清空
         bucketcount = 0;//初始化TT石牢计数
    }

    [ScriptMethod(name: "P3三连桶A右", eventType: EventTypeEnum.AddCombatant, eventCondition: ["SourcePosition:{\"X\":95.00,\"Y\":0.00,\"Z\":112.00}"])]
    public void P3三连桶A右(Event @event, ScriptAccessory accessory)
    {
        var dp = accessory.Data.GetDefaultDrawProperties();
        if (@event["SourceName"] == "爆破岩石" && sanliantong == true)
        { 
            
            dp.Name = "3号桶";
            dp.Scale = new(1);
            dp.Delay = 2000;
            dp.DestoryAt = 12000;
            dp.Color = new(0.3f, 1.0f, 0f,1.5f);
            dp.Position = new(105, 0, 105);
            accessory.Method.SendDraw(DrawModeEnum.Default, DrawTypeEnum.Circle, dp);
            sanliantong = false;
        }
    }

    [ScriptMethod(name: "P3三连桶A左", eventType: EventTypeEnum.AddCombatant, eventCondition: ["SourcePosition:{\"X\":105.00,\"Y\":0.00,\"Z\":112.00}"])]
    public void P3三连桶A左(Event @event, ScriptAccessory accessory)
    {
        var dp = accessory.Data.GetDefaultDrawProperties();
        if (@event["SourceName"] == "爆破岩石" && sanliantong == true)
        { 
            dp.Name = "3号桶";
            dp.Scale = new(1);
            dp.Delay = 2000;
            dp.DestoryAt = 12000;
            dp.Color = new(0.3f, 1.0f, 0f,1.5f);
            dp.Position = new(95, 0, 105);
            accessory.Method.SendDraw(DrawModeEnum.Default, DrawTypeEnum.Circle, dp);
            sanliantong = false;
        }
    }
    [ScriptMethod(name: "P3三连桶D右", eventType: EventTypeEnum.AddCombatant, eventCondition: ["SourcePosition:{\"X\":112.00,\"Y\":0.00,\"Z\":105.00}"])]
    public void P3三连桶D右(Event @event, ScriptAccessory accessory)
    {
        var dp = accessory.Data.GetDefaultDrawProperties();
        if (@event["SourceName"] == "爆破岩石" && sanliantong == true)
        { 
            dp.Name = "3号桶";
            dp.Scale = new(1);
            dp.Delay = 2000;
            dp.DestoryAt = 12000;
            dp.Color = new(0.3f, 1.0f, 0f,1.5f);
            dp.Position = new(105, 0, 95);
            accessory.Method.SendDraw(DrawModeEnum.Default, DrawTypeEnum.Circle, dp);
            sanliantong = false;
        }
    }
    [ScriptMethod(name: "P3三连桶D左", eventType: EventTypeEnum.AddCombatant, eventCondition: ["SourcePosition:{\"X\":112.00,\"Y\":-0.00,\"Z\":95.00}"])]
    public void P3三连桶D左(Event @event, ScriptAccessory accessory)
    {
        var dp = accessory.Data.GetDefaultDrawProperties();
        if (@event["SourceName"] == "爆破岩石" && sanliantong == true)
        { 
            dp.Name = "3号桶";
            dp.Scale = new(1);
            dp.Delay = 2000;
            dp.DestoryAt = 12000;
            dp.Color = new(0.3f, 1.0f, 0f,1.5f);
            dp.Position = new(105, 0, 105);
            accessory.Method.SendDraw(DrawModeEnum.Default, DrawTypeEnum.Circle, dp);
            sanliantong = false;
        }
    }
    [ScriptMethod(name: "P3三连桶C左", eventType: EventTypeEnum.AddCombatant, eventCondition: ["SourcePosition:{\"X\":95.00,\"Y\":-0.00,\"Z\":88.00}"])]
    public void P3三连桶C左(Event @event, ScriptAccessory accessory)
    {
        var dp = accessory.Data.GetDefaultDrawProperties();
        if (@event["SourceName"] == "爆破岩石" && sanliantong == true)
        { 
            dp.Name = "3号桶";
            dp.Scale = new(1);
            dp.Delay = 2000;
            dp.DestoryAt = 12000;
            dp.Color = new(0.3f, 1.0f, 0f,1.5f);
            dp.Position = new(105, 0, 95);
            accessory.Method.SendDraw(DrawModeEnum.Default, DrawTypeEnum.Circle, dp);
            sanliantong = false;
        }
    }
    [ScriptMethod(name: "P3三连桶C右", eventType: EventTypeEnum.AddCombatant, eventCondition: ["SourcePosition:{\"X\":105.00,\"Y\":-0.00,\"Z\":88.00}"])]
    public void P3三连桶C右(Event @event, ScriptAccessory accessory)
    {
        var dp = accessory.Data.GetDefaultDrawProperties();
        if (@event["SourceName"] == "爆破岩石" && sanliantong == true)
        { 
            dp.Name = "3号桶";
            dp.Scale = new(1);
            dp.Delay = 2000;
            dp.DestoryAt = 12000;
            dp.Color = new(0.3f, 1.0f, 0f,1.5f);
            dp.Position = new(95, 0, 95);
            accessory.Method.SendDraw(DrawModeEnum.Default, DrawTypeEnum.Circle, dp);
            sanliantong = false;
        }
    }
    [ScriptMethod(name: "P3三连桶B右", eventType: EventTypeEnum.AddCombatant, eventCondition: ["SourcePosition:{\"X\":88.00,\"Y\":-0.00,\"Z\":95.00}"])]
    public void P3三连桶B右(Event @event, ScriptAccessory accessory)
    {
        var dp = accessory.Data.GetDefaultDrawProperties();
        if (@event["SourceName"] == "爆破岩石" && sanliantong == true)
        { 
            dp.Name = "3号桶";
            dp.Scale = new(1);
            dp.Delay = 2000;
            dp.DestoryAt = 12000;
            dp.Color = new(0.3f, 1.0f, 0f,1.5f);
            dp.Position = new(95, 0, 105);
            accessory.Method.SendDraw(DrawModeEnum.Default, DrawTypeEnum.Circle, dp);
            sanliantong = false;
        }
    }
    [ScriptMethod(name: "P3三连桶B左", eventType: EventTypeEnum.AddCombatant, eventCondition: ["SourcePosition:{\"X\":88.00,\"Y\":-0.00,\"Z\":105.00}"])]
    public void P3三连桶B左(Event @event, ScriptAccessory accessory)
    {
        var dp = accessory.Data.GetDefaultDrawProperties();
        if (@event["SourceName"] == "爆破岩石" && sanliantong == true)
        { 
            dp.Name = "3号桶";
            dp.Scale = new(1);
            dp.Delay = 2000;
            dp.DestoryAt = 12000;
            dp.Color = new(0.3f, 1.0f, 0f,1.5f);
            dp.Position = new(95, 0, 95);
            accessory.Method.SendDraw(DrawModeEnum.Default, DrawTypeEnum.Circle, dp);
            sanliantong = false;
        }
    }
    
    [ScriptMethod(name: "P3三连桶点名", eventType: EventTypeEnum.ActionEffect, eventCondition: ["ActionId:regex:^(11116|11115)$"])]
    public void P3三连桶点名(Event @event, ScriptAccessory accessory)
    {

            if (!ParseHexId(@event["TargetId"], out var tid)) return;
            var playerindex = accessory.Data.PartyList.IndexOf(tid);//获取3个被点人在可达鸭里的队伍位置
            playerIndexList.Add(playerindex);//把3个人的位置存进playerIndexList
            bucketcount++;
            if (bucketcount == 3)//让三连桶事件只触发1次，不然3次石牢事件会触发3次
            {
                List<int> finalIndex = playerIndexList.OrderBy(n => customOrder.IndexOf(n)).ToList();//按照mt st d1234 h12的顺序排列
                var outputindex1 = accessory.Data.PartyList[finalIndex[0]];//确定顺序第1个人的id
                var outputindex2 = accessory.Data.PartyList[finalIndex[1]];//确定顺序第2个人的id
                var outputindex3 = accessory.Data.PartyList[finalIndex[2]];//确定顺序第3个人的id
                //accessory.Method.SendChat($"/e {string.Join(", ", finalIndex)}"); //debug用 测试点名
                accessory.Method.Mark(outputindex1, MarkType.Attack1, false); //给顺序1的人标1
                accessory.Method.Mark(outputindex2, MarkType.Attack2, false); //给顺序2的人标2
                accessory.Method.Mark(outputindex3, MarkType.Attack3, false); //给顺序3的人标3
            }
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
