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

[SystemTypeEnumAttribute(SystemEnumeration.Handler)]
public enum Handlers
{
    Empty = 0,

    [SystemTypeAttribute("05625a15-e0ec-4f59-94a1-f21d7964c736")]
    PlatformToFile,

    [SystemTypeAttribute("9dce2d9b-d26a-4218-bd97-4abd626d5763")]
    RestInb,

    [SystemTypeAttribute("3a5339ef-25db-4f0b-824b-7e3b68c562da")]
    FileToPlatform
}

public static  class HandlersExtensions
{
    private static readonly ISystemTypeMap<Metadata.Handlers> Map;

    static HandlersExtensions()
    {
        Map = MetadataInfo.TypeSite.Get<Metadata.Handlers>();
    }

    public static Guid GetId(this Handlers type) => Map.GetTypeId(type);

    public static Handlers ById(Guid id) => Map.GetValue(id);

    public static string GetName(this Handlers type) => type.ToString();

    public static Handler GetConfig(this Handlers type)
    {
         var service = ServiceLocator.Instance.TryGetService<IConfigProvider>();

         if(service == null)
             return null;

         return service.GetConfig<Handler>(Map.GetTypeId(type));
    }

public static HandlerInfo GetHandlerInfo(this Metadata.Handlers handler) => handler switch {
 Metadata.Handlers.PlatformToFile  => new HandlerInfo(
                                            new Guid("05625a15-e0ec-4f59-94a1-f21d7964c736"),
                                            "PlatformToFile",
                                            "PlatformToFile",
                                            ConnectorType.None,
                                            new PropertiesCollection(),
                                            true,
                                            false,
        Metadata.DataTypes.ТипДанныхФайл,
        Metadata.SM.Empty),
 Metadata.Handlers.RestInb  => new HandlerInfo(
                                            new Guid("9dce2d9b-d26a-4218-bd97-4abd626d5763"),
                                            "RestInb",
                                            "RestInb",
                                            ConnectorType.Web,
                                            new PropertiesCollection(),
                                            false,
                                            false,
        Metadata.DataTypes.Empty,
        Metadata.SM.Empty),
 Metadata.Handlers.FileToPlatform  => new HandlerInfo(
                                            new Guid("3a5339ef-25db-4f0b-824b-7e3b68c562da"),
                                            "FileToPlatform",
                                            "FileToPlatform",
                                            ConnectorType.None,
                                            new PropertiesCollection(),
                                            false,
                                            false,
        Metadata.DataTypes.Empty,
        Metadata.SM.Empty),
 _ => null
};

}

}

