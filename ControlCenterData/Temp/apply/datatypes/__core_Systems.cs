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

[SystemTypeEnumAttribute(SystemEnumeration.System)]
public enum Systems
{
    Empty = 0,

    [SystemTypeAttribute("0e5acb3a-05c1-42f2-94aa-e75d1ace2e38")]
    FileOut,

    [SystemTypeAttribute("c19daf81-5968-4964-b93a-81b09d63a36e")]
    File1,

    [SystemTypeAttribute("8fe6d5a7-ba5c-494c-bcf3-f8be6471ea81")]
    File2,

    [SystemTypeAttribute("03ecf3d0-070b-4133-ae7b-832414500060")]
    RestIn
}

public static  class SystemsExtensions
{
    private static readonly ISystemTypeMap<Metadata.Systems> Map;

    static SystemsExtensions()
    {
        Map = MetadataInfo.TypeSite.Get<Metadata.Systems>();
    }

    public static Guid GetId(this Systems type) => Map.GetTypeId(type);

    public static Systems ById(Guid id) => Map.GetValue(id);

    public static string GetName(this Systems type) => type.ToString();

    public static DtSystem GetConfig(this Systems type)
    {
         var service = ServiceLocator.Instance.TryGetService<IConfigProvider>();

         if(service == null)
             return null;

         return service.GetConfig<DtSystem>(Map.GetTypeId(type));
    }
    public static SystemInfo GetSystemInfo(this Systems system)
    {
        var id = Map.GetTypeId(system);
        if (id == Guid.Empty)
        {
            return null;
        }

        return TypesEnvironment.GetSystemInfo(id);
    }

    public static Systems GetSystemByGuid(Guid id) => Map.GetValue(id);
}

}

