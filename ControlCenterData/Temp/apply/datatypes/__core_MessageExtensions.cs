using System;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Text.RegularExpressions;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using DT;
using DT.Exceptions;
using Metadata;
using DT.Utilities;
using DT.MdmMetadata.Types;
using DT.MdmMetadata.CoreEntity;
using DT.MdmMetadata.BusinessProcesses;
using DT.MdmMetadata.BusinessProcesses.Steps.Conditional;
using DT_TypeBuilder.CodeGen;
using DT_TypeBuilder;
using DT_TypeBuilder.Core;
using DT.TypeBuilding;
using DT_TypeBuilder.CodeGen.Expressions;
using Adk.Infrastructure.Log;
using Adk.Infrastructure;
using MsgPack.Serialization;
using DT.MdmServices;
using DT.ClusterConfiguration;
using DT_TypeBuilder.Core.Interfaces;
using DT_Processes.Services;
using DT.Metadata.Ontology;
using DT.NodeMessageProcessing.Archive;
using DT.Diagnostics.Log;
using DT.Diagnostics;
using DT.Diagnostics.Trace;
using DT.LogExtentions.OperativeLog;
using DT.Databank;
using System.Xml.Serialization;
using System.ServiceModel;

namespace SystemModels {

public static  class MessageExtensions
{
public static BaseClass GetBodyAsDataType(this Message msg)
{
    if (msg == null || !msg.HasDataType()) return null;
        return msg.GetDataTypeId().ToString() switch 
        {
         "515aa5c6-e6a8-4319-83c9-c06d5bbf30a6" => msg.CastToDataType<ТипДанныхФайл>(),
         "ed6f4499-3f89-48c5-9c4f-5126a40ac8f0" => msg.CastToDataType<DataTypeFile>(),
         _ => null
        };
}


public static BaseClass GetBodyAsSystemDataType(this Message msg)
{
        if (msg == null || !msg.HasSystemDataType()) return null;
        return msg.GetSystemDataTypeId().ToString() switch 
        {
         _ => null
        };
}


public static OwnList<BaseClass> GetBodyAsArrayOfDataTypes(this Message msg)
{
        if (msg == null || !msg.HasDataType()) return null;
        return msg.GetDataTypeId().ToString() switch 
        {
         "515aa5c6-e6a8-4319-83c9-c06d5bbf30a6" => msg.GetBodyAsArrayOfObjects<ТипДанныхФайл>(),
         "ed6f4499-3f89-48c5-9c4f-5126a40ac8f0" => msg.GetBodyAsArrayOfObjects<DataTypeFile>(),
         _ => null
        };
}


public static OwnList<BaseClass> GetBodyAsArrayOfSystemDataTypes(this Message msg)
{
        if (msg == null || !msg.HasSystemDataType()) return null;
        return msg.GetSystemDataTypeId().ToString() switch 
        {
         _ => null
        };
}


 public static Metadata.DataTypes GetDataType(this Message msg)
 {
        if (msg == null) return Metadata.DataTypes.Empty;
        return msg.GetDataTypeId().ToString() switch {
            "515aa5c6-e6a8-4319-83c9-c06d5bbf30a6" => Metadata.DataTypes.ТипДанныхФайл,
            "ed6f4499-3f89-48c5-9c4f-5126a40ac8f0" => Metadata.DataTypes.DataTypeFile,
         _ => Metadata.DataTypes.Empty
        };
 }

 public static bool SetDataType(this Message msg, Metadata.DataTypes value)
 {
       if (msg == null) return false;
        if (value == Metadata.DataTypes.Empty)
        {
         msg.SetDataTypeId(Guid.Empty);
         return true;
        }
        Guid id = value switch {
            Metadata.DataTypes.ТипДанныхФайл => new Guid("515aa5c6-e6a8-4319-83c9-c06d5bbf30a6"),
            Metadata.DataTypes.DataTypeFile => new Guid("ed6f4499-3f89-48c5-9c4f-5126a40ac8f0"),
         _ => Guid.Empty
        };
        return msg.TrySetDataTypeId(id);
 }

 public static Metadata.SM GetSystemDataType(this Message msg)
 {
        if (msg == null) return Metadata.SM.Empty;
        return msg.GetSystemDataTypeId().ToString() switch {
         _ => Metadata.SM.Empty
        };
 }

 public static bool SetSystemDataType(this Message msg, Metadata.SM value)
 {
       if (msg == null) return false;
        if (value == Metadata.SM.Empty)
        {
         msg.SetSystemDataTypeId(Guid.Empty);
         return true;
        }
        Guid id = value switch {
         _ => Guid.Empty
        };
        return msg.TrySetSystemDataTypeId(id);
 }

 public static Metadata.Systems GetSource(this Message msg)
 {
        if (msg == null) return Metadata.Systems.Empty;
        return msg.GetInitialSourceId().ToString() switch {
            "0e5acb3a-05c1-42f2-94aa-e75d1ace2e38" => Metadata.Systems.FileOut,
            "c19daf81-5968-4964-b93a-81b09d63a36e" => Metadata.Systems.File1,
            "8fe6d5a7-ba5c-494c-bcf3-f8be6471ea81" => Metadata.Systems.File2,
            "03ecf3d0-070b-4133-ae7b-832414500060" => Metadata.Systems.RestIn,
         _ => Metadata.Systems.Empty
        };
 }

 public static OwnList<Metadata.Systems> GetReceivers(this Message msg)
 {
        var result = new OwnList<Metadata.Systems>();
        foreach (var receiver in msg.GetReceiversList())
        {
         var system = SystemsExtensions.GetSystemByGuid(receiver.Id);
         if (system != Metadata.Systems.Empty)
             result.Add(system);
        }
       return result;
 }
 public static bool AddReceivers(this Message msg, OwnList<Metadata.Systems> systems)
 {
       var systemIds = systems.Select(s => s.GetId());
       if (systemIds.Any(m => m == Guid.Empty)) return false;
       foreach (var systemId in systemIds)
        {
        msg.AddReceiver(systemId);
        }
       return true;
 }
 public static bool AddReceiver(this Message msg, Metadata.Systems system)
 {
       var systemId = system.GetId();
       if (systemId == Guid.Empty) return false;
        msg.AddReceiver(systemId);
       return true;
 }
 public static bool RemoveReceiver(this Message msg, Metadata.Systems system)
 {
       var systemId = system.GetId();
       if (systemId == Guid.Empty) return false;
        msg.RemoveReceiver(systemId);
       return true;
 }
 public static Metadata.Handlers GetHandler(this Message msg)
 {
        if (!msg.Properties.TryGetValue<Guid>("Dt_HandlerId", out var handlerId))
        return Metadata.Handlers.Empty;
        return handlerId.ToString() switch {
       "05625a15-e0ec-4f59-94a1-f21d7964c736" =>  Metadata.Handlers.PlatformToFile,
       "9dce2d9b-d26a-4218-bd97-4abd626d5763" =>  Metadata.Handlers.RestInb,
       "3a5339ef-25db-4f0b-824b-7e3b68c562da" =>  Metadata.Handlers.FileToPlatform,
        _ => Metadata.Handlers.Empty
        };
 }
}

}

