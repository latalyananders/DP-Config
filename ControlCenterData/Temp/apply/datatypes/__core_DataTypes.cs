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

namespace Metadata {

using SystemModels;

[SystemTypeEnumAttribute(SystemEnumeration.DataType)]
public enum DataTypes
{
    Empty = 0,

    [SystemTypeAttribute("515aa5c6-e6a8-4319-83c9-c06d5bbf30a6", typeof(global::SystemModels.ТипДанныхФайл))]
    ТипДанныхФайл,

    [SystemTypeAttribute("ed6f4499-3f89-48c5-9c4f-5126a40ac8f0", typeof(global::SystemModels.DataTypeFile))]
    DataTypeFile
}

public static  class DataTypesExtensions
{
    private static readonly ISystemTypeMap<Metadata.DataTypes> Map;

    static DataTypesExtensions()
    {
        Map = MetadataInfo.TypeSite.Get<Metadata.DataTypes>();
    }

    public static Guid GetId(this DataTypes type) => Map.GetTypeId(type);

    public static DataTypes ById(Guid id) => Map.GetValue(id);

    public static string GetName(this DataTypes type) => type.ToString();

    public static DataType GetConfig(this DataTypes type)
    {
         var service = ServiceLocator.Instance.TryGetService<IConfigProvider>();

         if(service == null)
             return null;

         return service.GetConfig<DataType>(Map.GetTypeId(type));
    }
    public static DataTypes GetDataType(this BaseClass obj) => Map.GetValue(obj?.GetType()?.Name);

    public static DataTypes GetDataType(this LinkType obj)
    {
        var id = obj?.DataTypeId;
        return id.HasValue ? Map.GetValue(id.Value) : DataTypes.Empty;
    }

    public static LinkType CreateLink(this Metadata.DataTypes dataType) => new LinkType(dataType.GetId());

    public static LinkType CreateLink(this Metadata.DataTypes dataType, Guid entityId) => new LinkType(entityId, dataType.GetId());

    public static bool IsCategory(this Metadata.DataTypes dataType)
    {
        return dataType switch 
        {
         DataTypes.ТипДанныхФайл => false,
         DataTypes.DataTypeFile => false,
         _ => false
        };
    }

}

}

