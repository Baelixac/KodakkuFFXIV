using System;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using Dalamud.Utility.Numerics;
using KodakkuAssist.Data;
using KodakkuAssist.Script;
using KodakkuAssist.Module.GameEvent;
using KodakkuAssist.Module.Draw;
using KodakkuAssist.Module.Draw.Manager;
using static Dalamud.Interface.Utility.Raii.ImRaii;

namespace Weapontong;

[ScriptType(guid: "0374b7ed-6f72-4fb7-9c0c-ecb9641a1aed", name: "神兵3号桶位置", territorys: [777], version: "0.0.0.1", author: "RedBromine & Baelixac", note:"绝神兵土神三连桶3号桶位置标记，目前画的是人群击退之后缺口，前面那个石头的位置")]

public class Weapontong
{
    
    public bool sanliantong = true;

    [ScriptMethod(name: "重置战斗检测", eventType: EventTypeEnum.CombatChanged, eventCondition: ["Type:ResetCombat"])]
    public void 重置战斗检测(Event @event, ScriptAccessory accessory)
    {
         sanliantong = true;
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
    [ScriptMethod(name: "P3三连桶D左", eventType: EventTypeEnum.AddCombatant, eventCondition: ["SourcePosition:{\"X\":112.00,\"Y\":0.00,\"Z\":95.00}"])]
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
    
    //后面可能有些很迷的东西算了能跑就行
    
    /*[ScriptMethod(name: "P1寒风之歌", eventType: EventTypeEnum.TargetIcon, eventCondition: ["Id:regex:^(0010)$"])]
    public void P1寒风之歌(Event @event, ScriptAccessory accessory)
    {
        if (!ParseHexId(@event["TargetId"], out var tid)) return;
        [ScriptMethod(name: "P1美翼寒风之歌", eventType: EventTypeEnum.SetObjPos, eventCondition: ["SourceId:regex:^(40001BA5)$"])]
        void P1美翼寒风之歌(Event @event, ScriptAccessory accessory)
        {
            if (!ParseHexId(@event["SourceId"], out var sid)) return;
            var dp = accessory.Data.GetDefaultDrawProperties();
            dp.Name = $"P1寒风之歌";
            dp.Scale = new(3, 30);
            dp.Color = accessory.Data.DefaultDangerColor;
            dp.Owner = sid;
            dp.TargetObject = tid;
            dp.DestoryAt = 5000;
            accessory.Method.SendDraw(DrawModeEnum.Default, DrawTypeEnum.Rect, dp);
        }
    }*/
    //想写整个神兵奈何技术实在GG 先这样吧勉强能用 东扒西扒了一些拼凑

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